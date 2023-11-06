using StrategyPattern.DiscountStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class InvoiceManager
    {
        private ICustomerDiscountStrategy _customerDiscountStrategy;
        public void SetStrategy(ICustomerDiscountStrategy strategy)
        {
            _customerDiscountStrategy = strategy;
        }
        public Invoice CreateInvoice(Customer customer, int quantity, double unitePrice)
        {

            var invoice = new Invoice()
            {
                Customer = customer,
                Lines = new[]
            {
            new InvoiceLine { Quantity = quantity, UnitPrice = unitePrice, }
        },


            };
            invoice.DiscountPercentage=_customerDiscountStrategy.CalculateDiscount(invoice.TotalPrice);
            return invoice;
        }
    }
}
