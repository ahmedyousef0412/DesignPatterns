using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator_Pattern.Core.Classe;
using Decorator_Pattern.Core.Interfaces;

namespace Decorator_Pattern.Core.Decorator
{
    internal class OrderProcessorProfilingDecorator : IOrderProcessor
	{
		private readonly IOrderProcessor _orderProcessor;

		public OrderProcessorProfilingDecorator(IOrderProcessor orderProcessor)
        {
			_orderProcessor = orderProcessor;
		}
        public void Process(Order order)
		{
			var stopWatch = new Stopwatch();
			stopWatch.Start();	

			_orderProcessor.Process(order);
			stopWatch.Stop();

            Console.WriteLine($"Order took {stopWatch.Elapsed.TotalSeconds} to be processed");
        }
	}
}
