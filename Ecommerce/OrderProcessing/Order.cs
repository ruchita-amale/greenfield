using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public String Status { get; set; }
        public DateTime Date { get; set; }
    }
}