using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator_Pattern.Core.Interfaces;

namespace Decorator_Pattern.Core.Classe
{
    internal class OrderProcessor : IOrderProcessor
    {
        public void Process(Order order)
        {
            if (!order.Lines.Any())
                throw new Exception("Order is empty");


            Thread.Sleep(Random.Shared.Next(1000, 3000));

            Console.WriteLine("Order has been processed");
        }
    }
}
