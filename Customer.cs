using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_concepts
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        // creates custom constructor
        public Customer(string name, string address, string contact)
        {
            Name = name;
            Address = address;
            Contact = contact;
        }

        public Customer(string name)
        {
            Name = name;
        }

        // creates default constructor
        public Customer()
        {
            Name = "Customer Name";
            Address = "unknown";
            Contact = "unknown";
        }
    }
}
