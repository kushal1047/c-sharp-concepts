using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace c_sharp_concepts
{
    internal class Car
{       
        // creates member variables.
        private string _model; // private hides the variables from other classes.
        private string _brand;

        // creates Property to encapsulate private member variables.
        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }

        // creates custom constructor. 
        public Car (string model, string brand)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine("You just created a new object of class Car with model "+ Model + " and brand " + Brand);
        }

        
    }
}
