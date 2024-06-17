using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zayvka.model;
using Zayvka.provider;

namespace Zayvka
{
    public partial class ApplicationListForm : Form
    {
        private User user = new User();
        private List<Applications> applications = new List<Applications>();
        private ApplicationProvider applicationProvider = new ApplicationProvider();
        private StatisticProvider statisticProvider = new StatisticProvider();
        private string searchString = string.Empty;

        public ApplicationListForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void ApplicationListForm_Load(object sender, EventArgs e)
        {
            if (user.Role != "Менеджер")
            {
                statsBtn.Visible = false;
            }
            UpdateApplications();
        }

        private void createApplication_Click(object sender, EventArgs e)
        {
            CreateApplicationForm applicationForm = new CreateApplicationForm(user);
            applicationForm.ShowDialog();
        }

        public void UpdateApplications()
        {
            applications = applicationProvider.GetApplications(user);
            if (user.Role == "Клиент")
            {
                foreach (Applications app in applications)
                {
                    if (app.isNewStatus)
                    {
                        MessageBox.Show($"Статус заявки №{app.Id} обновлён. Новый статус: {app.Status}.");
                        applicationProvider.UpdateIsNewStatus(app.Id);
                    }
                }
            }

            List<Applications> newApplications = applications;

            if (!string.IsNullOrEmpty(searchString))
            {
                newApplications = applications
                    .Where(a => a.Id.ToString().Equals(searchString) 
                            || a.Client.Equals(searchString) 
                            || a.Equipment.Equals(searchString))
                    .ToList();
            }

            applicationsFlowPanel.Controls.Clear();

            foreach (Applications application in newApplications)
            {
                ApplicationControl applicationControl = new ApplicationControl(application);
                applicationsFlowPanel.Controls.Add(applicationControl);
            }
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string statistic = "Всего выполнено: " + statisticProvider.GetTotalCount();
                statistic += "\nСреднее время: " + statisticProvider.GetMiddleTime();
                foreach (Statistics statistics in statisticProvider.GetAllStatistics())
                {
                    statistic += statistics.ToString();
                }
                MessageBox.Show(statistic);
            } catch
            {
                MessageBox.Show("Получение статистики недоступно");
            }
        }

        private void searchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchString = searchTxt.Text;

            List<Applications> newApp = applications
                .Where(a => a.Id.ToString().Equals(searchString)
                        || a.Client.Equals(searchString)
                        || a.Equipment.Equals(searchString))
                .ToList();

            applicationsFlowPanel.Controls.Clear();

            foreach (Applications application in newApp)
            {
                ApplicationControl applicationControl = new ApplicationControl(application);
                applicationsFlowPanel.Controls.Add(applicationControl);
            }
        }
    }
}
