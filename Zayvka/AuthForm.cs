using System;
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
    public partial class AuthForm : Form
    {
        private UserProvider userProvider = new UserProvider();

        public AuthForm()
        {
            InitializeComponent();
        }

        private void regLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.ShowDialog();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string login = loginTxt.Text.Trim();
                string password = passwordTxt.Text.Trim();
                if (login.Length < 0)
                {
                    MessageBox.Show("Укажите логин");
                }
                if (password.Length < 0)
                {
                    MessageBox.Show("Укажите логин");
                }

                User user = userProvider.Authorization(login, password);

                ApplicationListForm application = new ApplicationListForm(user);
                application.FormClosed += (s, args) => Close();
                application.Show();
                Hide();
            } catch
            {
                MessageBox.Show("Укажите верные данные для входа");
            }
        }
    }
}
