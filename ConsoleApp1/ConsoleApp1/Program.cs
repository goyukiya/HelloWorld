using System;
using System.IO;  // for file manipulation

namespace ConsoleApp1
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
        string First { get; set; } // interface property
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public string First { get ; set; }

        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    sealed class ForbiddenElement // cannot be inhererited
    {
        int id;
    }

    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void AnimalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car:Vehicle // inherit from Vehicle
    {
        string model; // private
        public string color = "red";
        private string name; // field
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        } 
        public int One { get; set; } // property

        // constructor
        public Car()
        {
            model = "Mustang";
        }
    }

    class Program
    {
        // fields
        string color = "red";
        enum Level
        {
            Low,
            Medium,
            High
        }

        static void Printer()
        {
            Console.WriteLine("I just got executed!");
        }

        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        /*
         * MAIN
         */

        static void Main(string[] args)
        {
            /*
             * Data type
             */

            int numberFive = 5;
            System.Console.WriteLine(numberFive);

            /* uses c# literal suffix */
            long numberLong = 15L; 
            float numberFloat = 3.0F; // 32bits
            double numberDouble = 5.99D; //64 bits, default for floating number
            System.Console.WriteLine(numberLong);
            System.Console.WriteLine(numberFloat);
            System.Console.WriteLine(numberDouble);

            // bit shift
            int x = 5;
            x >>= 3; // divide by 2^3= 8
            Console.WriteLine(x);

            char someChar = 'D'; // 2-bytes in C#
            System.Console.WriteLine(someChar);

            bool someBoolean = true;
            System.Console.WriteLine(someBoolean);

            // conversion

            Console.WriteLine(System.Convert.ToString(numberFive));    // convert int to string
            Console.WriteLine(Convert.ToDouble(numberFive));    // convert int to double
            Console.WriteLine(Convert.ToInt32(numberDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(someBoolean));   // convert bool to string

            string someText = "Hello World!";
            Console.WriteLine(someText);
            System.Console.WriteLine($"text lenght: { someText.Length}"); // length property

            // user input

            System.Console.WriteLine("Enter username:");
            string userName = System.Console.ReadLine(); // returns a string
            System.Console.WriteLine($"Username is: {userName}"); //string interpolation

            // Math
            System.Console.WriteLine(System.Math.Sqrt(64)+System.Math.Max(12,6));


            // foreach
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            // Declare an array
            string[] cars2;
            // Add values, using new
            cars2 = new string[] { "Volvo", "BMW", "Ford" };
            Console.WriteLine(cars2.Length);
            // no need for "C++ delete" thanks to garbage collector

            Printer();

            Console.WriteLine(MyMethod(y:1, x:3)); // named arguments

            // OOP
            Program myObj = new();
            Console.WriteLine(myObj.color);
            Car myCar = new();
            myCar.Name = "Hello";
            Console.WriteLine(myCar.Name);
            DemoClass dm = new();
            dm.First = "this is the first";
            Console.WriteLine(dm.First);


       
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content

            // exceptions
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}
