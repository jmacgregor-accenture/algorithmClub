using System;
using BubbleSortAlg;
using Xunit;

namespace BubbleSortAlgTests
{
    public class BubbleSortAlgTest1
    {
        [Fact]
        public void SortReturnsTwoIntegersOfArrayInAscendingOrder()
        {
           BubbleSort bubblesort = new BubbleSort();
           int[] numArray = {2, 1};
           int[] expected = {1, 2};
 
           int[] result = bubblesort.Sort(numArray);
         
           Assert.Equal(expected, result);
        }
        
        [Fact]
        public void SortReturnsFiveIntegersInArrayInAscendingOrder()
        {
            BubbleSort bubblesort = new BubbleSort();
            int[] numArray = {2, 1, 3, 5, 4};
            int[] expected = {1, 2, 3, 4, 5};
 
            int[] result = bubblesort.Sort(numArray);
         
            Assert.Equal(expected, result);
        }
        
        
        
    }
}
