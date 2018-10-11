using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating test arrays
            int[] testArray1 = { 4, 8, 15, 16, 23, 42 };
            int[] testArray2 = { 11, 22, 33, 44, 55, 66, 77 };
            int input1 = 15;
            int input2 = 90;

            Console.WriteLine(BinarySearchMethod(testArray1, input1));
            Console.WriteLine(BinarySearchMethod(testArray1, input2));
        }

        /// <summary>
        /// Search through sorted array for binary search
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearchMethod(int[] array, int target)
        {
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int middle = (min + max) / 2;
                if (target == array[middle])
                {
                    return middle;
                }
                else if (target < array[middle])
                {
                    max = middle - 1;
                }
                else
                {
                    min = middle + 1;
                }
            }
            return -1;
        }
    }
}
