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

namespace InsertUpdateDatabase
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
            userLbl.Text = "Username";
            passLbl.Text = "Password";
            insert.Text = "Insert";

            idLbl.Text = "ID";
            updateUserLbl.Text = "Username";
            updatePassLbl.Text = "Password";
            update.Text = "Update";
            
            idDeleteLbl.Text = "ID";
            delete.Text = "Delete";

            loadDataGrid();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string username = userTxtBox.Text.Trim();
            string password = passTxtBox.Text.Trim();

            if (!username.Equals(null) && !password.Equals(null))
            {
                MessageBox.Show(insertData(username, password) ?
                    "Insert Successfully" : "Insert Failed");
                
            }
        }

        public bool insertData(string username, string password)
        {
            bool result = false;

            try
            {
                string query = "INSERT INTO " + table + " (username, password, isActive) values(@username, @password, @isActive)";

                conn.Open();

                cmd = new SqlCommand(query, conn);
               
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@isActive", true);

                int exe = cmd.ExecuteNonQuery();

                if (exe == 1)
                {
                    MessageBox.Show("Record inserted successfully");
                    result = true;
                }
                else
                {
                    MessageBox.Show("Record failed to insert");
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




        public bool updateData(string id, string username, string password)
        {
            bool result = false;

            try
            {
                string query = "UPDATE " + table + " SET username=@username, password=@password where id=@id";

                conn.Open();

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@id", id);

                int exe = cmd.ExecuteNonQuery();

                if (exe == 1)
                {
                    MessageBox.Show("Record updated successfully");
                    result = true;
                }
                else
                {
                    MessageBox.Show("Record failed to update");
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

        private void update_Click(object sender, EventArgs e)
        {
            string id = idTxtBox.Text.Trim();
            string username = updateUserTxtBox.Text.Trim();
            string password = updatePassTxtBox.Text.Trim() ;

            if (!id.Equals(null) && !username.Equals(null) && !password.Equals(null))
            {
                MessageBox.Show(updateData(id, username, password) ?
                    "Update Successfully" : "Update Failed");

            }
        }


        public bool deleteData(string id)
        {
            bool result = false;

            try
            {
                string query = "DELETE FROM " + table + " where id=@id";
                conn.Open();

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
   
                

                Console.WriteLine(query);

                int exe = cmd.ExecuteNonQuery();

                if (exe == 1)
                {
                    MessageBox.Show("Record searched successfully");
                    result = true;
                }
                else
                {
                    MessageBox.Show("Record failed to searched");
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

        private void delete_Click(object sender, EventArgs e)
        {
            string id = deleteIdTxtBox.Text.Trim();

            if (!id.Equals(null))
            {
                MessageBox.Show(deleteData(id) ?
                    "Delete Successfully" : "Delete Failed");

            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }

        public void loadDataGrid()
        {
            try
            {
                string query = "SELECT * FROM " + table;

                conn.Open();

                cmd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "";
                checkBoxColumn.Width = 30;
                checkBoxColumn.Name = "checkBoxColumn";
                dataGridView1.Columns.Insert(0, checkBoxColumn);




                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                    
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
        }
    }
}
