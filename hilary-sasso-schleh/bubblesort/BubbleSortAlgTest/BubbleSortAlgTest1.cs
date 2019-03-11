using System;
using BubbleSortAlg;
using Xunit;

namespace BubbleSortAlgTests
{
    public class BubbleSortAlgTest1
    {
        [Fact]
        public void SortReturnsListofIntegersInAscendingOrder()
        {
           BubbleSort bubblesort = new BubbleSort();
           int[] numArray = {2, 1};
           int[] expected = {1, 2};
 
           int[] result = bubblesort.Sort(numArray);
         
           Assert.Equal(expected, result);
           
        }
    }
}
