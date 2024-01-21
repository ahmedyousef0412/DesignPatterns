

using Decorator_Pattern.Core;
using Decorator_Pattern.Core.Classe;
using Decorator_Pattern.Core.Decorator;
using Decorator_Pattern.Core.Interfaces;

#region Example 1
//var order = new Order();

//order.AddLine(1, 5, 5000);
//order.AddLine(2, 10, 10000);
//order.AddLine(3, 15, 15000);

//IOrderProcessor orderProcessor = new OrderProcessor();
//orderProcessor = new OrderProcessorExceptionHandlerDecorator(orderProcessor);
//orderProcessor = new OrderProcessorProfilingDecorator(orderProcessor);
////orderProcessor = new OrderProcessorQueuingDecorator(orderProcessor);

//orderProcessor.Process(order);
//Console.ReadKey();
#endregion


#region Example 2


IShape circle = new Circle();

IShape redCircle = new ShapeDecorator(new Circle());

IShape redRectangle = new ShapeDecorator(new Rectangle());


Console.WriteLine("Circle with normal border");
circle.Draw();

Console.WriteLine("\nCircle of red border");
redCircle.Draw();

Console.WriteLine("\nRectangle of red border");
redRectangle.Draw();
#endregion
