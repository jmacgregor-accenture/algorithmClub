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

        [Fact]
        public void SortReturnsIntegersSortedInArrayWithRepeatedValues()
        {
            BubbleSort bubblesort = new BubbleSort();
            int[] numArray = {3, 1, 3, 5, 3};
            int[] expected = {1, 3, 3, 3, 5};
 
            int[] result = bubblesort.Sort(numArray);
         
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void SortReturnsCharactersInAlphabeticalOrder()
        {
            BubbleSort bubblesort = new BubbleSort();
            char[] charArray = {'b', 'a', 'c', 'd', 'e'};
            char[] expected = {'a', 'b', 'c', 'd', 'e'};
 
            char[] result = bubblesort.Sort(charArray);
         
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void SortReturnsStringsInAlphabeticalOrder()
        {
            BubbleSort bubblesort = new BubbleSort();
            String[] stringArray = {"bee", "aye", "cee", "dee", "eee"};
            String[] expected = {"aye", "bee", "cee", "dee", "eee"};
 
            String[] result = bubblesort.Sort(stringArray);
         
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void SortReturnsCharactersInAlphabeticalOrderCaseInsensitive()
        {
            BubbleSort bubblesort = new BubbleSort();
            char[] charArray = {'B', 'a', 'c', 'D', 'e'};
            char[] expected = {'a', 'B', 'c', 'D', 'e'};
 
            char[] result = bubblesort.Sort(charArray);
         
            Assert.Equal(expected, result);
        }
    }
}
