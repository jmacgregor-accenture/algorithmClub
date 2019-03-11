namespace BubblySort
{
    public class Bubbler
    {
        public int[] Sort(params int[] numbersToSort)
        {
            var sortedNumbers = new int[numbersToSort.Length];
            var firstNumber = numbersToSort[0];
            var secondNumber = numbersToSort[1];

            if (firstNumber > secondNumber)
            {
                sortedNumbers[0] = secondNumber;
                sortedNumbers[1] = firstNumber;
            }
            else
            {
                sortedNumbers[0] = firstNumber;
                sortedNumbers[1] = secondNumber;
            }
            
            return sortedNumbers;
        }
    }
}