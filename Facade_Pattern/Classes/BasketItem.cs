using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Classes
{
	internal class BasketItem
	{
		public string ItemID { get; set; } = null!;
		public double ItemPrice { get; set; }
		public double Quantity { get; set; }
	}
}
