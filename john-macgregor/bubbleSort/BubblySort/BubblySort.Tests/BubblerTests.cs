using System;
using Shouldly;
using Xunit;

namespace BubblySort.Tests
{
    public class BubblerTests
    {
        [Fact]
        public void WhenCallingSortWillReturnAnEnumerable()
        {
            var bubbler = new Bubbler();
            var testArray = new int[] {5, 6, 7};

            var result = bubbler.Sort(testArray);

            result.ShouldNotBeNull();
        }

        [Fact]
        public void WhenCallingSortWithTwoNumbersReturnsInCorrectOrder()
        {
            var bubbler = new Bubbler();
            var expectedArray = new int[] {5,7};

            var result = bubbler.Sort(7, 5);
            
            result.ShouldBe(expectedArray);
        }
        
        [Fact]
        public void WhenCallingSortWithThreeNumbersReturnsInCorrectOrder()
        {
            var bubbler = new Bubbler();
            var expectedArray = new int[] {5,7,8};

            var result = bubbler.Sort(7, 5, 8);
            
            result.ShouldBe(expectedArray);
        }
        
        [Fact]
        public void WhenCallingSortWithFourNumbersReturnsInCorrectOrder()
        {
            var bubbler = new Bubbler();
            var expectedArray = new int[] {1,2,3,4};

            var result = bubbler.Sort(4,3,1,2);
            
            result.ShouldBe(expectedArray);
        }
        
        [Fact]
        public void WhenCallingSortWithEightNumbersReturnsInCorrectOrder()
        {
            var bubbler = new Bubbler();
            var expectedArray = new int[] {1,2,3,4,5,6,7,8};

            var result = bubbler.Sort(4,3,5,8,1,2,7,6);
            
            result.ShouldBe(expectedArray);
        }
        
        [Fact]
        public void WhenCallingSortWithTwoLettersReturnsInCorrectOrder()
        {
            var bubbler = new Bubbler();
            var expectedArray = new [] {'A','a'};

            var result = bubbler.Sort('a','A');
            
            result.ShouldBe(expectedArray);
        }
    }
}