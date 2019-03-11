using NUnit.Framework;
using Sorter;

namespace Tests
{
    public class Tests
    {


        [Test]
        public void WhenBubbleSortCalledReturnsSortedarray()
        {
            BubbleSorter sorter = new BubbleSorter();
            int[] testArr = new int[5] {5, 4, 3, 2, 1};
            int[] resultArr = new int[5] {1, 2, 3, 4, 5};
            
            Assert.AreEqual(resultArr, sorter.BubbleSort(testArr));
        }
    }
}