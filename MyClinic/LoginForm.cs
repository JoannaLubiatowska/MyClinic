using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClinic
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = LoginButton;
        }

        private Boolean openNextWindow(string windowName)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == windowName)
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (openNextWindow("MainClinicWindow"))
            {
                try
                {
                    if (Authenticator.Instance.LoginForm(textBoxLogin.Text, textBoxPassword.Text))
                    {
                        MainWindow window = new MainWindow();
                        window.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login lub hasło nieprawidłowe. Spróbuj ponownie.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
