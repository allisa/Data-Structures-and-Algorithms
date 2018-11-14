using LinkedLists.Classes;
using System;
using System.Collections.Generic;
using System.Text;


namespace HashTables.Classes
{
    public class HashTable
    {
        LList[] Table = new LList[1024];

        /// <summary>
        /// method to get hash key for placement in table
        /// </summary>
        /// <param name="key"></param>
        /// <returns>array index</returns>
        public int GetHash(string key)
        {
            int index = 0;
            foreach(char item in key)
            {
                index += item;
            }
            index = (index * 599) % Table.Length;
            return index;
        }

        /// <summary>
        /// method to see if the key exists in the table
        /// </summary>
        /// <param name="key"></param>
        /// <returns>true/false</returns>
        public bool Contains(string key)
        {
            if (Find(key) == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// method to find key and return key/value pair
        /// </summary>
        /// <param name="key"></param>
        /// <returns>returns key/value pairs</returns>
        public string Find(string key)
        {
            int index = GetHash(key);
            Table[index].Current = Table[index].Head;
            while (Table[index].Current != null)
            {
                if ((string)Table[index].Current.Key == key)
                {
                    return $"{(string)Table[index].Current.Value}: {(string)Table[index].Current.Value}";
                }
                else
                {
                    Table[index].Current = Table[index].Current.Next;
                }
            }
            return null;
        }

        //Add(key, value) - void return
        public void Add(string key, string value)
        {
            int index = GetHash(key);
            Node node = new Node(key, value);
        }


    }

    //int index = GetHash(key);

    //if (Table[index] == null)
    //{
    //    return false;
    //}
    //Table[index].Current = Table[index].Head;

    //while(Table[index].Current != null)
    //{
    //    if((string)Table[index].Current.Key == key)
    //    { }
    //}
}
