using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    internal class Menu
    {
        public string name { get; set; }
        public double cost { get; set; }

        public Menu(string name, double cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
