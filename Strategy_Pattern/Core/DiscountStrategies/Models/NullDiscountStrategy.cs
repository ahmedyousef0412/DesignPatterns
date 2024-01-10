using Strategy_Pattern.Core.DiscountStrategies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Core.DiscountStrategies.Models
{
	internal class NullDiscountStrategy : ICustomerDiscountStrategy
	{
		public double CalculateDiscount(double totalPrice)
		{
			return 0;
		}
	}
}
