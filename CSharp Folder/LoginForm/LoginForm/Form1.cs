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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            titleLbl.Text = "LOGIN FORM";
            usernameLbl.Text = "Username";
            passwordLbl.Text = "Password";
            submit.Text = "Log In";
            userErrorLbl.Text = "Please enter username";
            userErrorLbl.Hide();

            passErrorLbl.Text = "Please enter password";
            passErrorLbl.Hide();

            forgotPassLbl.Text = "Forget Password";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (userTxtBox.Text != "" && passTxtBox.Text != "")
            {
                
                isValid(userTxtBox.Text, passTxtBox.Text);
            } else
            {
               if (userTxtBox.Text == "")
                {
                    userErrorLbl.Show();
                }

               if (passTxtBox.Text == "")
                {
                    passErrorLbl.Show();
            
                }
            }
        }
        
        private bool isValid(string username, string password)
        {
            bool isValid = false;

            // Insert Validation Here 

            Dictionary<string, string> databaseData = getDatabaseData();

            if (databaseData["username"].Equals(username))
            {
                // username is equals in the database
                if (databaseData["password"].Equals(password))
                {
                    isValid = true;
                } else
                {
                    passErrorLbl.Text = "Password is incorrect";
                    passErrorLbl.Show();
                }
            } else
            {
                userErrorLbl.Text = "Enter a valid username";
                userErrorLbl.Show();
            }
            

            return isValid;
        }

        private Dictionary<string, string> getDatabaseData()
        {
            var data = new Dictionary<string, string>();
            
            // connect to database

            // get data from database
            string user = "John";
            string pass = "P@ssw0rd!";

            data.Add("username", user);
            data.Add("password", pass);

            return data;
        }

        private void passwordLbl_Click(object sender, EventArgs e)
        {

        }

        private void forgotPassLbl_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPass = new ForgotPassword();
            forgotPass.Show();
            this.Hide();
        }

        private void userTxtBox_TextChanged(object sender, EventArgs e)
        {
            Data.username = userTxtBox.Text;
        }
    }
}
