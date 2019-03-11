using System;
using System.ComponentModel;
using System.Linq;

namespace BubblySort
{
    public class Bubbler
    {
        public T[] Sort<T>(params T[] itemsToSort)
        {
            var type = typeof(T);

            if (type == typeof(string))
            {
                var array = new [] {"AAA", "BBB", "CCC"};
                return ConvertArrayToTypeT<T,string>(array);
            }

            if (type == typeof(int))
            {
                return HandleIntArray(itemsToSort);
            }

            return itemsToSort;
        }

        private T[] HandleIntArray<T>(T[] paramArray)
        {
            var intArray = ConvertArrayToTypeT<int,T>(paramArray);

            var sortedArray = SortInts(intArray);

            return ConvertArrayToTypeT<T,int>(sortedArray);
        }

        private T[] ConvertArrayToTypeT<T, TIn>(TIn[] arrayToConvert)
        {
            var converter = new Converter<TIn, T>(input => (T)Convert.ChangeType(input, typeof(T)));

            return Array.ConvertAll(arrayToConvert, converter);
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