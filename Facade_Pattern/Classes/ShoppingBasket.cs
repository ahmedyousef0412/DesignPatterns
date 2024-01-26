using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Classes
{
	internal class ShoppingBasket
	{
		private List<BasketItem> _items = new List<BasketItem>();
		public void AddItem(BasketItem item)
		{
			_items.Add(item);
		}

		public void RemoveOneItem(string itemID)
		{
			var item = _items.Where(x => x.ItemID == itemID).SingleOrDefault();

			if (item!.Quantity > 0)
				item.Quantity--;
		}

		public List<BasketItem> GetItems()
		{ 
			return _items;
		}

	}
}
