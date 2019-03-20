using System;
using System.Text.RegularExpressions;

namespace RegExpMadness.Parser
{
    public class ParsingTool
    {
        public bool ValidatePhoneNumber(string stringToValidate)
        {
            var isMatch = false;
            
            if (stringToValidate.Contains('-').Equals(false))
            {
                return CheckNoHyphenString(stringToValidate);
            }
            
            var expressionPattern = @"^([\d]{3})-([\d]{3})-([\d]{4})$";
            
            isMatch = Regex.IsMatch(stringToValidate, expressionPattern);

            if (isMatch)
            {
                return true;
            }
            
            expressionPattern = @"^([\d]{1,3}) ([\d]{3})-([\d]{3})-([\d]{4})$";
            
            return Regex.IsMatch(stringToValidate, expressionPattern);
        }

        private bool CheckNoHyphenString(string inputString)
        {
            var isMatch = false;
            var expressionPattern = string.Empty;
            
            switch (inputString.Length)
            {
                case 10:
                    expressionPattern = @"^[\d]{10}$";
                    break;
                case 11:
                    expressionPattern = @"^[\d]{11}$";
                    break;
                default:
                    return false;
            }

            return Regex.IsMatch(inputString, expressionPattern);
        }
    }
}