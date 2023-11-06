using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers() {
            return new[] { 
            new Customer
            {
                Id=1,
                Name="Sulaiman Ibraheem Ismaeel",
                Category=CustomerCategory.Gold,
                
            },
            new Customer
            {
                Id = 2,
                Name="Ibraheem Sulaiman Ismaeel",
                Category=CustomerCategory.Silver,

            }

            };
        }
    }
}
