using System;
using RegExpMadness.Parser;
using Shouldly;
using Xunit;

namespace RegExpMadness.Tests
{
    public class ParserTests
    {
        [Theory]
        [InlineData("55555555555")]
        [InlineData("5555555555")]
        public void WhenPassedValidNumberLengthReturnsTrue(string testNumberString)
        {
            var parser = new ParsingTool();

            var result = parser.ValidatePhoneNumber(testNumberString);

            result.ShouldBe(true);
        }

        [Theory]
        [InlineData("555555555555")]
        [InlineData("5555555")]
        public void WhenPassedNumbersOutsideLengthRangeReturnsFalse(string testNumberString)
        {
            var parser = new ParsingTool();

            var result = parser.ValidatePhoneNumber(testNumberString);
            
            result.ShouldBe(false);
        }

        [Fact]
        public void WhenPassedValidNumberStringWithDashesReturnsTrue()
        {
            var testNumberString = "555-555-5555";
            var parser = new ParsingTool();

            var result = parser.ValidatePhoneNumber(testNumberString);
            
            result.ShouldBe(true);
        }
    }
}