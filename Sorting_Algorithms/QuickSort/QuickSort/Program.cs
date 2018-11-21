using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] testArray = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("Unsorted array:");
            foreach(int item in testArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sorted array:");
            int[] sortedArray = QuickSort(testArray, 0, testArray.Length - 1);
            foreach(int item in sortedArray)
            {
                Console.WriteLine(item);
            }

        }

        static int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Partition the Algorithm
                int position = Partition(arr, left, right);
                // Sort the left
                QuickSort(arr, left, position - 1);
                // Sort the right
                QuickSort(arr, position + 1, right);
            }
            return arr;

        }

        static int Partition(int[] arr, int left, int right)
        {
            // set a pivot
            int pivot = arr[right];
            // get the index of the lower value
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }

            }

            Swap(arr, right, low + 1);

            Console.WriteLine(string.Join(",", arr));


            return low + 1;
        }

        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
