using System;
using System.Collections.Generic;

namespace CSharpReview_4Point2
{
    class Program
    {
        static void Main(string[] args)
        // In class practice:
        // Change the program to take in a list of names. Make sure the names are trimmed before they enter the list.
        // Change the GetInt() method to GetName().
        // Challenge: Prevent duplicates (case insensitive) from being added.

        // Entry point of programs in C#.
        {
            List<string> nameList = new List<string>();

            int userNumber = GetInt("Please enter an Integer:");

            string x = "x";

            string userInput = "";
            do
            {
                userInput = GetName("Please enter a name to add to the list, or type 'x' to exit: ");
                if (userInput != "x")
                {

                    if (!nameList.Exists(x => x.ToUpper() == userInput.ToUpper())) {
                        // Exists() accepts a predicate, which is typically expressed as an arrow funtion
                        // Left side of the arrow is the input, the right side of the arrow is the return.
                    nameList.Add(userInput);
                    }
                }
            } while (userInput.ToLower() != x);


            // foreach will loop over every item in a collection, however they are typically treated as readonly (with "normal" data types anyways).
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
        }

        /*
            static: Tells C# to only keep one copy of the method in memory (important for OOP).
            int: Return type, the type of data coming out of the method.
            GetInt: Name of the method, how we call it.
            string: First parameter type, the type of input expected.
            prompt: First parameter/argument name, how we refer to that value in the method.
        */
        static string GetName(string prompt)
        {

                string input;
                Console.Write(prompt);
                input = (Console.ReadLine());
                return input;

        }

        static int GetInt(string prompt)
        {
            int input = 0;
            bool valid = false;
            do
            {
                Console.Write(prompt);
                try
                {
                    input = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch
                {
                    Console.WriteLine("Error: Invalid Integer..");
                }
            }
            while (!valid);

            return input;
        }
    }
}