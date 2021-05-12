using System;

namespace ConsoleApp1
{
    class Program
    {
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
            System.Console.WriteLine($"Username is: {userName}");

            // Math
            System.Console.WriteLine(System.Math.Sqrt(64)+System.Math.Max(12,6));
        }
    }
}
