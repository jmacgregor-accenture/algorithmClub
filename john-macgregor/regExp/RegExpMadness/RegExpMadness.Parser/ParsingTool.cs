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
            else
            {
                expressionPattern = @"^[\d]{11}$";
                
                return Regex.IsMatch(stringToValidate, expressionPattern);
            }
            

        }
    }
}