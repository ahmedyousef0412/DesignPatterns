using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Core.Classe
{
    internal class Order
    {
        private List<OrderLines> _lines = [];

        public IEnumerable<OrderLines> Lines => _lines.AsReadOnly();


        public void AddLine(int itemId, double quality, decimal unitPrice)
        {
            _lines.Add(new OrderLines { ItemId = itemId, Quality = quality, UnitPrice = unitPrice });
        }
    }
}
