using System;

namespace CSharp_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            // In-Class Exercise: 
            // Make the Admin
            // Declaration of a variable

            char aChar; // A single character value
            string aString; // String (A collection of characters))

            bool aBoolean; // Boolean (True or False) values

            byte aByte; // Super small integer values (120 max)
            short aShortInt; // Small integer values (~65000 max)
            int anInt; // Numerical values with no decimals (~210000000 max)
            long aLongInt; // Big integer values (Bigger than above)

            float aFloat; // floating point values with less precision than doubles
            double aDouble; // Decimal values
            decimal aDecimal; // Also decimal values

            int userInput;
            string output;

            Console.Write("Please enter a number:");

            userInput = int.Parse(Console.ReadLine());

            // Switch works with discrete values, not range like if allows, but some people fint it more readable.
            // Anything you can do with a switch, you can do with an if
            // Falling through cases 

            switch (userInput % 2)
            {
                case 0:
                    output = "even";
                    break;
                case 1:
                    output = "odd";
                    break;
                default:
                    output = "even";
                    break;
            }

            Console.WriteLine($"The Number is {userInput}, it is {output}");
            // Exit of the C# Program
        }
    }
}
