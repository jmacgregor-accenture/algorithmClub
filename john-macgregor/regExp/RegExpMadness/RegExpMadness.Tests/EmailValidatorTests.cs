using System.Runtime.InteropServices;
using RegExpMadness.Parser;
using Shouldly;
using Xunit;

namespace RegExpMadness.Tests
{
    public class EmailValidatorTests
    {
        [Fact]
        public void WhenValidatingGoodEmailReturnsTrue()
        {
            var testString = "john.macgregor@gmail.com";
            var validator = new EmailValidator();

            var result = validator.Validate(testString);
            
            result.ShouldBe(true);
        }

        [Fact]
        public void WhenValidatingJustAtSymbolReturnsFalse()
        {
            var testString = "@";
            var validator = new EmailValidator();

            var result = validator.Validate(testString);
            
            result.ShouldBe(false);
        }

        [Fact]
        public void WhenValidatingMissingDomainReturnsFalse()
        {
            var testString = "john@";
            var validator = new EmailValidator();

            var result = validator.Validate(testString);
            
            result.ShouldBe(false);
        }

        [Theory]
        [InlineData("john@gmail")]
        [InlineData("john@gmail.")]
        [InlineData("john@gmail.co")]
        [InlineData("john@gmail.comm")]
        public void WhenValidatingMissingTopLevelDomainReturnsFalse(string testString)
        {
            var validator = new EmailValidator();

            var result = validator.Validate(testString);
            
            result.ShouldBe(false);
        }
    }
}