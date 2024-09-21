using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_concepts
{
    internal partial class Customer // declares partial class Customer
    {
        private readonly int _id; // creates a private readonly id variable to assign unique secured id to each customer.
        private static int nextId = 0; // creates a variable to increment value and get assigned to id.
        private string _password; // creates a password member to store customer password.
        public const string Country = "Australia"; // creates a constant which has the same value for all customers. 

    
        public int Id { get { return _id; } }

        // creates a Password property and make it write-only.
        public string Password { set { 
             _password = value;
            } }
        public string Name { get; set; } 
        public string Address { get; set; }
        public string Contact { get; set; }

        // creates an inner class Location.
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
            _id = nextId++;
            Name = name;
            Address = address;
            Contact = contact;
            TestPartialMethod(); // calls partial method.
        }

        // creates default constructor
        public Customer()
        {
            _id = nextId++;
            Name = "New Customer";
            Address = "unknown";
            Contact = "unknown";
        }

        // creates a method.
        public void CreateDetails(string name, string address, string contact) {
            Name= name;
            Address= address;
            Contact = contact;
        }

        // creates a method to view name and id of a customer.
        public void ViewDetails()
        {
            Console.WriteLine($"Details of customer -> Name: {Name}, id: {_id}, Country: {Country}");
        }
        partial void TestPartialMethod(); // declares partial method with optional implementation. 

        // creates an overloading operator +
        public static Customer operator +( Customer male, Customer female) 
        {
            return new Customer(male.Name + " weds " + female.Name);
        }
    }
}
