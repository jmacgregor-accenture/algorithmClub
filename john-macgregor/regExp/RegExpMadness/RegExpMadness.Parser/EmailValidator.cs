using System.Text.RegularExpressions;

namespace RegExpMadness.Parser
{
    public class EmailValidator
    {
        public bool Validate(string stringToValidate)
        {
            var expressionPattern = @"^(.+?)[\@](.+?)(\.[a-z]{3})$";

            return Regex.IsMatch(stringToValidate, expressionPattern);
        }
    }
}