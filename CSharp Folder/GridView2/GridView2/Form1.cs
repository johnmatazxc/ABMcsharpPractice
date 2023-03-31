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

namespace GridView2
{
    public partial class Form1 : Form
    {

        static string serverName = "SWINDZ" + '\\' + "SQLEXPRESS";
        static string database = "User";
        static string user = "sa";
        static string password = "john29";
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
            label1.Text = "Employee Name";
            label2.Text = "Age";
            label3.Text = "Gender";
            label4.Text = "Salary";
            label5.Text = "Position";
            label6.Text = "Team Lead";
            button1.Text = "Submit";

            loadDataGrid();
        }

        public void loadDataGrid()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_selectAllEmployeeTbl", conn);
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

        public void insertData(string employeeName)
        {

            try
            {
                conn.Open();

                cmd = new SqlCommand("usp_insertIntoEmployeeTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employeeName", SqlDbType.NVarChar).Value = employeeName;
        
                // AGE
                if (textBox3.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@age", SqlDbType.Char).Value = Int32.Parse(textBox2.Text.Trim());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@age", SqlDbType.Char).Value = DBNull.Value;
                }

                // GENDER
                if (textBox3.Text.Trim().Length != 0) {
                    cmd.Parameters.AddWithValue("@gender", SqlDbType.Char).Value = textBox3.Text.Trim()[0];
                } else
                {
                    cmd.Parameters.AddWithValue("@gender", SqlDbType.Char).Value = DBNull.Value;
                }

                // SALARY
                if (textBox4.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@salary", SqlDbType.Char).Value = Convert.ToDouble(textBox4.Text.Trim());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@salary", SqlDbType.Char).Value = DBNull.Value;
                }

                // POSITION
                if (textBox5.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@position", SqlDbType.Char).Value = textBox5.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@position", SqlDbType.Char).Value = DBNull.Value;
                }

                // TEAM LEAD
                if (textBox6.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@teamLead", SqlDbType.Char).Value = textBox6.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@teamLead", SqlDbType.Char).Value = DBNull.Value;
                }



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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Trim().Length.Equals(0)) {

                string employeeName = textBox1.Text.Trim();
                
                insertData(employeeName);
            }

        }
    }
}
