using System;

namespace MergeSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] testArray = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("Unsorted array:");
            foreach (int item in testArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sorted array:");
            MergeSort(testArray);
            foreach (int item in testArray)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// method to preform a merge sort
        /// </summary>
        /// <param name="myArray"></param>
        static void MergeSort(int[] myArray)
        {
            if (myArray.Length > 1)
            {
                //set array size
                int leftSize = myArray.Length / 2;
                int rightSize = myArray.Length - leftSize;

                //copy leftSize into left
                int[] left = new int[leftSize];
                Array.Copy(myArray, 0, left, 0, leftSize);

                //copy rightSize into right
                int[] right = new int[rightSize];
                Array.Copy(myArray, myArray.Length / 2, right, 0, rightSize);

                //calling MergeSort on left and right. then calls Merge on all
                MergeSort(left);
                MergeSort(right);
                Merge(left, right, myArray);
            }
        }

        /// <summary>
        /// Method to merge arrays in MergeSort method
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="arr"></param>
        /// <returns>sorted array</returns>
        static int[] Merge(int[] left, int[] right, int[] arr)
        {
            // left pointer
            int i = 0;
            // right pointer
            int j = 0;
            // end array pointer
            int k = 0;

            // confirm that each array being compared still has pointers
            while (i < left.Length && j < right.Length)
            {
                // if the value of left array is less than the value of the right array
                if (left[i] <= right[j])
                {
                    // populate the main array with lower value
                    arr[k] = left[i];
                    // immediately increment i.
                    i++;
                }
                else
                {
                    // put the value of the right array into the main array
                    arr[k] = right[j];
                    // increment the pointer of the right
                    j++;
                }
                // increment the pointer in the main array
                k++;
            }

            if (i == left.Length)
            {
                // copy right array into main array
                Array.Copy(right, j, arr, k, right.Length - j);
            }
            else
            {
                Array.Copy(left, i, arr, k, left.Length - i);
            }
            return arr;
        }
    }
}
