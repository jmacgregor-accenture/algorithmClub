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

            result.ShouldBe(testArray);
        }
    }
}