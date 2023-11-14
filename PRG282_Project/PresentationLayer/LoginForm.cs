using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Project.DataLayer;

namespace PRG282_Project.PresentationLayer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        

        private void ClearFormInputs()
        {
            UserNameBox.Text = string.Empty;
            PassWordBox.Text = string.Empty;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginDataHandler handler = new LoginDataHandler();
            string userName = UserNameBox.Text;
            string password = PassWordBox.Text;

            bool credentialsValid = handler.IsValidCredentials(userName, password);

            if (credentialsValid)
            {
                MessageBox.Show("Logged in successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
                ClearFormInputs();
            }
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            LoginDataHandler handler = new LoginDataHandler();
            string userName = UserNameBox.Text;

            bool userExists = handler.IsExistingUser(userName);

            if (userExists)
            {
                MessageBox.Show("This user already exists.");
                ClearFormInputs();
            }
            else
            {
                string password = PassWordBox.Text;
                handler.AddUser(userName, password);
                MessageBox.Show($"{userName} added successfully\nPlease re-enter details to login.");
                ClearFormInputs();
            }

        }
    }
}
