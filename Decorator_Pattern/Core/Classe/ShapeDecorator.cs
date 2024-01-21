using Decorator_Pattern.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Core.Classe
{
	internal class ShapeDecorator : IShapeDecorator
	{
		private readonly IShape _shap;

		public ShapeDecorator(IShape shap)
        {
		        _shap = shap;
		}
        public void Draw()
		{
			_shap.Draw();
			setRedBorder(_shap);
		}

		private void setRedBorder(IShape shape)
		{
			Console.WriteLine("Border Color: Red");
		}
	}
}
