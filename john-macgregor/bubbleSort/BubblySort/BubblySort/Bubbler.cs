using System;
using System.Linq;

namespace BubblySort
{
    public class Bubbler
    {
        public T[] Sort<T>(params T[] itemsToSort)
        {
            return HandleIntArray(itemsToSort);
        }

        private T[] HandleIntArray<T>(T[] paramArray)
        {
            var typeTtoInt = new Converter<T,int>(input => (int)Convert.ChangeType(input, typeof(T)));
            var intToTypeT = new Converter<int, T>(input => (T)Convert.ChangeType(input, typeof(T)));
            
            var intArray = Array.ConvertAll(paramArray,typeTtoInt);

            var sortedArray = SortInts(intArray);
            
            return Array.ConvertAll(sortedArray,intToTypeT);
        }

        private int[] SortInts(int[] numbersToSort)
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