using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Classes
{
	internal class PurchaseOrder
	{
		public bool CreateOrder(ShoppingBasket basket , Customer customerInfo)
		{
			var isAvalibality = true;

			Inventory inventory = new();

			foreach (var item in basket.GetItems())
			{
				if (!inventory.CheckItemQuantity(item.ItemID, item.Quantity))
					isAvalibality = false;
			}
			if (isAvalibality)
			{

				//Create Inventory Order
				InventoryOrder inventoryOrder = new();
				inventoryOrder.CreateOrder(basket , "123456");

				//Create Invoice
				PurchaseInvoice purchaseInvoice = new();
				var inv = purchaseInvoice.CreateInvoce(basket , customerInfo);


				//Payment
				PaymentProcessor paymentProcessor = new ();
				paymentProcessor.HandlePayment(inv.netTotal, "acc:123456789");

				// Send SMS
				SmsNotifications notifications = new();
				notifications.SendSms("123", "Invoice Created"); 

			}

			return false;


		}
	}
}
