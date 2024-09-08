using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_concepts
{
    internal partial class Customer
    {
        public string CarBrand { get; set; }

        // implements partial method declared in another subclass.
        partial void TestPartialMethod() 
        {
            Console.WriteLine("You called your partial method.");
        }

    }
}
