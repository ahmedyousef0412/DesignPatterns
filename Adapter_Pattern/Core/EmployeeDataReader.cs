using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Core
{
    internal class EmployeeDataReader
    {

        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new()
                {

                  FirstName = "Ahmed",
                  MiddleName = "Yousef",
                  LastName = "Ahmed",
                  PayItems = new List<PayItem>()
                  {

                      new () { Name  ="Basic Salary" , Value = 10000},
                      new () { Name  ="Transportation" , Value = 2000},
                      new () { Name  ="Medical Insurance" , Value = 1000 , IsDeduction = true},
                  }

                },
                new()
                {
                    FirstName = "Omer",
                    MiddleName = "Yousef",
                    LastName = "Ahmed",
                   PayItems = new List<PayItem>()
                   {

                      new () { Name  ="Basic Salary" , Value = 10000},
                      new () { Name  ="Transportation" , Value = 2000},
                      new () { Name  ="Medical Insurance" , Value = 1000,IsDeduction = true},
                   }
                }
            };
        }
    }
}
