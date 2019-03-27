using System.Xml;

namespace stringManipulationPracTests
{
    public class StringClass
    {
        public string PrintString(string input)
        {
            string defaultGreeting = "The String Entered Is: ";
            
            return defaultGreeting + input;
        }

        public int CountLength(string input)
        {
            int count = 0;

            foreach (var letter in input)
            {
                count++;
            }

            return count;
        }

        public string SeparateCharacters(string input)
        {
            string returnString = string.Empty;
            int inputLength = CountLength(input);

            for (var i = 0; i < inputLength; i++)
            {
                if (i == inputLength - 1)
                {
                    returnString += input[i];
                }
                else
                {
                    returnString += input[i] + " ";
                }
            }

            return returnString;
        }

        public string ReverseCharacters(string input)
        {
            string returnString = string.Empty;
            int inputLength = CountLength(input);

            for (var i = inputLength - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    returnString += input[i];
                }
                else
                {
                    returnString += input[i];
                }
            }
            return returnString;
        }
    }
}