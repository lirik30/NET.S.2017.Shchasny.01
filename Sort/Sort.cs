using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// Class that contains diff types of sotring method
    /// </summary>
    public static class Sort
    {
        /// <summary>
        /// Method for sorting by merge
        /// </summary>
        /// <param name="arr">
        /// Array of integers
        /// </param>
        public static void MergeSort(int[] arr)
        {
            ArrayChecking(arr);
            int[] temp_arr = new int[arr.Length];
            MergeSort(arr, temp_arr, 0, arr.Length - 1);
        }


        /// <summary>
        /// Method for quick sort
        /// </summary>
        /// <param name="arr">
        /// Array of integers
        /// </param>
        public static void QuickSort(int[] arr)
        {
            ArrayChecking(arr);
            QuickSort(arr, 0, arr.Length - 1);
        }


        /// <summary>
        /// Main method for merge sort
        /// </summary>
        /// <param name="arr">
        /// Array of integers
        /// </param>
        /// <param name="temp_arr">
        /// Temporary array of integers
        /// </param>
        /// <param name="left">
        /// The left bound for part of array that is sorted
        /// </param>
        /// <param name="right">
        /// The right bound for part of array that is sorted
        /// </param>
        private static void MergeSort(int[] arr, int[] temp_arr, int left, int right)
        {
            if (right <= left)
                return;

            int mid = (left + right) / 2;

            MergeSort(arr, temp_arr, left, mid);
            MergeSort(arr, temp_arr, mid + 1, right);

            MergeHelper(arr, temp_arr, left, mid, right);
        }


        /// <summary>
        /// Supporting method for the merge sort
        /// </summary>
        private static void MergeHelper(int[] arr, int[] temp_arr, int left, int mid, int right)
        {
            int i = left, j = mid + 1;
            for (int k = left; k <= right; k++)
            {
                if (i > mid)
                    temp_arr[k] = arr[j++];

                else if (j > right)
                    temp_arr[k] = arr[i++];

                else if (arr[i] < arr[j])
                    temp_arr[k] = arr[i++];

                else
                    temp_arr[k] = arr[j++];
            }

            for (int k = left; k <= right; k++)
            {
                int temp = temp_arr[k];
                arr[k] = temp;
            }
        }


        /// <summary>
        /// Main method for the quick sort
        /// </summary>
        /// <param name="arr">Array of integers</param>
        /// <param name="left">The left bound of sorted part of array</param>
        /// <param name="right">The right bound of sorted part of array</param>
        private static void QuickSort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;

            int middle_elem = arr[(left + right) / 2];

            do
            {
                while (arr[i] < middle_elem)
                    i++;

                while (arr[j] > middle_elem)
                    j--;

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++; j--;
                }
            } while (i < j);

            if (left < j)
                QuickSort(arr, left, j);
            if (i < right)
                QuickSort(arr, i, right);
        }


        /// <summary>
        /// Checking an array for zero length and null
        /// </summary>
        /// <param name="arr"></param>
        private static void ArrayChecking(int[] arr)
        {
            if(arr == null)
                throw new ArgumentNullException();
            if(arr.Length == 0)
                throw new ArgumentException();
        }
    }
}
