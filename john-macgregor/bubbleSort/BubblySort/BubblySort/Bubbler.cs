namespace BubblySort
{
    public class Bubbler
    {
        public int[] Sort(params int[] numbersToSort)
        {
            var madeChange = false;

            do
            {
                madeChange = false;
                
                for (var pass = 0; pass < numbersToSort.Length - 1; pass++)
                {
                    var comparisonNumber = pass + 1;
                
                    var firstNumber = numbersToSort[pass];
                    var secondNumber = numbersToSort[comparisonNumber];

                    if (firstNumber > secondNumber)
                    {
                        numbersToSort[pass] = secondNumber;
                        numbersToSort[comparisonNumber] = firstNumber;
                        madeChange = true;
                    }
                }
            } while (madeChange);
            
            return numbersToSort;
        }
    }
}