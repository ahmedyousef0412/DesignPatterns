using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Core
{
    public class Employee
    {
     
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;


        public string FullName =>$" {FirstName} {MiddleName} {LastName}";
        public IEnumerable<PayItem>? PayItems { get; set; }
    }
}
