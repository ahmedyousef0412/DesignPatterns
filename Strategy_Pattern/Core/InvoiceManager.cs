using Strategy_Pattern.Core.DiscountStrategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Core
{
    internal class InvoiceManager
    {

        private ICustomerDiscountStrategy _customerDiscountStrategy;

        public void SetDiscountStrategy(ICustomerDiscountStrategy customerDiscountStrategy)
        {
            _customerDiscountStrategy = customerDiscountStrategy;
        }

        public Invoice CreateInvoice(Customer customer, double quentity, double unitPrice)
        {

            var invoice = new Invoice()
            {
                Customer = customer!,
                InvoiceLines = new[]
                {
                  new InvoiceLine() {Quentity = quentity, UnitPrice = unitPrice}
                },
               

            };
            invoice.DiscountPercentage = _customerDiscountStrategy.CalculateDiscount(invoice.TotalPrice);

            return invoice;
        }
    }
}
