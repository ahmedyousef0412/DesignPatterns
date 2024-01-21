using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator_Pattern.Core.Classe;

namespace Decorator_Pattern.Core.Interfaces
{
    internal interface IOrderProcessor
    {

        void Process(Order order);
    }
}
