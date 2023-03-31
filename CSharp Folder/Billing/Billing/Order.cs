using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    internal class Order
    {
        public double total { get; set; }
        public double gst { get; set; }
        public List<Item> orders { get; set; }

    }
}
