using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Classes
{
	internal class InventoryOrder
	{
		public string CreateOrder(ShoppingBasket basket, string storeID)
		{
			basket.GetItems();
			return $"Order Number is {Guid.NewGuid().ToString()}";
		}
	}
}
