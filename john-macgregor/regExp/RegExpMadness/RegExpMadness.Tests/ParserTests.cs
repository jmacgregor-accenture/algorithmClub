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

        [Fact]
        public void WhenPassedElevenNumbersReturnsFalse()
        {
            var testNumberString = "55555555555";
            var parser = new ParsingTool();

            var result = parser.ValidatePhoneNumber(testNumberString);
            
            result.ShouldBe(false);
        }
    }
}