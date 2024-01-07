using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Core
{
    public class PayItem
    {
        public string Name { get; set; } = null!;
        public decimal Value { get; set; }

        public bool IsDeduction {  get; set; }
    }
}
