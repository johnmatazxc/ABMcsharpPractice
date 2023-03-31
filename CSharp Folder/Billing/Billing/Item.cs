using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    internal class Item
    {
        public string name { get; set; }
        public double cost { get; set; }
        public int quantity { get; set; }

        public Item(string name, double cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
