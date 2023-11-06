using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DiscountStrategy
{
    internal class GoldCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice >= 10000 ? 0.05 : 0;
        }
    }
}
