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
      
           int[] numArray = {2, 1};
           int[] expected = {1, 2};
 
           int[] result = BubbleSort.Sort(numArray);
         
           Assert.Equal(expected, result);
        }
        
        [Fact]
        public void SortReturnsFiveIntegersInArrayInAscendingOrder()
        {

            int[] numArray = {2, 1, 3, 5, 4};
            int[] expected = {1, 2, 3, 4, 5};
 
            int[] result = BubbleSort.Sort(numArray);
         
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SortReturnsIntegersSortedInArrayWithRepeatedValues()
        {
            int[] numArray = {3, 1, 3, 5, 3};
            int[] expected = {1, 3, 3, 3, 5};
 
            int[] result = BubbleSort.Sort(numArray);
         
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void SortReturnsCharactersInAlphabeticalOrder()
        {

            char[] charArray = {'b', 'a', 'c', 'd', 'e'};
            char[] expected = {'a', 'b', 'c', 'd', 'e'};
 
            char[] result = BubbleSort.Sort(charArray);
         
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void SortReturnsStringsInAlphabeticalOrder()
        {

            string[] stringArray = {"bee", "aye", "cee", "dee", "eee"};
            string[] expected = {"aye", "bee", "cee", "dee", "eee"};
 
            string[] result = BubbleSort.Sort(stringArray);
         
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void SortReturnsCharactersInAlphabeticalOrderCaseInsensitive()
        {

            char[] charArray = {'B', 'a', 'c', 'D', 'e'};
            char[] expected = {'a', 'B', 'c', 'D', 'e'};
 
            char[] result = BubbleSort.Sort(charArray);
         
            Assert.Equal(expected, result);
        }
    }
}
