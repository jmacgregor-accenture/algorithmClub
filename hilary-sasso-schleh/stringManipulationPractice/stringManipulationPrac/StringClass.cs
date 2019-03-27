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
    }
}