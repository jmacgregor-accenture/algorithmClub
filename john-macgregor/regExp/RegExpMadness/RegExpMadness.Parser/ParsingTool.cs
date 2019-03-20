using System;
using System.Text.RegularExpressions;

namespace RegExpMadness.Parser
{
    public class ParsingTool
    {
        public bool ValidatePhoneNumber(string stringToValidate)
        {
            var expressionPattern = @"^[\d]{10}$";
            
            var isMatch = Regex.IsMatch(stringToValidate, expressionPattern);

            if (isMatch)
            {
                return isMatch;
            }

            expressionPattern = @"^[\d]{11}$";

            isMatch = Regex.IsMatch(stringToValidate, expressionPattern);

            if (isMatch)
            {
                return true;
            }

            expressionPattern = @"^([\d]{3})-([\d]{3})-([\d]{4})$";
            
            return isMatch = Regex.IsMatch(stringToValidate, expressionPattern);
        }
    }
}