using Strategy_Pattern.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Core
{
    internal class CustomerDataReader
    {

        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer(){Id = 1, Name = "Ahmed Yousef",Category= CustomerCategory.New},
                new Customer(){Id = 2 , Name = "Omer Yousef",Category= CustomerCategory.Silver},
                new Customer(){Id = 3 , Name = "Yousef Ahmed",Category= CustomerCategory.Gold},
            };
        }
    }
}
