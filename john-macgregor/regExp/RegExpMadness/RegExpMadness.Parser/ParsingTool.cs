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
                return true;
            }

            expressionPattern = @"^[\d]{11}$";

            isMatch = Regex.IsMatch(stringToValidate, expressionPattern);

            if (isMatch)
            {
                return true;
            }

            expressionPattern = @"^([\d]{3})-([\d]{3})-([\d]{4})$";
            
            isMatch = Regex.IsMatch(stringToValidate, expressionPattern);

            if (isMatch)
            {
                return true;
            }
            
            expressionPattern = @"^([\d]{1,3}) ([\d]{3})-([\d]{3})-([\d]{4})$";
            
            return Regex.IsMatch(stringToValidate, expressionPattern);
        }
    }
}