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

namespace Gridview
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

        private void Form1_Load(object sender, EventArgs e)
        {
            search.Text = "SEARCH";

            loadDataGrid();
        }

        public void loadDataGrid()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_selectAll", conn);
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

        private void search_Click(object sender, EventArgs e)
        {
            string searchVal = searchTxtBox.Text;

            populateDataGrid(searchVal);
        }

        public void populateDataGrid(string searchVal)
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_selectAllFrmTable", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", SqlDbType.NVarChar).Value = searchVal;
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
    }
}
