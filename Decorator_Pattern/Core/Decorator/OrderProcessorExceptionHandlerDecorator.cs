using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator_Pattern.Core.Classe;
using Decorator_Pattern.Core.Interfaces;

namespace Decorator_Pattern.Core.Decorator
{
    internal class OrderProcessorExceptionHandlerDecorator : IOrderProcessor
	{
		private readonly IOrderProcessor _orderProcessor;

		public OrderProcessorExceptionHandlerDecorator(IOrderProcessor orderProcessor)
		{
			_orderProcessor = orderProcessor;
		}
		public void Process(Order order)
		{
			try
			{
				_orderProcessor.Process(order);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
