using System;
using System.IO.Compression;

namespace CSharp_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entry of the Program

            // C# Arrays are fixed length collections of numbers:
            
            // Initialize an array of length 5.
            // Indexes start at 0, then ramp up like in JS. 5th index is [4].
            int[] intArray = new int[5];

            // If we want to set it, like other languages, we can assign an index. 
            intArray[3] = 10;

            for (int i = 0; i <= intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            // Exit of the C# Program
        }
    }
}
