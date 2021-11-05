using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\Samples\shoppinglist";
            string fileName = @"\\shoppinglist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> shoppinglist = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add an item Y/N?");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item:");
                    string userItem = Console.ReadLine();
                    shoppinglist.Add(userItem);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

            }
            
            Console.Clear();

            foreach (string item in shoppinglist)
            {
                Console.WriteLine($"Your wish: {item}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", shoppinglist);
            
        }
    }
}
