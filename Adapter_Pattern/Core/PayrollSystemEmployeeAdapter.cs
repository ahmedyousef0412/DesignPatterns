using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Core
{
    public class PayrollSystemEmployeeAdapter(Employee employee)
    {
        private readonly Employee _employee = employee;
        private readonly IEnumerable<PayrollSystemPayItemAdapter> _payItems = employee.PayItems.Select(payItem => new PayrollSystemPayItemAdapter(payItem)).ToList();

        public string FullName  => _employee.FullName;

        public IEnumerable<PayrollSystemPayItemAdapter> PayItems => _payItems;
    }
}
