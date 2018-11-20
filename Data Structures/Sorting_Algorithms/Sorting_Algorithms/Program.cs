using System;

namespace Sorting_Algorithms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = new int[] { 4, 8, 2, 10, 6, 12 };
            Console.WriteLine("Beginning array:");
            foreach (int index in array)
            {
                Console.WriteLine(index);
            }

            Console.WriteLine("Sorted array:");

            int[] sortedArr = InsertionSort(array);

            foreach(int item in sortedArr)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// method to preform an insertion sort through an array of integers
        /// </summary>
        /// <param name="array"></param>
        /// <returns>array of integers</returns>
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;

                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            return array;
        }
    }
}
