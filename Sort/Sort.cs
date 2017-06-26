using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    static public class Sort
    {
        public static void MergeSort(int[] arr)
        {
            int[] temp_arr = new int[arr.Length];
            MergeSort(arr, temp_arr, 0, arr.Length - 1);
        }

        public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        private static void MergeSort(int[] arr, int[] temp_arr, int left, int right)
        {
            if (right <= left)
                return;

            int mid = (left + right) / 2;

            MergeSort(arr, temp_arr, left, mid);
            MergeSort(arr, temp_arr, mid + 1, right);

            MergeHelper(arr, temp_arr, left, mid, right);
        }

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

    }
}
