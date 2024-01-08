

using Strategy_Pattern.Core;
using Strategy_Pattern.Core.DiscountStrategies.Interfaces;
using Strategy_Pattern.Core.DiscountStrategies.Models;
using Strategy_Pattern.Core.Enums;

var customerDataReader = new CustomerDataReader();

var customers = customerDataReader.GetCustomers();

while (true)
{
    Console.WriteLine($"Customr List :[1] Ahmed Yousef , [2] Omer Yousef");

    Console.Write("Enter Customer Id : ");
    var customerId = int.Parse( Console.ReadLine());

    Console.Write("Enter the Quentity : ");
    var quentity =double.Parse( Console.ReadLine());

    Console.Write("Enter the Unit Price : ");
    var unitPrice = double.Parse(Console.ReadLine());

    var customer = customers.FirstOrDefault(c => c.Id == customerId);

    if( customer is null )
        Console.WriteLine($"No Customer with this Id : {customerId} found !");

    else
    {
        ICustomerDiscountStrategy customerDiscountStrategy = null;

        if (customer.Category == CustomerCategory.Gold)
            customerDiscountStrategy = new GoldCustomerDiscountStrategy();

        else if (customer.Category == CustomerCategory.Silver)
            customerDiscountStrategy = new SilverCustomerDiscountStrategy();

        var invoiceManger = new InvoiceManager();

        invoiceManger.SetDiscountStrategy(customerDiscountStrategy);

        var invoice = invoiceManger.CreateInvoice(customer, quentity, unitPrice);



        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($"Invoice Created for Customer :{customer.Name} , with Total Price :{invoice.NetPrice}");

        Console.ForegroundColor = ConsoleColor.White;



        Console.WriteLine("Enter any key to create another invoice ");

        Console.ReadKey();
        Console.WriteLine("------------------------------------");
    }

    

}