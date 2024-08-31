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

        // creates custom constructor. 
        public Car (string model, string brand)
        {
            _model = model;
            _brand = brand;
            Console.WriteLine("You just created a new object of class Car with model "+ _model + " and brand " + _brand);
        }
}
}
