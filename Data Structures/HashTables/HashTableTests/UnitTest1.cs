using System;
using Xunit;
using HashTables;
using HashTables.Classes;

namespace HashTableTests
{
    public class UnitTest1
    {
        /// <summary>
        /// test to verify if contains method will return true when key is in hash table
        /// </summary>
        [Fact]
        public void TestToVerifyContains()
        {
            HashTable hashTable = new HashTable();
            hashTable.Add("a", "apple");

            Assert.True(hashTable.Contains("a"));
        }

        /// <summary>
        /// test to verify if the find method will return the key value pairs
        /// </summary>
        [Fact]
        public void TestToVerifyFind()
        {
            HashTable hashTable = new HashTable();
            hashTable.Add("a", "apple");

            Assert.Equal("a: apple", hashTable.Find("a"));
        }

        /// <summary>
        /// test to verify find with a collision
        /// </summary>
        [Fact]
        public void TestToVerifyFindWithCollision()
        {
            HashTable hashTable = new HashTable();
            hashTable.Add("ear", "face");
            hashTable.Add("are", "here");

            Assert.Equal("are: here", hashTable.Find("are"));
        }

        /// <summary>
        /// test to verify contains with a collision
        /// </summary>
        [Fact]
        public void TestToVerifyContainsWithCollision()
        {
            HashTable hashTable = new HashTable();
            hashTable.Add("eat", "food");
            hashTable.Add("tea", "drink");

            Assert.True(hashTable.Contains("tea"));
        }
    }
}
