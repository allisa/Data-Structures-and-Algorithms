using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating test arrays
            int[] testArray = { 2, 4, 6, 8 };
            int[] testArray2 = { 4, 8, 23, 42 };

            //printing arrays with value in the middle index
            Console.WriteLine(string.Join(",", ArrayShift(testArray, 5)));
            Console.WriteLine(string.Join(",", ArrayShift(testArray2, 16)));
        }

        //method to take original array, find the middle, and insert
        //the value into the center of the new array and return new array
        static int[] ArrayShift(int[] array, int value)
        {
            //creating new array with space for added value
            int[] newArray = new int[array.Length + 1];

            //finding middle index of array, using math.ceiling to account for odd array lengths
            decimal middleIdx = array.Length / 2;
            decimal midIdx = Math.Ceiling(middleIdx);

            for(int i = 0; i < newArray.Length; i++)
            {
                if (i < midIdx)
                {
                    newArray[i] = array[i];
                }
                else if (i == midIdx)
                {
                    newArray[i] = value;
                }
                else
                {
                    newArray[i] = array[i - 1];
                }
            }
            return newArray;
        }
    }
}
