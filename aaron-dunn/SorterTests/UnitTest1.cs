using System;
using System.Collections.Immutable;
using NUnit.Framework;
using Sorter;

namespace SorterTests
{
    public class Tests
    {

        public void WhenBubbleSortCalledReturnsSortedArray(int[] value)
        {
            BubbleSorter sorter = new BubbleSorter();
            
            Assert.AreEqual(new int[5] {1, 2, 3, 4, 5}, sorter.BubbleSort(new int[5] {5, 4, 3, 2, 1}));
            Assert.AreEqual(new int[7] {1, 5, 5, 6, 6, 10, 11}, sorter.BubbleSort(new int[7] {5, 5, 6, 10, 1, 11, 6}));

        }

        [Test]
        public void WhenBubbleSortPassedArrayOfLength1ReturnsArray()
        {
            BubbleSorter sorter = new BubbleSorter();
            int[] testArr = new int[1] { 1 };
            int[] resultArr = new int[1] { 1 };
            
            Assert.AreEqual(resultArr, sorter.BubbleSort(testArr));


        }
    }
}