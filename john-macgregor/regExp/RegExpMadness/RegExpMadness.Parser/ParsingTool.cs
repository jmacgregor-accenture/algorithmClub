﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegExpMadness.Parser
{
    public class ParsingTool
    {
        public bool ValidatePhoneNumber(string stringToValidate)
        {
            
            if (stringToValidate.Contains('-').Equals(false))
            {
                return CheckStringNoHyphen(stringToValidate);
            }

            if (stringToValidate.Any(char.IsWhiteSpace))
            {
                return CheckStringCountryCode(stringToValidate);
            }
                
            return CheckStringWithHyphen(stringToValidate);
            
        }

        private bool CheckStringNoHyphen(string inputString)
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