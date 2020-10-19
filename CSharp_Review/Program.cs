using System;
using System.IO.Compression;

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

            Console.Write("Please enter a number to count to:");

            userInput = int.Parse(Console.ReadLine());


            // Initialize, Test, Modify
            for (int x = 1; x <= userInput; x++)
            {
                // Process
                Console.WriteLine(x);
            }

            // Initialize
            int y = 1;
            // Test
            while (y <= userInput)
            {
                // Process
                Console.WriteLine(y);
                y++; // Modify
            }


            int u = 1;
            do {
                Console.WriteLine(u);
                u++; 
            }
            while (u <= userInput);



            // Exit of the C# Program
        }
    }
}
