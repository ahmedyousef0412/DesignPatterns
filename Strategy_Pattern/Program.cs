

using Strategy_Pattern.Core;
using Strategy_Pattern.Core.DiscountStrategies.Interfaces;
using Strategy_Pattern.Core.DiscountStrategies.Models;
using Strategy_Pattern.Core.Enums;
using Strategy_Pattern.Helper;

var customerDataReader = new CustomerDataReader();

var customers = customerDataReader.GetCustomers();

while (true)
{
    Console.WriteLine("Customer List :");
    foreach (var customer in customers)
        Console.WriteLine($"\t{customer.Id}. {customer.Name} ({customer.Category})");

    Console.WriteLine();
    Console.Write("Enter Customer Id : ");
    var customerId = int.Parse( Console.ReadLine());

    Console.Write("Enter the Quentity : ");
    var quentity =double.Parse( Console.ReadLine());

    Console.Write("Enter the Unit Price : ");
    var unitPrice = double.Parse(Console.ReadLine());

    var slectedCustomer = customers.FirstOrDefault(c => c.Id == customerId);

    if(slectedCustomer is null )
        Console.WriteLine($"No Customer with this Id : {customerId} found !");

    else
    {

		#region Before Use  Simple Factory Pattern
		//ICustomerDiscountStrategy customerDiscountStrategy = null;

		//      if (customer.Category == CustomerCategory.Gold)
		//          customerDiscountStrategy = new GoldCustomerDiscountStrategy();

		//      else if (customer.Category == CustomerCategory.Silver)
		//          customerDiscountStrategy = new SilverCustomerDiscountStrategy();

		#endregion


		
		var invoiceManger = new InvoiceManager();

		#region After Use  Simple Factory Pattern

		ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategy(slectedCustomer.Category);
		
        #endregion

		invoiceManger.SetDiscountStrategy(customerDiscountStrategy);

        var invoice = invoiceManger.CreateInvoice(slectedCustomer, quentity, unitPrice);



        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($"Invoice Created for Customer :{slectedCustomer.Name} , with Total Price :{invoice.NetPrice}");

        Console.ForegroundColor = ConsoleColor.White;



        Console.WriteLine("Enter any key to create another invoice ");

        Console.ReadKey();
        Console.WriteLine("------------------------------------");
    }

    

}