using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Invoice
    {
        public Customer Customer { get; set; }
        public IEnumerable<InvoiceLine> Lines { get; set; }
        public double TotalPrice => Lines.Sum(l=>l.UnitPrice*l.Quantity); 
        public double DiscountPercentage { get; set; }
        public double NetPrice => TotalPrice - (TotalPrice * DiscountPercentage);
    }
}
