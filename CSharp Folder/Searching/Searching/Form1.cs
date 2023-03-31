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

namespace Searching
{
    public partial class Form1 : Form
    {

        static string serverName = "SWINDZ" + '\\' + "SQLEXPRESS";
        static string database = "DemoDb";
        static string user = "sa";
        static string dbpassword = "john29";
        static string connectionString = @"Data Source=" + serverName + ";Initial Catalog=" + database + ";User ID =" + user +
            ";Password =" + dbpassword;

        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Username";
            label2.Text = "Password";
            label3.Text = "IGN";
            label5.Text = "Job";
            button1.Text = "Search";
            populateDataGrid();

        }

        public void populateDataGrid()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_selectGameUserInfo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
       
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
                conn.Close();
            }
        }

        public void searchTable()
        {

            string username = "%" + textBox1.Text + "%";
            string password = "%" + textBox2.Text + "%";
            string ign = "%" + textBox3.Text + "%";

           
            string charJob = "%" + textBox5.Text + "%";
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_selectLikeGameUserInfoTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value = password;
                cmd.Parameters.AddWithValue("@ign", SqlDbType.NVarChar).Value = ign;
               
         
                cmd.Parameters.AddWithValue("@charJob", SqlDbType.NVarChar).Value = charJob;

   

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            finally
            {
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchTable();    
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
