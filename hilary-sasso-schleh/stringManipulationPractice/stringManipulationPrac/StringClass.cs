using System.Collections.Generic;
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

        public List<string> SplitString(string input, char splitCharacter = ' ')
        {
            List<string> wordsInString = new List<string>();
            List<int> spaceIndices = new List<int>();

            var space = 0;
            var searchStart = 0;

            while (space != -1)
            {
                space = input.IndexOf(splitCharacter, searchStart);
                spaceIndices.Add(space);
                searchStart = space + 1;
            }

            var subStringStart = 0;
            
            for (var i = 0; i < spaceIndices.Count; i++)
            {
                var spaceIndex = spaceIndices[i];

                if (i == 0 && spaceIndex == -1)
                {
                    wordsInString.Add(input);
                }
                else if (i == spaceIndices.Count - 1)
                {
                    wordsInString.Add(input.Substring(subStringStart, input.Length - subStringStart));
                }
                else
                {
                    wordsInString.Add(input.Substring(subStringStart, spaceIndex));
                    subStringStart = spaceIndex + 1;
                }
                
            }

            return wordsInString;
        }

        public int CountWords(string input)
        {
            var splitString = SplitString(input);

            return splitString.Count;
        }
    }
}