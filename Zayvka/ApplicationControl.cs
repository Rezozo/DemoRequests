using System;
using System.Windows.Forms;
using Zayvka.model;
using Zayvka.provider;

namespace Zayvka
{
    public partial class ApplicationControl : UserControl
    {
        Applications application { get; set; }
        private ApplicationProvider applicationProvider = new ApplicationProvider();

        public ApplicationControl(Applications application)
        {
            this.application = application;
            InitializeComponent();
        }

        private void ApplicationControl_Load(object sender, EventArgs e)
        {
            numberLbl.Text += application.Id;
            clientNameLbl.Text += application.Client + " " + application.ClientNumber;
            equipmentLbl.Text += application.Equipment;
            faultLbl.Text += application.Fault;
            problemTxt.Text += application.Problem;
            commentTxt.Text += application.Comment;
            statusBox.Text += application.Status;
            staffBox.Text += application.Staff;
            phoneNumberLbl.Text += application.StaffNumber;
            finishDatePick.Value = application.FinishDate;
            priorityBox.Text = application.Priority;
        }

        private void commentTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            applicationProvider.UpdateComment(application.Id, commentTxt.Text);
        }
    }
}
