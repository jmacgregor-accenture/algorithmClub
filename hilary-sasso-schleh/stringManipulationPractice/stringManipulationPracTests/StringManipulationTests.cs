using System;
using Xunit;
using Shouldly;

namespace stringManipulationPracTests
{
    public class StringManipulationTests
    {
        private StringClass stringClass = new StringClass();
        
        [Fact]
        public void PrintStringReturnsInputStringPlusFormatting()
        {
            string input = "hello";
            string defaultGreeting = "The String Entered Is: ";

            string result = stringClass.PrintString(input);
            
            result.ShouldBe( defaultGreeting + "hello");
        }

        [Fact]
        public void CountLengthReturnsNumberOfCharactersOfInputString()
        {
            string input = "parrot";
      
            int result = stringClass.CountLength(input);

            result.ShouldBe(input.Length);
        }

        [Fact]
        public void SeparateCharactersReturnsExpandedString()
        {
            string input = "lizard";

            string result = stringClass.SeparateCharacters(input);
            
            result.ShouldBe("l i z a r d");
        }

        [Fact]
        public void ReverseCharactersReturnsReversedString()
        {
            string input = "twister";

            string result = stringClass.ReverseCharacters(input);
            
            result.ShouldBe("retsiwt");
        }

        [Fact]
        public void WeDecideToReverseAndExpandReturnString()
        {
            string input = "topsyturvy";

            string reversed = stringClass.ReverseCharacters(input);
            string endResult = stringClass.SeparateCharacters(reversed);

            endResult.ShouldBe("y v r u t y s p o t");
        }
        
       
    }
}

