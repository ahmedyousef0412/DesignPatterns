

using Singleton_Pattern;
using System;

while (true)
{
	Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("Base Currency and  Target Currency Lower or Upper");

	Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();

    Console.Write("Enter the Base Currency : ");
    var baseCurrency = Console.ReadLine();

	Console.Write("Enter the Target Currency : ");
	var targetCurrency = Console.ReadLine();

	Console.Write("Enter the Amount : ");
	var amount = decimal.Parse(Console.ReadLine());

	#region Before Singleton

	//var converter = new CurrencyConverter(); //before
	//var exchangedRate = converter.Convert(baseCurrency, targetCurrency, amount);

	#endregion


	if(string.IsNullOrEmpty(baseCurrency) || string.IsNullOrEmpty(targetCurrency))
	{
		Console.ForegroundColor = ConsoleColor.Yellow;

		Console.WriteLine("Invalid Base Currency or Target Currency ");
		Console.ForegroundColor = ConsoleColor.White;

		return;
	}
      

    var exchangedRate = CurrencyConverter.Instance.Convert(baseCurrency,targetCurrency, amount);

    Console.WriteLine($"{amount} {baseCurrency} = {exchangedRate} {targetCurrency}");


    Console.WriteLine("-------------------------------");


}