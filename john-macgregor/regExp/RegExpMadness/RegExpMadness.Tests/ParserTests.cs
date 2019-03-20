using System;
using RegExpMadness.Parser;
using Shouldly;
using Xunit;

namespace RegExpMadness.Tests
{
    public class ParserTests
    {
        [Fact]
        public void WhenPassedTenNumberReturnsTrue()
        {
            var testNumberString = "5555555555";
            var parser = new ParsingTool();

            var result = parser.ValidatePhoneNumber(testNumberString);

            result.ShouldBe(true);
        }

        [Theory]
        [InlineData("55555555555")]
        [InlineData("5555555")]
        public void WhenPassedNumbersOutsideLengthRangeReturnsFalse(string testNumberString)
        {
            var parser = new ParsingTool();

            var result = parser.ValidatePhoneNumber(testNumberString);
            
            result.ShouldBe(false);
        }
    }
}