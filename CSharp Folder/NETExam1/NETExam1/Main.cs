using Exam1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NETExam1
{
    public partial class Main : Form
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
        string type;
        string mode;
        public Main()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

            // Customer
            idLbl.Text = "ID: ";
            nameLbl.Text = "Name: ";
            addressLbl.Text = "Address: ";
            numLbl.Text = "Phone: ";
            emailLbl.Text = "Email: ";
   
            panel2.Visible = false;
            panel1.Visible = false;
            button3.Visible = false;
            searchBox.Visible= false;
            customerDataGridView.Visible = false;


            // Employee
            empIdLbl.Text = "ID: ";
            empNameLbl.Text = "Name: ";
            empPositionLbl.Text = "Position: ";
            empSalaryLbl.Text = "Salary: ";
            empEmailLbl.Text = "Email: ";

            button3.Text = "Search";

            
            
            employeeDataGridView.Visible = false;

           hideErrorMsg();
            //hide();
        }

        private void hideErrorMsg()
        {
            idError.Visible= false;
            nameError.Visible= false;
            addressError.Visible= false;
            numError.Visible= false;
            emailError.Visible= false;
            empIdError.Visible= false;
            empNameError.Visible= false;
            empPositionError.Visible= false;
            empSalaryError.Visible= false;
            empEmailError.Visible= false;

            
        }

        private void hideCustomer()
        {

            idLbl.Visible = false;
            idTextbox.Visible = false;
            nameLbl.Visible = false;
            addressLbl.Visible = false;
            numLbl.Visible = false;
            emailLbl.Visible = false;

            nameTextbox.Visible = false;
            addressTextbox.Visible = false;
            numTextbox.Visible = false;
            emailTextbox.Visible = false;
            button1.Visible = false;
        }

        private void hideEmployee()
        {
            empIdLbl.Visible = false;
            empNameLbl.Visible = false;
            empPositionLbl.Visible = false;
            empSalaryLbl.Visible = false;
            empEmailLbl.Visible = false;
            empIdTextbox.Visible = false;
            empNameTextbox.Visible = false;
            empPositionTextbox.Visible = false;
            empSalaryTextbox.Visible = false;
            empEmailTextbox.Visible = false;
            button2.Visible = false;
        }

        private void custInsert()
        {
            panel1.Visible = true;
            panel2.Visible = false;
            idLbl.Visible = false;
            nameLbl.Visible = true;
            addressLbl.Visible = true;
            numLbl.Visible = true;
            emailLbl.Visible = true;
            idTextbox.Visible = false;
            nameTextbox.Visible = true;
            addressTextbox.Visible = true;
            numTextbox.Visible = true;
            emailTextbox.Visible = true;
            hideEmployee();

            button1.Visible = true;
            button1.Text = "Insert";

        }

        private void custUpdate()
        {
            panel1.Visible = true;
            panel2.Visible = false;
            idLbl.Visible = true;
            idTextbox.Visible = true;
            nameLbl.Visible = true;
            addressLbl.Visible = true;
            numLbl.Visible = true;
            emailLbl.Visible = true;
            
            nameTextbox.Visible = true;
            addressTextbox.Visible = true;
            numTextbox.Visible = true;
            emailTextbox.Visible = true;
            hideEmployee();

            button1.Visible = true;
            button1.Text = "Update";

        }

        private void custDelete()
        {
            panel1.Visible = true;
            panel2.Visible = false;
            idLbl.Visible = true;
            idTextbox.Visible = true;
            nameLbl.Visible = false;
            addressLbl.Visible = false;
            numLbl.Visible = false;
            emailLbl.Visible = false;
            nameTextbox.Visible = false;
            addressTextbox.Visible = false;
            numTextbox.Visible = false;
            emailTextbox.Visible = false;
            hideEmployee();

            button1.Visible = true;
            button1.Text = "Delete";

        }


        private void empInsert()
        {
            panel1.Visible = false;
            panel2.Visible = true;
            empIdLbl.Visible = false;
            empNameLbl.Visible = true;
            empPositionLbl.Visible = true;
            empSalaryLbl.Visible = true;
            empEmailLbl.Visible = true;
            empIdTextbox.Visible = false;
            empNameTextbox.Visible = true;
            empPositionTextbox.Visible = true;
            empSalaryTextbox.Visible = true;
            empEmailTextbox.Visible = true;
            hideCustomer();
            button2.Visible= true;
            button2.Text = "Insert";

        }

        private void empUpdate()
        {
            panel1.Visible = false;
            panel2.Visible = true;
            empIdLbl.Visible = true;
            empNameLbl.Visible = true;
            empPositionLbl.Visible = true;
            empSalaryLbl.Visible = true;
            empEmailLbl.Visible = true;
            empIdTextbox.Visible = true;
            empNameTextbox.Visible = true;
            empPositionTextbox.Visible = true;
            empSalaryTextbox.Visible = true;
            empEmailTextbox.Visible = true;
            hideCustomer();

            button2.Visible = true;
            button2.Text = "Update";

        }

        private void empDelete()
        {
            panel1.Visible = false;
            panel2.Visible = true;
            empIdLbl.Visible = true;
            empNameLbl.Visible = false;
            empPositionLbl.Visible = false;
            empSalaryLbl.Visible = false;
            empEmailLbl.Visible = false;
            empIdTextbox.Visible = true;
            empNameTextbox.Visible = false;
            empPositionTextbox.Visible = false;
            empSalaryTextbox.Visible = false;
            empEmailTextbox.Visible = false;
            hideCustomer();

            button2.Visible = true;
            button2.Text = "Delete";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerSelect_Click(object sender, EventArgs e)
        {
            type = "customer";
            mode = "insert";

            searchBox.Visible = true;
            button3.Visible = true;
            hideEmployee();
            hideCustomer();
            loadCustDataGrid();
        }

        private void customerInsert_Click(object sender, EventArgs e)
        {
            type = "customer";
            mode = "insert";

            custInsert();
            loadCustDataGrid();


        }

        private void customerUpdate_Click(object sender, EventArgs e)
        {
            type = "customer";
            mode = "update";

            custUpdate();
            loadCustDataGrid();
        }

        private void customerDelete_Click(object sender, EventArgs e)
        {
            type = "customer";
            mode = "delete";

            custDelete();
            loadCustDataGrid();
        }

        private void employeeSelectStrip_Click(object sender, EventArgs e)
        {
            type = "employee";
            mode = "insert";

            searchBox.Visible = true;
            button3.Visible = true;

            loadEmpDataGrid();
            hideEmployee();
            hideCustomer();
        }


        private void employeeInsertStrip_Click(object sender, EventArgs e)
        {
            type = "employee";
            mode = "insert";

            empInsert();
            loadEmpDataGrid();
        }

        private void employeeUpdateStrip_Click(object sender, EventArgs e)
        {
            type = "employee";
            mode = "update";

            empUpdate();
            loadEmpDataGrid();
        }

        private void employeeDeleteStip_Click(object sender, EventArgs e)
        {
            type = "employee";
            mode = "delete";

            empDelete();
            loadEmpDataGrid();
        }

      

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreen splash = new SplashScreen();
            splash.Show();
            this.Close();
        }

        public void loadCustDataGrid()
        {
            customerDataGridView.Visible = true;
            employeeDataGridView.Visible = false;
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_selectCustomerTbl", conn);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                customerDataGridView.DataSource = dt;

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


        private void searchCustDatabase()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_selectFrmCustomerTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@value", SqlDbType.NVarChar).Value = "%" + searchBox.Text.Trim() + "%";



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                customerDataGridView.DataSource = dt;

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


        private void insertCustDatabase()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_insertCustomerTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = nameTextbox.Text.Trim();

                if (addressTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = addressTextbox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (numTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@phoneNum", SqlDbType.NVarChar).Value = numTextbox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phoneNum", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (emailTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = emailTextbox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = DBNull.Value;
                }


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                customerDataGridView.DataSource = dt;

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

        private void updateCustDatabase()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_updateCustomerTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SqlDbType.BigInt).Value = idTextbox.Text.Trim();
                cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = nameTextbox.Text.Trim();

                if (addressTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = addressTextbox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (numTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@phoneNum", SqlDbType.NVarChar).Value = numTextbox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phoneNum", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (emailTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = emailTextbox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = DBNull.Value;
                }


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                customerDataGridView.DataSource = dt;

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


        private void deleteCustDatabase()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_deleteCustomerTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SqlDbType.NVarChar).Value = idTextbox.Text.Trim();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                customerDataGridView.DataSource = dt;

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


        public void loadEmpDataGrid()
        {
            employeeDataGridView.Visible = true;
            customerDataGridView.Visible = false;
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_selectEmployeeTbl", conn);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                employeeDataGridView.DataSource = dt;

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


        private void searchEmpDatabase()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_selectFrmEmployeeTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@value", SqlDbType.NVarChar).Value = "%" + searchBox.Text.Trim() + "%";



                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                employeeDataGridView.DataSource = dt;

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



               private void insertEmpDatabase()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_insertEmployeeTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = empNameTextbox.Text.Trim();

                if (empPositionTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@position", SqlDbType.NVarChar).Value = empPositionTextbox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@position", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (empSalaryTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@salary", SqlDbType.Float).Value = float.Parse(empSalaryTextbox.Text.Trim());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@salary", SqlDbType.Float).Value = DBNull.Value;
                }

                if (empEmailTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = empEmailTextbox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = DBNull.Value;
                }


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                employeeDataGridView.DataSource = dt;

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

        private void updateEmpDatabase()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_updateEmployeeTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SqlDbType.BigInt).Value = empIdTextbox.Text.Trim();
                cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = empNameTextbox.Text.Trim();

                if (empPositionTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@position", SqlDbType.NVarChar).Value = empPositionTextbox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@position", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (empSalaryTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@salary", SqlDbType.Float).Value = float.Parse(empSalaryTextbox.Text.Trim());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@salary", SqlDbType.Float).Value = DBNull.Value;
                }

                if (empEmailTextbox.Text.Trim().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = empEmailTextbox.Text.Trim();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = DBNull.Value;
                }


                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                employeeDataGridView.DataSource = dt;

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


        private void deleteEmpDatabase()
        {
            try
            {

                conn.Open();

                cmd = new SqlCommand("usp_deleteEmployeeTbl", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", SqlDbType.NVarChar).Value = empIdTextbox.Text.Trim();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                employeeDataGridView.DataSource = dt;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            hideErrorMsg();
            string email = emailTextbox.Text.Trim();

            if (email.Length != 0)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    if (type.Equals("customer"))
                    {
                        if (mode.Equals("insert"))
                        {
                            insertCustDatabase();
                        }
                        else if (mode.Equals("update"))
                        {
                            updateCustDatabase();
                        }
                        else if (mode.Equals("delete"))
                        {
                            deleteCustDatabase();
                        }
                    }
                }
                else
                {
                    emailError.Text = "Email Not Valid";
                    emailError.Visible = true;
                }
            } else
            {
                if (type.Equals("customer"))
                {
                    if (mode.Equals("insert"))
                    {
                        insertCustDatabase();
                    }
                    else if (mode.Equals("update"))
                    {
                        updateCustDatabase();
                    }
                    else if (mode.Equals("delete"))
                    {
                        deleteCustDatabase();
                    }
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            hideErrorMsg();
            string email = empEmailTextbox.Text.Trim();

            if (email.Length != 0)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    if (type.Equals("employee"))
                    {
                        if (mode.Equals("insert"))
                        {
                            insertEmpDatabase();
                        }
                        else if (mode.Equals("update"))
                        {
                            updateEmpDatabase();
                        }
                        else if (mode.Equals("delete"))
                        {
                            deleteEmpDatabase();
                        }
                    }
                }
                else
                {
                    empEmailError.Text = "Email Not Valid";
                    empEmailError.Visible = true;
                }
            } else
            {
                if (type.Equals("employee"))
                {
                    if (mode.Equals("insert"))
                    {
                        insertEmpDatabase();
                    }
                    else if (mode.Equals("update"))
                    {
                        updateEmpDatabase();
                    }
                    else if (mode.Equals("delete"))
                    {
                        deleteEmpDatabase();
                    }
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (type.Equals("employee"))
            {
                searchEmpDatabase();
            } else
            {
                searchCustDatabase();
            }
        }
    }
}
