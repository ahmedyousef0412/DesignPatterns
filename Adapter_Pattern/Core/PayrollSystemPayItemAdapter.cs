using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Core
{
    public class PayrollSystemPayItemAdapter(PayItem payItem)
    {
        private readonly PayItem _payItem = payItem;

        public string Name => _payItem.Name;
        public decimal Value => _payItem.IsDeduction ? _payItem.Value * -1 : _payItem.Value;


    }
}
