using System;
using RegExpMadness.Parser;
using Shouldly;
using Xunit;

namespace RegExpMadness.Tests
{
    public class ParserTests
    {
        [Fact]
        public void WhenPassedOneNumberReturnsTrue()
        {
            var testNumberString = "5";
            var parser = new ParsingTool();

            var result = parser.ValidatePhoneNumber(testNumberString);

            result.ShouldBe(true);
        }
    }
}