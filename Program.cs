﻿using System;
using System.Runtime.InteropServices;
namespace c_sharp_concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // this is another comment line.
            // this line of code will print hello Kushal to the console.
            Console.WriteLine("Hello, Kushal");

            // declaring a variable 
            string myFriendsName;

            // assigning a value to a variable
            myFriendsName = "Samyog";

            //declaring a variable and assigning a value to it
            string myFriendsName2 = "Bhuwan";

            // using or accessing the variable
            Console.WriteLine(myFriendsName);

            // overwriting the value of a variable
            myFriendsName = "Jeewan";
            Console.WriteLine(myFriendsName);

            // implicit conversion
            int myNumber3 = 0;
            double myNumber4 = myNumber3;

            //explicit conversion which involves casting from one type to another
            long mylong = 216548698;
            myNumber3 = (int)mylong;
            Console.WriteLine(myNumber3);

            // using parse
            string numberString = "12";
            var num3 = 9.0;
            var num4 = 8.0;
            var convo = Convert.ToInt32(num3+num4);
            Console.WriteLine($"Converted number is {convo * 2}");

            // using Convert
            string boolString = "False";
            bool boolValue = Convert.ToBoolean(boolString);
            Console.WriteLine($"my bool is {boolValue}");

            // implicitly typed variable
            var myName = "Kushal";
            var mYLuckyNumber = 465489966523245;
            var luckyNum = 464646;
            var sumLucky = mYLuckyNumber + luckyNum;

            // explicitly typed variable
            string name = "Kushal";
            int lucks = 4;

            // operators/order of evaluation example
            var num1 = 3;
            // var num1 = 0; --> This would be a runtime error because dividing by 0 gives infinity.
            // 
            Console.WriteLine("Enter a whole number");
            var num2 = int.Parse(Console.ReadLine());

            // var num2 = (int)Console.ReadLine(); --> This is an example of a compile time error.

            Console.WriteLine("Sum of num1 and num2 = " + (num1 + num2));
            Console.WriteLine("Subtraction of num 1 by num 2 = " + (num1 - num2));
            Console.WriteLine("num1 times num2 = " + num1*num2);
            Console.WriteLine("Division of num1 and num2 = " + (double)num1/num2);

            // intro to char datatype
            char myFavouritechar = '*';

            //string formatting example
            int number = 10;
            double price = 16.9;
            string nameMine = "Kushal";
            Console.WriteLine("The number is {0}, the price is {1},\nthe name is {2}", number, price, nameMine);

            //enabling use of special characters in C#
            string myString = "This is a \"string\" with a backslash \\ and\nthis is a colon: ";
            Console.WriteLine(myString);

            /* logical operators including Boolean: AND &&, OR ||, NOT !, XOR ; Relational: <, >, <=, >=, == , != ; Combined: which combines both boolean and relational to create complex logic. 
             AND outputs True when all operands are true. OR is true when at least one operand is true. NOT is true when final output is false, XOR is true when only one operand is true.
             */

            /*
            //relational operators in code.
            int numb1 = 5;
            int numb2 = 5;

            // declaring a variable outside of if statment(or outside of condition scope) to make it global and accessible outside the if return. 
            int myAge; 
            bool isGreater = numb1 == numb2;
            Console.WriteLine("Guess any number between 1 and 10.");
            if (numb1 == int.Parse(Console.ReadLine())) {
                Console.WriteLine("Congrats your guess is correct!");
                Console.WriteLine("Please enter your age:");
                myAge = int.Parse(Console.ReadLine());
                if (myAge >= 18)
                {
                    Console.WriteLine("Please enter your address so that you can receive the prize.");
                    string address = Console.ReadLine();
                }
                else { Console.WriteLine("Sorry, we cant offer you the prize!"); }
            }

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Go and party in the club.");
            } else if (age >= 13) {
                Console.WriteLine("Are you with your parents? Answer with y or n.");
                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("Go and party in the club with your parents");

                } else
                {
                    Console.WriteLine("No party for you today!");
                }
            }  else
            {
                Console.WriteLine("Go and party at kindergarten");
            }

                //boolean operators in code and if statement. 
                bool isRainy = true;
            bool hasUmbrella = true;
            if (!isRainy && hasUmbrella)
            {
                Console.WriteLine("I'm protected");
            }
            Console.WriteLine("I am ok.");

            using if and switch for similar case.
            int month = 3;
                    string monthName;

                    if (month == 1)
                    {
                        monthName = "January";
                    }
                    else if (month == 2)
                    {
                        monthName = "Febraury";
                    }
                    else if (month == 3) { monthName = "March"; }
                    else { monthName = "unknown"; }

                    switch (month)
                    {
                        case 1:
                            monthName = "January";
                            break;
                        case 2:
                            monthName = "Febraury";
                            break;
                        case 3:
                            monthName = "March";
                            break;
                        default:
                            monthName = "unknown";
                            break;
                    }
                    Console.WriteLine($"The current month is {monthName}");

                    Switch Vs If
                    Switch is better for:
                    1. Switch is cleaner than if.
                    2. Enum Types
                    3. Many distinct options for a single variable. 
                    If is better for:
                    1. if you have multiple comparisons
                    2. if you have dynamic conditions meaning if the values can change during runtime. 
                    3. if you have range values to check (eg, 6>x>10)


            // How operators ++ and -- work
            int num = 0;
            Console.WriteLine($"The number is {num}");
            num++;
            Console.WriteLine($"The number is {num}");
            Console.WriteLine("The number is {0}", ++num); // this does pre-incrementing
            Console.WriteLine("The number is {0}", num++); // this does post-incrementing
            Console.WriteLine($"The number is {num}");

            num--;
            Console.WriteLine($"The number is {num}");
            Console.WriteLine("The number is {0}", --num); // this does pre-decrementing
            Console.WriteLine("The number is {0}", num--); // this does post-decrementing
            Console.WriteLine($"The number is {num}");

            // Increment,decrement, multiply or divide by larger number than 1
            num += 30;
            Console.WriteLine($"The number is {num}");
            num -= 10;
            Console.WriteLine($"The number is {num}");
            num *= 20;
            Console.WriteLine($"The number is {num}");
            num /= 10;
            Console.WriteLine($"The number is {num}");

            // modulus operator
            num %= 37;
            Console.WriteLine($"The number is {num}");




            // creates an instance of the Random class.
            Random random = new Random();

            // generates a random number using Next method. 
            int randomNumber = random.Next(1,11);
            Console.WriteLine("Please enter a number.");
            int num;
            // stores valid int into num variable and returns whether user input valid number or not. 
            bool isNumber = int.TryParse(Console.ReadLine(), out num);
            if (isNumber)
            {
                if (num == randomNumber)
                {
                    Console.WriteLine("You guessed it right!");
                } else
                {
                    Console.WriteLine("Sorry, you guessed it wrong! The correct guess was " + randomNumber);
                }
            }
            else { Console.WriteLine("Please enter a valid number!"); }



            // Introduction to for loops

            // uses \n to break the line. \ is genereally termed as an 'escape character'. In Linux, it's used as /r/n which is called carriage return.
            string myString = "Hi\nHi";
            for (int counter = 10; counter >= 0; counter++)
            {
                Console.WriteLine(counter);    
                //makes the app sleep for desired time.
                Thread.Sleep(1000);
                Console.Clear();
            }


            // intro to while loops
            int number = 0;
            while (number < 10) { Console.WriteLine(number++); }

            Console.WriteLine("run or rest");
            string userString = Console.ReadLine();
            while (userString != "run")
            {
                Console.WriteLine("Run for a mile.");
                Console.WriteLine("Do you want to run more or rest?");
                userString = Console.ReadLine();
            }
            Console.WriteLine("Finally, you can take some rest!");

            Random random = new Random();
            int secretNumber = random.Next(1, 20);
            int userGuess = 0;
            int counter = 0;
            Console.WriteLine("Guess any number between 1 and 20");
            while (userGuess != secretNumber)
            {
                Console.WriteLine("Enter your guessed number:");
                userGuess = int.Parse(Console.ReadLine());
                counter++;
                if (userGuess > secretNumber) { Console.WriteLine("Try lower."); }
                else if (userGuess < secretNumber) { Console.WriteLine("Try higher."); }
                else { Console.WriteLine("Congratulations! You have guessed the right number!, You took {0} tries.", counter); }
            }

            for (int userGuess = 0; userGuess != secretNumber;)
            {
                Console.WriteLine("Enter your guessed number:");
                userGuess = int.Parse(Console.ReadLine());
                counter++;
                if (userGuess > secretNumber) { Console.WriteLine("Try lower."); }
                else if (userGuess < secretNumber) { Console.WriteLine("Try higher."); }
                else { Console.WriteLine("Congratulations! You have guessed the right number!, You took {0} tries.", counter); }
            }

            int number;
            do
            {
                Console.WriteLine("Enter a positive whole number");
                number = int.Parse(Console.ReadLine());
            } while (number <= 0);

            int studentScore;
            int counter=0;
            int sum = 0;
            do
            {
                Console.WriteLine("Enter your student score, if you are done enter -1 to see the average.");
                studentScore = int.Parse(Console.ReadLine());
                sum = sum + studentScore;
                counter++;

            } while (studentScore != -1);
            int average = (sum + 1) / (counter-1);
            Console.WriteLine("The average is "+ average);

            // uses of break and continue in loops
            for (int i=0; i<6; i++)
            {
                if (i == 3)
                {
                    continue; // this skips the current iteration which is when i is 3.
                }
                if (i == 5) {
                    break; // this stops the loop once and for all.
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("loop has ended at 5th iteration.");

            // intro to arrays
            int[] numberArray = [7,8,9,10,11]; // declares an array variable of type int. 
            string[] stringArray = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"]; // declares an array variable of type string. 
            // array position(index): 0 1 2 3  4
            // values assigned:       7 8 9 10 11
            Console.WriteLine($"Today is {stringArray[0]}day."); // Outputs the first element inside an array. 

            // uses for loop to loop through all elements in an array.
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // uses foreach loop to assign each element of an array.  
            foreach (var day in stringArray)
            {
                Console.WriteLine(day);
            }

            // declares 2D and 3D arrays.
            int[,] array2D = { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 } 
            }; // initialises a 2D array.
            Console.WriteLine(array2D[1,1]); // prints an element of a 2D array.

            string[,] array2Dindices = {
                {"0,0", "0,1", "0,2"},
                {"1,0", "1,1", "1,2"},
                {"2,0", "2,1", "2,2"} 
            };
            Console.WriteLine(array2Dindices[2,1]);

            // initializes a 3D array.
            string[,,] array3Dindices = {
                {
                    { "0,0,0", "0,0,1", "0,0,2" }, { "0,1,0", "0,1,1", "0,1,2" }, { "0,2,0", "0,2,1", "0,2,2" }
                },
                {
                    { "1,0,0", "1,0,1", "1,0,2" }, { "1,1,0", "1,1,1", "1,1,2" }, { "1,2,0", "1,2,1", "1,2,2" }
                },
                {
                    { "2,0,0", "2,0,1", "2,0,2" }, { "2,1,0", "2,1,1", "2,1,2" }, { "2,2,0", "2,2,1", "2,2,2" }
                }
            };
            Console.WriteLine(array3Dindices[2,1,2]); // prints an element of a 3D array.

            int[][] firstJaggedArray = [[1, 2, 3], [4, 5], [6, 7]];
            for (int i = 0; i < firstJaggedArray.Length; i++)
            {
                for (int j = 0; j < firstJaggedArray[i].Length; j++)
                {
                    Console.WriteLine(firstJaggedArray[i][j]);
                }
            }
            foreach (var numberSet in firstJaggedArray)
            {
                foreach (int number in numberSet)
                {
                    Console.WriteLine(number);
                }
            }

            int[,] numbersArray = {
                            {1,2,3},
                            {4,5,6},
                            {7,8,9}
                        };

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += numbersArray[i,j];
                            }
                Console.WriteLine(sum);
            }

            // Template for a method
            <access specifier><return type><method name>(parameters list) {
            <method body>
            }


            // Add method example
            int Add(int num1, int num2)
            {
                int sum = num1 + num2;
                return sum; // returns the calculated result to the method. 
            }
            Console.WriteLine("Please enter a number. I'll add 10 to it!");
            int userInt = int.Parse(Console.ReadLine());
            int result = Add(userInt, 10); // stores the returned value from the method.
            Console.WriteLine($"The final result is {result}.");

            // defines a void method.
            void MyFirstMethod()
            {
                Console.WriteLine("This was called inside my method.");
                Console.WriteLine("Some very complicated blocks of code.");
            }
            MyFirstMethod();
            Console.WriteLine("This was called outside of method!");

            // defines a method with a parameter
            void WriteSomething(string myArgument)
            {
                Console.WriteLine("You passed "+myArgument+" as an argument to this method's parameter.");
            }
            WriteSomething("Sam"); // calls the method.
            string myString = "Kushal";
            WriteSomething(myString);

            // defines concept of argument promotion
            // implicit conversion from smaller data type to larger data type.
            void myMethod(double number)
            {
                Console.WriteLine("The double type number is:"+ number);
            }
            int numArg = 12;
            myMethod(numArg);

            void CalculateArea(double radius)
            {
                double area = Math.PI * radius * radius;
                Console.WriteLine($"The area of this circle is {area}.");
            }
            int circleRadius = 13;
            CalculateArea(circleRadius);

            void myMethod1(double number)
            {
                Console.WriteLine($"Double function is called with {number}.");
            }
            void myMethod2(int num)
            {
                Console.WriteLine($" int function is called with {num}.");
            }
            myMethod1(10);
            myMethod1(12.7f);


            // uses ref parameter modifier to modify existing data inside the method.
            void modifyValue (ref int number)
            {
                number += 10;
            }
            int myNumber = 10;
            modifyValue(ref myNumber);
            Console.WriteLine(myNumber);

            // uses out modifier to return multiple values
            void SumAndProduct(int num1, int num2, out int sum, out int product)
            {
                sum = num1+ num2;
                product = num1 * num2;
            }
            int number1 = 10, number2 = 3, sum, product;
            SumAndProduct(number1, number2, out sum, out product);
            Console.WriteLine($"Sum is {sum}. Product is {product}");

            //uses in modifier to pass read-only variable
            void ReadOnlyValue(in int number)
            {
                // number += 10; -> causes an error because its read-only.
                Console.WriteLine(number);
            }
            int userNumber = 10;
            ReadOnlyValue(in userNumber);
            
             
            Car bmw = new Car("i7","BMW", false);
            Car audi = new Car("a3","Audi", true);
            Car porsche = new LuxuryCar();

            // uses is operator to check object type.
            if (porsche is LuxuryCar)
            {
                Console.WriteLine("porsche is of class Luxury Car");
            }
            LuxuryCar myPorsche = porsche as LuxuryCar; // casts object type using as operator.
            if (myPorsche != null)
            {
                Console.WriteLine("Cast successful!");
            }
            else {
                Console.WriteLine("Cast failed!");
            }
                Console.WriteLine("Please enter your brand name.");
            bmw.Brand = Console.ReadLine();
            Console.WriteLine($"The brand and model name is {bmw.BrandModel}");
            bmw.Drive();
            audi.Drive();
            Console.WriteLine("Total number of cars created is: " + Car.NumberOfCars); // accesses the value of a public static variable from class Car.

            Customer myCustomer = new Customer(name: "Kushal", address: "Brisbane", contact: "0466820430"); // uses named parameter instead of raw data. 
            Customer myCustomer2 = new Customer("Jenny");
            Customer myCustomer3 = new Customer();
            Console.WriteLine(myCustomer.Address);
            Console.WriteLine(myCustomer2.Address);
            Console.WriteLine(myCustomer3.Contact);
            myCustomer3.CreateDetails("Jeewan", "Biratnagar", "9862194726");
            Console.WriteLine(myCustomer3.Contact);
            Customer.Location myInnerLocation = new Customer.Location(myCustomer); // creates an instance of inner class Location.
            myInnerLocation.DisplayCustomerAddress();
            myCustomer.CarBrand = "Mercedes";
            Console.WriteLine(myCustomer.CarBrand);
            Customer couple = myCustomer + myCustomer2;
            Console.WriteLine(couple.Name);
            myCustomer.ViewDetails();
            myCustomer3.ViewDetails();
            myCustomer.Password = "125asdhasiudh^%&^%"; // assings value to the Password property.
            */

            List<string> colors = ["red", "green", "blue", "red"]; // initializes a list.
            colors.Add("purple"); // adds a new element to the list.
            Console.WriteLine("The colors in the list are:");
            foreach (string color in colors) // loops through each element on a list.
            {
                Console.WriteLine(color);
            }
            bool isDeleted = colors.Remove("red"); // removes a specific element from a list. 
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            while (isDeleted) {
               isDeleted = colors.Remove("red");
            }
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            List<int> numbers = [9,7,45,32,1];
            Console.WriteLine("\nUnsorted List:");
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
            Console.WriteLine("\nSorted List:");
            numbers.Sort(); // sorts the elements in the list.
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            List<int> filteredList = numbers.FindAll(x => x>10); // creates a new list with numbers greater then 10.
            Console.WriteLine("\nList of numbers greater than 10:");
            foreach (int number in filteredList) {
                Console.WriteLine(number);
            }
            Console.ReadLine();
            

        }
    }
}


