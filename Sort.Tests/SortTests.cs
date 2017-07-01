using System;
using static Sorting.Sort;
using NUnit.Framework;

namespace Sort.NUnitTests
{
    [TestFixture]
    public class SortTests
    {

        #region QuickSortTests
        /// <summary>
        /// This is a test method for quick sort that must return positive result
        /// </summary>
        /// <param name="arr">Array of integers</param>
        /// <returns>Sorted array</returns>
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 5, 4, 4, 4, 1 }, ExpectedResult = new int[] { 1, 4, 4, 4, 5 })]
        [TestCase(new int[] { 1, 2, 2, 4, 7, 1, 1, 1, 4, 10, 101, 32 }, ExpectedResult = new int[] { 1, 1, 1, 1, 2, 2, 4, 4, 7, 10, 32, 101 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, ExpectedResult = new int[] { 1, 1, 1, 1, 1 })]
        [TestCase(new int[] { 10, 9, 12, 11, 15, 14, 32, 18, 19, 20 }, ExpectedResult = new int[] { 9, 10, 11, 12, 14, 15, 18, 19, 20, 32 })]
        public int[] QuickSort_PositiveTests(int[] arr)
        {
            QuickSort(arr);
            return arr;
        }


        /// <summary>
        /// This is a test method for quick sort that must throws ArgumentNullException
        /// </summary>
        /// <param name="arr">Array of integers</param>
        [TestCase(null)]
        public void QuickSort_ThrowsArgumentNullException(int[] arr)
        {
            Assert.Throws<ArgumentNullException>(() => QuickSort(arr));
        }


        /// <summary>
        /// This is a test method for quick sort that must throws ArgumentException
        /// </summary>
        /// <param name="arr">Array of integers</param>
        [TestCase(new int[0])]
        public void QuickSort_ThrowsArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => QuickSort(arr));
        }
        #endregion

        #region MergeSortTests
        /// <summary>
        /// This is a test method for merge sort that must return positive result
        /// </summary>
        /// <param name="arr">Array of integers</param>
        /// <returns>Sorted array</returns>
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 5, 4, 4, 4, 1 }, ExpectedResult = new int[] { 1, 4, 4, 4, 5 })]
        [TestCase(new int[] { 1, 2, 2, 4, 7, 1, 1, 1, 4, 10, 101, 32 }, ExpectedResult = new int[] { 1, 1, 1, 1, 2, 2, 4, 4, 7, 10, 32, 101 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, ExpectedResult = new int[] { 1, 1, 1, 1, 1 })]
        [TestCase(new int[] { 10, 9, 12, 11, 15, 14, 32, 18, 19, 20 }, ExpectedResult = new int[] { 9, 10, 11, 12, 14, 15, 18, 19, 20, 32 })]
        public int[] MergeSort_PositiveTests(int[] arr)
        {
            MergeSort(arr);
            return arr;
        }


        /// <summary>
        /// This is a test method for merge sort that must throws ArgumentNullException
        /// </summary>
        /// <param name="arr">Array of integers</param>
        [TestCase(null)]
        public void MergeSort_ThrowsArgumentNullException(int[] arr)
        {
            Assert.Throws<ArgumentNullException>(() => MergeSort(arr));
        }


        /// <summary>
        /// This is a test method for merge sort that must throws ArgumentException
        /// </summary>
        /// <param name="arr">Array of integers</param>
        [TestCase(new int[0])]
        public void MergeSort_ThrowsArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => MergeSort(arr));
        }
        #endregion
    }
}
