using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_concepts
{
    internal partial class Customer // declares partial class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        // creates an inner class Location 
        public class Location
        {
            private Customer CustomerOuter;

            public Location(Customer customerOuter)
            {
                CustomerOuter = customerOuter;
            }
            public void DisplayCustomerAddress()
            {
                Console.WriteLine(CustomerOuter.Address);
            }
            
        }

        // creates custom constructor
        public Customer(string name, string address = "NA", string contact = "NA") // uses optional parameter or default parameters.
        {
            Name = name;
            Address = address;
            Contact = contact;
            TestPartialMethod(); // calls partial method.
        }

        // creates default constructor
        public Customer()
        {
            Name = "Customer Name";
            Address = "unknown";
            Contact = "unknown";
        }

        // creates a method.
        public void CreateDetails(string name, string address, string contact) {
            Name= name;
            Address= address;
            Contact = contact;
        }
        partial void TestPartialMethod(); // declares partial method with optional implementation. 

        // creates an overloading operator +
        public static Customer operator +( Customer male, Customer female) 
        {
            return new Customer(male.Name + " weds " + female.Name);
        }
    }
}
