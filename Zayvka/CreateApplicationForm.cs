using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zayvka.model;
using Zayvka.provider;

namespace Zayvka
{
    public partial class CreateApplicationForm : Form
    {
        private ApplicationProvider applicationProvider = new ApplicationProvider();
        private User user = new User();

        public CreateApplicationForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void CreateApplicationForm_Load(object sender, EventArgs e)
        {
            List<string> faults = applicationProvider.GetAllFault();
            typeBox.Items.AddRange(faults.ToArray());
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string equipment = equipmentTxt.Text.Trim();
            string problem = problemTxt.Text.Trim();
            string type = typeBox.Text.Trim();
            if (string.IsNullOrEmpty(equipment) || string.IsNullOrEmpty(problem) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Заполните все данные о заявке");
                return;
            }

            applicationProvider.CreateApplication(user.Id, type, equipment, problem, DateTime.Now.AddDays(3));
            MessageBox.Show("Заявка успешно создана!");
            Hide();
        }
    }
}
