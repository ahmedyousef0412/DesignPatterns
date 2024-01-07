using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
	internal class ExchangeRate(string baseCurrency, string targetCurrency, decimal rate)
	{
		public string BaseCurrency { get; } = baseCurrency;
		public string TargetCurrency { get; } = targetCurrency;
		public decimal Rate { get; } = rate;
	}
}
