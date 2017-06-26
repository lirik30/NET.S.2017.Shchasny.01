using System;
using QucikSortLogic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15] { 8, 17, 8, 4, 82, 59, 97, 61, 35, 10, 34, 48, 27, 75, 60 };
            Output(arr);
            Console.WriteLine();
            QuickSortLogic.QuickSort(arr);
            Output(arr);
            Console.ReadKey();
        }

        static void Output(int[] arr)
        {
            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}
