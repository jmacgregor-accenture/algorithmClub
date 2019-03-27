using System;
using Xunit;
using Shouldly;

namespace stringManipulationPracTests
{
    public class StringManipulationTests
    {
        [Fact]
        public void PrintStringReturnsInputStringPlusFormatting()
        {
            string input = "hello";
            string defaultGreeting = "The String Entered Is: ";
            StringClass stringClass = new StringClass();

            string result = stringClass.PrintString(input);
            
            result.ShouldBe( defaultGreeting + "hello");
        }

        [Fact]
        public void CountLengthReturnsNumberOfCharactersOfInputString()
        {
            string input = "parrot";
            
            StringClass stringClass = new StringClass();

            int result = stringClass.CountLength(input);

            result.ShouldBe(input.Length);
        }

        [Fact]
        public void SeparateCharactersReturnsExpandedString()
        {
            string input = "lizard";
            
            StringClass stringClass = new StringClass();

            string result = stringClass.SeparateCharacters(input);
            
            result.ShouldBe("l i z a r d");
        }

        [Fact]
        public void ReverseCharactersReturnsReversedString()
        {
            string input = "twister";
            
            StringClass stringClass = new StringClass();

            string result = stringClass.ReverseCharacters(input);
            
            result.ShouldBe("r e t s i w t");
        }
    }
}

