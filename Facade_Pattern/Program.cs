

#region Before Facade

//using Facade_Pattern.Classes;

//ShoppingBasket basket = new(); //Create Basket

////Create Item
//BasketItem item = new ()
//{
//	ItemID = "123456",
//	ItemPrice = 5000,
//	Quantity = 10
//};

////Check if Sotck Avalibality

//Inventory inventory = new();
//if((inventory.CheckItemQuantity(item.ItemID,item.Quantity)))
//	basket.AddItem(item);

////Create Inventory Order

//InventoryOrder order = new ();
//order.CreateOrder(basket,"123789");

////Create Invoice

//PurchaseInvoice invoice = new();
//var invo = invoice.CreateInvoce(basket, "address:123 ,id =456 , email =ahmed@gmail.com");


////Payment
//PaymentProcessor payment = new();
//payment.HandlePayment(invo.netTotal, "acc-123456789");

//// Send SMS
//SmsNotifications sms = new SmsNotifications();
//sms.SendSms("123", "Invoice Created");

#endregion


#region Use Facade

using Facade_Pattern.Classes;

ShoppingBasket basket = new(); 


BasketItem _ = new()
{
	ItemID = "123456",
	ItemPrice = 5000,
	Quantity = 10
};


Customer customer = new()
{
	Id = new Guid(),
	Address = "Cairo",
	Email = "ahmed@gmail.com"

};


PurchaseOrder purchaseOrder = new();

purchaseOrder.CreateOrder(basket, customer);




#endregion