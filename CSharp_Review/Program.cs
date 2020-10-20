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

            int[] intArray = new int[GetInt("Please enter the number of integers you want to store:")];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = GetInt($"Please enter Integer #{i + 1}");
            }

            // For each will loop over every item in a collection, but they are typically treated as read only. 
            foreach (int integer in intArray)
            {
                Coneole.WriteLine(integer);
            }


            // Exit of the C# Program
        }
        /*
         *  static: Tells C# to only keep one copy of the method in memory (Important for OOP)
         *  int: Return type, the type of data coming out of the method
         *  GetInt: name of the method, how it is called.
         *  string: First parameter type, the type of input expected.
         *  prompt: First parameter/argument name, how we refer to that value in the method.
         */
        static int GetInt(string prompt)
        {
            int input;

            Console.WriteLine(prompt);
            input = int.Parse(Console.ReadLine());

            return input;
        }
    }
}
