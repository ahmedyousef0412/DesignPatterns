using Decorator_Pattern.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Core.Classe
{
	internal class Circle : IShape
	{
		public void Draw()
		{
            Console.WriteLine("Circel Drawing....");
        }
	}
}
