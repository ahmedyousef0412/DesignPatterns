using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Classes
{
	internal class Customer
	{
        public Guid Id { get; set; }
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
