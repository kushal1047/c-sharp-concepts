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
        private string _brand; // private hides the variables from other classes; creates a backing field for the property Brand.
        // private string _model; 
        // private bool _isLuxury;

        // creates Property to encapsulate private member variables.
        public string Brand {
            
            // uses getter to get the value in desired format. 
            get
            {
                if (IsLuxury)
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
        public string Model { get; set; }
        public bool IsLuxury { get; set; }

        // creates a public static variable.
        public static int NumberOfCars { get; set; }

        // creates computed property BrandModel that is read-only and only has getter.
        public string BrandModel { get {
                return Model + " " + Brand;
            } }

        // creates custom constructor. 
        public Car (string model, string brand, bool isLuxury)
        {
            NumberOfCars++;
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine("You just created a new object of class Car with model "+ Model + " and brand " + Brand);
        }
        public Car()
        {
            NumberOfCars++;
        }
        // creates a method
        public void Drive() => Console.WriteLine($"I'm {Model} and I'm driving."); // uses expression bodied member (=> , no {} ) for less code, more clarity.


        
    }
}
