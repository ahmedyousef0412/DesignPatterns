using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Core
{
    internal class Invoice
    {

        public Customer Customer { get; set; }
        public IEnumerable<InvoiceLine> InvoiceLines { get; set; }

        public double DiscountPercentage { get; set; }
        public double TotalPrice => InvoiceLines.Sum(t => t.Quentity * t.UnitPrice);
        public double NetPrice => TotalPrice - (TotalPrice * DiscountPercentage);
    }
}
