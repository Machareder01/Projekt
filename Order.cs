using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coffeeshop
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public string Quantity { get; set; }
        public int TotalPrice { get; set; }
        public int InvoiceID { get; set; }
    }
}
