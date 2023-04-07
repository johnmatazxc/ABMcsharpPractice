using NETExam1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public partial class Login : Form
    {
        static string serverName = "SWINDZ" + '\\' + "SQLEXPRESS";
        static string database = "DemoDb";
        static string user = "sa";
        static string password = "john29";
        static string table = "UserTbl";
        static string connectionString = @"Data Source=" + serverName + ";Initial Catalog=" + database + ";User ID =" + user +
            ";Password =" + password;

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            usernameLbl.Text = "Username";
            passwordLbl.Text = "Password";
            loginBtn.Text = "Login";
            createAccountLbl.Text = "Register";

            usernameErrorLbl.Visible = false;
            passwordErrorLbl.Visible = false;
            errorLbl.Visible = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text.Trim();
            string password = passwordTextbox.Text.Trim();

            bool isExist = checkUserTbl(username, password);

            if (isExist)
            {
                MessageBox.Show("Login Successfully");
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                errorLbl.Visible = true;
               
                errorLbl.Text = "Wrong username and password";
            }

            
        }

        private bool checkUserTbl(string username, string password)
        {
            bool result = false;
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_checkUserTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int exe = cmd.ExecuteNonQuery();
               
                string row = dt.Rows[0][0].ToString();
  
       

                if (row != "0")
                {
                    result = true;
                } else
                {
                    result= false;
                }

            
                



                conn.Close();

            }

            catch (Exception ex)
            {
                
            }

            finally
            {
                conn.Close();
            }

            return result;
        }
    }
}
