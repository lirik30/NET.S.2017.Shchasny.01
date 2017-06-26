using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QucikSortLogic
{
    static public class QuickSortLogic
    {
        public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
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
