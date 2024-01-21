using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator_Pattern.Core.Classe;
using Decorator_Pattern.Core.Interfaces;

namespace Decorator_Pattern.Core.Decorator
{
    internal class OrderProcessorQueuingDecorator : IOrderProcessor
	{

		private readonly IOrderProcessor _orderProcessor;

		private Queue<Order> _orders = new ();
		public OrderProcessorQueuingDecorator(IOrderProcessor orderProcessor)
		{
			_orderProcessor = orderProcessor;
		}
		public void Process(Order order)
		{
			
			_orders.Enqueue(order);
            Console.WriteLine("Order has been queued");
        }
	}
}
