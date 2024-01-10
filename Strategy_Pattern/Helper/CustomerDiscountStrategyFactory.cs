using Strategy_Pattern.Core;
using Strategy_Pattern.Core.DiscountStrategies.Interfaces;
using Strategy_Pattern.Core.DiscountStrategies.Models;
using Strategy_Pattern.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Helper
{
	internal class CustomerDiscountStrategyFactory
	{

		public ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory category)
		{
			

			if (category == CustomerCategory.Gold)
				return new GoldCustomerDiscountStrategy();

			else if (category == CustomerCategory.Silver)
				return new SilverCustomerDiscountStrategy();

			#region  Null Object Pattern

			return new NullDiscountStrategy();

			#endregion
		}
	}
}
