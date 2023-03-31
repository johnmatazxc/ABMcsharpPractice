using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CheckingDatabase
{
    public partial class Form1 : Form
    {

        static string serverName = "SWINDZ" + '\\' + "SQLEXPRESS";
        static string database = "User";
        static string user = "sa";
        static string password = "john29";
        static string table = "UserTbl";
        static string connectionString = @"Data Source=" + serverName + ";Initial Catalog=" + database + ";User ID =" + user +
            ";Password =" + password;

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Username";
            label2.Text = "Password";
            button1.Text = "Insert";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();

            
            if (isExist(username))
            {
                MessageBox.Show("Username already exists");
            } else
            {

            }
        }

        public bool isExist(string username)
        {
            bool result = false;
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_checkIfExist", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = username;

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

         
                MessageBox.Show(dt.Rows[0]["Result"].ToString());

                if (dt.Rows[0]["Result"].ToString().Equals("1")) {
                    result = true;
                }
      

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
                conn.Close();
            }

            return result;
        }

 
    }
}
