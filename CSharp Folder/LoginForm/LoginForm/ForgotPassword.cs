using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = "Enter username";
            
            userTextBox.Text = Data.username;
            userTextBox.ReadOnly = true;
            passwordLbl.Text = "Enter your new password";
            confirmPassLbl.Text = "Confirm new password";
            button1.Text = "Submit";

            confirmErrorLbl.Text = "Password are not match";
            confirmErrorLbl.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passTextBox.Text != "" && confirmTextBox.Text != "")
            {
                if (passTextBox.Text.Equals(confirmTextBox.Text))
                {
                    MessageBox.Show("Password was successfully changed");
                } else
                {
                    confirmErrorLbl.Show();
                }
            }
        }
    }
}
