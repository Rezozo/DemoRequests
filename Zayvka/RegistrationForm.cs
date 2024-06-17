using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zayvka.provider;

namespace Zayvka
{
    public partial class RegistrationForm : Form
    {
        private UserProvider userProvider = new UserProvider();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = full_name.Text.Trim();
                string phoneNumber = phone_number.Text.Trim();
                string login = loginTxt.Text.Trim();
                string password = passwordTxt.Text.Trim();
                if (fullName.Length == 0)
                {
                    MessageBox.Show("Укажите полное имя");
                    return;
                }
                if (phoneNumber.Length != 18)
                {
                    MessageBox.Show("Укажите корректный номер телефона");
                    return;
                }
                if (login.Length == 0)
                {
                    MessageBox.Show("Укажите логин");
                    return;
                }
                if (password.Length < 6)
                {
                    MessageBox.Show("Пароль должен содержать больше 6 символов");
                    return;
                }

                userProvider.CreateUser(login, password, phoneNumber, fullName);
                MessageBox.Show("Регистрация прошла успешно!");
                Close();
            } catch
            {
                MessageBox.Show("Пользователь с введенным логином уже существует!");
            }
        }
    }
}
