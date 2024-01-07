using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
	internal class CurrencyConverter
	{

		private IEnumerable<ExchangeRate> _exchangeRates;

		private static readonly object _lock = new();

		private  static  CurrencyConverter _instance;


		public static CurrencyConverter Instance
		{
			get
			{
				if( _instance is null) //double check
				{
					lock (_lock)
					{
						_instance ??= new();
					}

				}
				return _instance;
			}
		}
		private CurrencyConverter() => LoadExchangeRates(); //private Constructor



		private void LoadExchangeRates()
		{
			Thread.Sleep(3000);

			_exchangeRates = new[]
			{
				new ExchangeRate ("USD","SAR",10.2m),
				new ExchangeRate ("USD","EGP",50.25m),
				new ExchangeRate ("SAR","EGP",13.8m)
			};
		}


		public decimal Convert(string baseCurrency, string targetCurrency, decimal amount)
		{
			var exchangeRate = _exchangeRates
				   .FirstOrDefault(rate => rate?.BaseCurrency.ToLower() == baseCurrency
				   && rate?.TargetCurrency.ToLower() == targetCurrency);


			if (exchangeRate != null)
			{

				if (amount > 0)
				{
					return amount * exchangeRate.Rate;
				}
				else
				{
					throw new ArgumentException("Amount must be greater than zero");
				}
			}
			else
			{
				throw new ArgumentException("Exchange rate not found for the specified currencies");
			}


		}
	}
}
