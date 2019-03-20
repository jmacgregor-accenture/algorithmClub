using System;
using System.Text.RegularExpressions;

namespace RegExpMadness.Parser
{
    public class ParsingTool
    {
        public bool ValidatePhoneNumber(string stringToValidate)
        {
            var expressionPattern = @"[\d]";

            return Regex.IsMatch(stringToValidate, expressionPattern);
        }
    }
}