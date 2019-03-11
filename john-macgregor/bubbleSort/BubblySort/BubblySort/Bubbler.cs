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
                return HandleStringArray(itemsToSort);
            }

            if (type == typeof(int))
            {
                return HandleIntArray(itemsToSort);
            }

            if (type == typeof(char))
            {
                return HandleCharArray(itemsToSort);
            }

            return itemsToSort;
        }

        private T[] HandleIntArray<T>(T[] paramArray)
        {
            var intArray = ConvertArrayToTypeT<int,T>(paramArray);

            var sortedArray = SortInts(intArray);

            return ConvertArrayToTypeT<T,int>(sortedArray);
        }
        
        private T[] HandleStringArray<T>(T[] paramArray)
        {
            var stringArray = ConvertArrayToTypeT<string,T>(paramArray);

            var sortedArray = SortStrings(stringArray);

            return ConvertArrayToTypeT<T,string>(sortedArray);
        }

        private T[] ConvertArrayToTypeT<T, TIn>(TIn[] arrayToConvert)
        {
            var converter = new Converter<TIn, T>(input => (T)Convert.ChangeType(input, typeof(T)));

            return Array.ConvertAll(arrayToConvert, converter);
        }
        
        private T[] HandleCharArray<T>(T[] paramArray)
        {
            var charArray = ConvertArrayToTypeT<char,T>(paramArray);

            var sortedArray = SortChars(charArray);

            return ConvertArrayToTypeT<T,char>(sortedArray);
        }

        private string[] SortStrings(string[] itemsToSort)
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

                    var compareResult = string.Compare(firstNumber, secondNumber, StringComparison.InvariantCulture);

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
        
        private char[] SortChars(char[] itemsToSort)
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