using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Billing
{
    public partial class Form1 : Form
    {
        Menu menu = new Menu();
        Order order = new Order();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Visible= false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

            button1.Text = "Order";
            fillMenuContainer();
        }

        private void fillMenuContainer()
        {
            Item menu1 = new Item("Chicken Burger", 12.99);
            Item menu2 = new Item("Beef Burger", 14.99);
            Item menu3 = new Item("Chicken Shawarma", 8.99);
            Item menu4 = new Item("Beef Shawarma", 9.99);
            Item menu5 = new Item("Poutine", 6.99);

            Dictionary<int, Item> menuDict = new Dictionary<int, Item>
            {
                { 1, menu1 },
                { 2, menu2 },
                { 3, menu3 },
                { 4, menu4 },
                { 5, menu5 },
            };

            menu.items = menuDict;

            int i = 1;

            List<Label> labels = new List<Label>();
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);    
            labels.Add(label4);
            labels.Add(label5);

        
            foreach (Label label in labels)
            {
                Console.WriteLine(i);
                label.Text = menuDict[i].name + "         " + menuDict[i].cost;
                i++;
            }


        }

        private void createLabel(KeyValuePair<int, Item> entry)
        {
            // Label menuItem = new Label();
            // menuItem.Text = entry.Value.name;
            // menuItem.Left = 80;
            // menuItem.Top = (entry.Key + 1) * 50;

            // Label menuCost = new Label();
            // menuCost.Name = "cost" + entry.Key.ToString(); 
            // menuCost.Text = entry.Value.cost.ToString();
            // menuCost.Left = 240;
            // menuCost.Top = (entry.Key + 1) * 50;

            
           // NumericUpDown numericUpDown = new NumericUpDown();
           // numericUpDown.Name = "numeric" + i.ToString();
           // numericUpDown.Left = 360;
           // numericUpDown.Top = (i + 1) * 50;
           // numericUpDown.ValueChanged += new EventHandler(numericChanged);

            // CheckBox checkBox = new CheckBox();
            // checkBox.Name = "checkBox" + entry.Key.ToString();
            // checkBox.Left = 360;
            // checkBox.Top = (entry.Key + 1) * 50;
            // CheckBoxes.Add(checkBox);



            // this.Controls.Add(menuItem);
            // this.Controls.Add(menuCost);
            // this.Controls.Add(checkBox);
        }

        private void numericChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Item> items = new List<Item>();

            label6.Visible = true;
            label6.Text = "ORDER SUMMARY";

            label7.Visible = true;
            label7.Text = "GST/PST ( 5% )";

            label8.Visible = true;
            label8.Text = "TOTAL";


            double item1 = Decimal.ToDouble(numericUpDown1.Value) * menu.items[1].cost;
            int intVal1 = Decimal.ToInt32(numericUpDown1.Value);
            if (intVal1 > 0)
            {
                menu.items[1].quantity = intVal1;
                items.Add(menu.items[1]);
            }
            
            double item2 = Decimal.ToDouble(numericUpDown2.Value) * menu.items[2].cost;
            int intVal2 = Decimal.ToInt32(numericUpDown2.Value);
            if (intVal2 > 0)
            {
                menu.items[2].quantity = intVal2;
                items.Add(menu.items[2]);
            }
            
            double item3 = Decimal.ToDouble(numericUpDown3.Value) * menu.items[3].cost;
            int intVal3 = Decimal.ToInt32(numericUpDown3.Value);
            if (intVal3 > 0)
            {
                menu.items[3].quantity = intVal3;
                items.Add(menu.items[3]);
            }
            
            double item4 = Decimal.ToDouble(numericUpDown4.Value) * menu.items[4].cost;
            int intVal4 = Decimal.ToInt32(numericUpDown4.Value);
            if (intVal4 > 0)
            {
                menu.items[4].quantity = intVal4;
                items.Add(menu.items[4]);
            }
            
            double item5 = Decimal.ToDouble(numericUpDown5.Value) * menu.items[5].cost;
            int intVal5 = Decimal.ToInt32(numericUpDown5.Value);
            if (intVal5 > 0)
            {
                menu.items[5].quantity = intVal5;
                items.Add(menu.items[5]);
            }
  

            double total = item1 + item2 + item3 + item4 + item5;
            double gst = 0.05 * total;

            total = total + gst;
            order.total = total;
            order.orders = items;
            order.gst = gst;

            label9.Visible = true;
            label9.Text = gst.ToString();

            label10.Visible = true;
            label10.Text = total.ToString();


            int i = 1;
            foreach(Item item in order.orders)
            {
                Label menuItem = new Label();
                menuItem.Text = item.name + "--------" + "$" + item.cost + "--------" + item.quantity + "pcs";
                menuItem.AutoSize = true;
                menuItem.Left = 80;
                menuItem.Top = (i + 1) * 50;

                panel1.Controls.Add(menuItem);

                i++;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
