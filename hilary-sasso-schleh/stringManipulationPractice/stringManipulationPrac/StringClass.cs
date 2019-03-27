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

            for (var i = 0; i < CountLength(input); i++)
            {
                if (i == CountLength(input) - 1)
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
    }
}