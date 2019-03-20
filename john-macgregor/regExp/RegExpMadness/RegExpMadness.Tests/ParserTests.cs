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

        [Theory]
        [InlineData("555-555-5555")]
        [InlineData("1 555-555-5555")]
        [InlineData("24 555-555-5555")]
        [InlineData("298 555-555-5555")]
        public void WhenPassedValidNumberStringWithDashesReturnsTrue(string testNumberString)
        {
            var parser = new ParsingTool();

            var result = parser.ValidatePhoneNumber(testNumberString);
            
            result.ShouldBe(true);
        }

        [Theory]
        [InlineData("aaaaaaaaaa")]
        [InlineData("555-5a5-5555")]
        [InlineData("555a555555")]
        public void WhenPassedStringWithNonDigitsReturnsTrue(string testNumberString)
        {
            var parser = new ParsingTool();

            var result = parser.ValidatePhoneNumber(testNumberString);
            
            result.ShouldBe(false);
        }
    }
}