using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating test arrays
            int[] testArray = { 2, 4, 6, 9 };
            int[] testArray2 = { 4, 8, 23, 42 };

            //printing arrays with value in the middle index
            Console.Write(string.Join(",", ArrayShift(testArray, 5)));
            Console.Write(string.Join(",", ArrayShift(testArray2, 16)));
        }

        //mathod to take original array, find the middle, and insert
        //the value into the center of the new array and return new array
        static int[] ArrayShift(int[], int value)


    }
}
