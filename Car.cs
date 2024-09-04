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
        private bool _isLuxury;

        // creates Property to encapsulate private member variables.
        public string Brand {
            
            // uses getter to get the value in desired format. 
            get
            {
                if (_isLuxury)
                {
                    return _brand + "--Luxury Edition";
                } else 
                    return _brand;
            } 

            // uses setter to set the value in desired format.
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Brand cannot be empty!");
                    _brand = "DEFAULT VALUE";
                }
                else
                {
                    _brand = value;
                }
            } 
        }
        public string Model { get => _model; set => _model = value; }
        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // creates custom constructor. 
        public Car (string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine("You just created a new object of class Car with model "+ Model + " and brand " + Brand);
        }

        
    }
}
