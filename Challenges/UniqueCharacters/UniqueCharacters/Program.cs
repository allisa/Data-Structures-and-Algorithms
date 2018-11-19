using HashTables.Classes;
using System;
using System.Collections.Generic;

namespace UniqueCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string greeting = "Hello World!";
            Console.WriteLine($"Does {greeting} contain unique characters?");
            Console.WriteLine(UniqueChar(greeting));

            string uniqueString = "asdfg hjkl zxcvb nmqwer";
            Console.WriteLine($"Does {uniqueString} contain unique characters?");
            Console.WriteLine(UniqueChar(uniqueString));

        }

        /// <summary>
        /// method to put all character minus spaces into list and check list for unique characters
        /// </summary>
        /// <param name="input"></param>
        /// <returns>true or false</returns>
        public static bool UniqueChar(string input)
        {
            HashTable hashTable = new HashTable();
            List<char> stringChar = new List<char>();

            //loop to remove space between words
            foreach(char letter in input)
            {
                if (letter != ' ')
                {
                    stringChar.Add(letter);
                }
            }

            //loop to look for unique characters
            foreach (char letter in stringChar)
            {
                if (hashTable.Contains(letter.ToString()))
                    return false;
                else hashTable.Add(letter.ToString(), letter.ToString());
            }
            return true;
        }
    }
}
