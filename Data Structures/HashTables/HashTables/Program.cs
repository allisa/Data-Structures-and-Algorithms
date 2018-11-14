using HashTables.Classes;
using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashTable hashTable = new HashTable();

            hashTable.Add("A", "Apple");
            Console.WriteLine("Adding key: A and value: Apple");
            Console.WriteLine($"In hash table: {hashTable.Contains("A")}");

            hashTable.Add("B", "Banana");
            Console.WriteLine("Adding key: B and value: Banana");
            Console.WriteLine($"In hash table: {hashTable.Contains("B")}");

            hashTable.Add("on", "fire");
            Console.WriteLine("Adding key: on and value: fire");
            Console.WriteLine($"In hash table: {hashTable.Contains("on")}");

            hashTable.Add("no", "space");
            Console.WriteLine("Adding key: no and value: space");
            Console.WriteLine($"In hash table: {hashTable.Contains("no")}");


        }
    }
}
