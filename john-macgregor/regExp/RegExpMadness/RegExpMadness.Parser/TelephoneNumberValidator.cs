using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegExpMadness.Parser
{
    public class TelephoneNumberValidator
    {
        public bool Validate(string stringToValidate)
        {
            if (stringToValidate.Any(char.IsWhiteSpace))
            {
                return CheckStringCountryCode(stringToValidate);
            }

            if (stringToValidate.Contains('-'))
            {
                return CheckStringWithHyphen(stringToValidate);
            }

            return CheckStringNoHyphen(stringToValidate);
        }

        private bool CheckStringNoHyphen(string inputString)
        {
            
            switch (inputString.Length)
            {
                case 10:
                    return Regex.IsMatch(inputString, @"^[\d]{10}$");
                case 11:
                    return Regex.IsMatch(inputString, @"^[\d]{11}$");
                default:
                    return false;
            }
            
        }

        private bool CheckStringWithHyphen(string inputString)
        {
            var expressionPattern = @"^([\d]{3})-([\d]{3})-([\d]{4})$";

            return Regex.IsMatch(inputString, expressionPattern);
        }

        private bool CheckStringCountryCode(string inputString)
        {
            var expressionPattern = @"^([\d]{1,3}) ([\d]{3})-([\d]{3})-([\d]{4})$";

            return Regex.IsMatch(inputString, expressionPattern);
        }
    }
}