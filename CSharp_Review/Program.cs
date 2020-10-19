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

            string name;

            // String Interpolation
            Console.WriteLine($"Please enter your name.");

            // Input from the Console
            name = Console.ReadLine().Trim().ToLower();

            // Condition is an expression that evaluates to either true or False.
            // True runs the 'if' side, False runs the 'else' side

            // Roughly equivalent to name == "", except it also accounts for whitespace and null values.
            // Whitespace is already trimmed. 
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid Input, please enter a name!");
            }
            else if (name == "admin")
            {
                Console.WriteLine("Administrative Access Granted! You're In!");

            }
            else
            {
                // Concatenation
                Console.WriteLine("Hello " + name + "! What's good? iT'S ALL gOOD!");

                // Parameterized Output
                Console.WriteLine("Hello {0}! What's good? iT'S ALL gOOD!", name);

            }


            // Exit of the C# Program
        }
    }
}
