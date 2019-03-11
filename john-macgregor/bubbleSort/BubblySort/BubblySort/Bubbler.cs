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
                return HandleCompareSort(itemsToSort);
            }

            if (type == typeof(int))
            {
                return HandleGreaterThanSort(itemsToSort);
            }

            if (type == typeof(char))
            {
                return HandleGreaterThanSort(itemsToSort);
            }

            return itemsToSort;
        }

        private T[] HandleGreaterThanSort<T>(T[] paramArray)
        {
            var intArray = ConvertArrayToTypeT<int,T>(paramArray);

            var sortedArray = GreaterThanSort(intArray);

            return ConvertArrayToTypeT<T,int>(sortedArray);
        }
        
        private T[] HandleCompareSort<T>(T[] paramArray)
        {
            var stringArray = ConvertArrayToTypeT<string,T>(paramArray);

            var sortedArray = CompareSort(stringArray);

            return ConvertArrayToTypeT<T,string>(sortedArray);
        }

        private T[] ConvertArrayToTypeT<T, TIn>(TIn[] arrayToConvert)
        {
            var converter = new Converter<TIn, T>(input => (T)Convert.ChangeType(input, typeof(T)));

            return Array.ConvertAll(arrayToConvert, converter);
        }

        private string[] CompareSort(string[] itemsToSort)
        {
            var madeChange = false;

            do
            {
                madeChange = false;
                
                for (var pass = 0; pass < itemsToSort.Length - 1; pass++)
                {
                    var comparisonNumber = pass + 1;
                
                    var firstNumber = itemsToSort[pass];
                    var secondNumber = itemsToSort[comparisonNumber];

                    var compareResult = string.Compare(firstNumber, secondNumber, 
                        StringComparison.InvariantCulture);

                    if (compareResult > 0)
                    {
                        itemsToSort[pass] = secondNumber;
                        itemsToSort[comparisonNumber] = firstNumber;
                        madeChange = true;
                    }
                }
                
            } while (madeChange);
            
            return itemsToSort;
        }

        private int[] GreaterThanSort(int[] itemsToSort)
        {
            var madeChange = false;

            do
            {
                madeChange = false;
                
                for (var pass = 0; pass < itemsToSort.Length - 1; pass++)
                {
                    var comparisonNumber = pass + 1;
                
                    var firstNumber = itemsToSort[pass];
                    var secondNumber = itemsToSort[comparisonNumber];
                    
                    if (firstNumber > secondNumber)
                    {
                        itemsToSort[pass] = secondNumber;
                        itemsToSort[comparisonNumber] = firstNumber;
                        madeChange = true;
                    }
                }
                
            } while (madeChange);
            
            return itemsToSort;
        }
    }
}