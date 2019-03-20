using System.Text.RegularExpressions;

namespace RegExpMadness.Parser
{
    public class EmailValidator
    {
        public bool Validate(string stringToValidate)
        {
            var expressionPattern = @"[\@]";

            return Regex.IsMatch(stringToValidate, expressionPattern);
        }
    }
}