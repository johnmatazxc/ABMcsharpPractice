using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillMenuContainer();
        }

        private void fillMenuContainer()
        {
            Menu menu1 = new Menu("Chicken Burger", 12.99);
            Menu menu2 = new Menu("Beef Burger", 14.99);
            Menu menu3 = new Menu("Chicken Shawarma", 8.99);
            Menu menu4 = new Menu("Beef Shawarma", 9.99);
            Menu menu5 = new Menu("Poutine", 6.99);

            Dictionary<int, Menu> menuDict = new Dictionary<int, Menu>
            {
                { 1, menu1 },
                { 2, menu2 },
                { 3, menu3 },
                { 4, menu4 },
                { 5, menu5 },
            };

            foreach (KeyValuePair<int, Menu> entry in menuDict)
            {
                createLabel(entry.Value.name);
            }


        }

        private void createLabel(string name)
        {
            Label mylab = new Label();
            mylab.Text = name;
            mylab.Location = new Point(85, 80);
            mylab.AutoSize = true;
            mylab.Font = new Font("Calibri", 18);
            mylab.Padding = new Padding(6);

            // Adding this control to the form
            this.Controls.Add(mylab);
        }
    }
}
