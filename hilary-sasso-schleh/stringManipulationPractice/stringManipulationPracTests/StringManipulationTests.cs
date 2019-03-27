using System;
using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void CountWordsWithOneWordReturnsNumberOfWordsInInput()
        {
            string input = "Hello";

            int result = stringClass.CountWords(input);
            
            result.ShouldBe(1);
        }

        [Fact]
        public void CountWordsWithTwoWordsReturnsTwo()
        {
            string input = "Hello world";

            int result = stringClass.CountWords(input);
            
            result.ShouldBe(2);
        }

        [Fact]
        public void SplitStringWithSpaceReturnsTwoWords()
        {
            string input = "Hello world";

            List<string> result = stringClass.SplitString(input);
            
            result.Count.ShouldBe(2);
            result.Last().ShouldBe("world");
        }

        [Fact]
        public void CompareStringsReturnsTrueIfStringsAreIdentical()
        {
            string firstString = "Hi There";
            string secondString = "Hi There";

            bool result = stringClass.CompareStrings(firstString, secondString);
            
            result.ShouldBeTrue();
        }

        [Fact]
        public void CompareStringsReturnsFalseIfStringsAreNotIdentical()
        {
            string firstString = "hi There";
            string secondString = "Hi There";

            bool result = stringClass.CompareStrings(firstString, secondString);
            
            result.ShouldBeFalse();
        }
    }
}

