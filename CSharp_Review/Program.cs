using System;

namespace CSharp_Review
{
    class Program
    {
        static void Main(string[] args)
        {
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
            name = Console.ReadLine();



            // Concatenation
            Console.WriteLine("Hello " + name + "! What's good? iT'S ALL gOOD!");

            // Parameterized Output
            Console.WriteLine("Hello {0}! What's good? iT'S ALL gOOD!", name);





            // Exit of the C# Program
        }
    }
}
