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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComboBox
{
    public partial class form : Form
    {
        static string serverName = "SWINDZ" + '\\' + "SQLEXPRESS";
        static string database = "DemoDb";
        static string user = "sa";
        static string password = "john29";
        static string connectionString = @"Data Source=" + serverName + ";Initial Catalog=" + database + ";User ID =" + user +
            ";Password =" + password;

        static SqlConnection conn = new SqlConnection(connectionString);

        public form()
        {
            InitializeComponent();
        }


        private void form_Load(object sender, EventArgs e)
        {
            countryLBl.Text = "Country: ";
            provinceLbl.Text = "Province: ";
            cityLbl.Text = "City: ";

;           initializeDropDown();
        }

        public void initializeDropDown()
        {
 
            using (conn)
                try
                {
                    string query = "select id,description,isActive from Country";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Country");
                    areaBox.DisplayMember = "Description";
                    areaBox.ValueMember = "id";
                    areaBox.DataSource = ds.Tables["Country"];
                } catch (Exception ex)
                {

                }
                finally { 
                    conn.Close();
                }   
           
           
      
 
        }

        private void areaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (conn)
            {
                try
                {
                    string query = "select id,description,isActive from Province";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Province");
                    provinceBox.DisplayMember = "description";
                    provinceBox.ValueMember = "id";
                    provinceBox.DataSource = ds.Tables["Province"];
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void provinceBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (conn)
                try
                {
                    string query = "select id,description,isActive from City";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "City");
                    cityBox.DisplayMember = "description";
                    cityBox.ValueMember = "id";
                    cityBox.DataSource = ds.Tables["City"];
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverName = "SWINDZ" + '\\' + "SQLEXPRESS";
            string database = "DemoDb";
            string user = "sa";
            string password = "john29";
            string connectionString;
            
            connectionString = @"Data Source=" + serverName + ";Initial Catalog=" + database + ";User ID =" + user +
                ";Password =" + password;

            SqlConnection on = new SqlConnection(connectionString);
            on.Open();
            MessageBox.Show("Connected Successfully");
            on.Close(); 
        }
    }
}
