using HashTables.Classes;
using System;

namespace RepeatWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string testString = "Once upon a time, there was a brave princess who...";
            Console.WriteLine($"Test string: {testString} with the first repeated word being: {RepeatedWord(testString)}");
        }

        public static string RepeatedWord(string stringValue)
        {
            HashTable hashTable = new HashTable();

            string[] stringArr = stringValue.ToLower().Split(" ");

            foreach(string words in stringArr)
            {
                if (!hashTable.Contains(words))
                    hashTable.Add(words, null);
                else
                    return words;
            }
            return null;
        }
    }
}
