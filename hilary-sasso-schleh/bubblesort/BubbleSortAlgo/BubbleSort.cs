using System;

namespace BubbleSortAlg
{
    public class BubbleSort
    {
        public int[] Sort(int[] valueArray)
        {
            var unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (var i = 0; i < valueArray.Length - 1; i++)
                {
                    var current = valueArray[i];
                    var next = valueArray[i + 1];
                    if (current <= next) continue;
                    unsorted = true;
                    valueArray[i] = next;
                    valueArray[i + 1] = current;
                }
            }
            return valueArray;
        }
        
        public char[] Sort(char[] valueArray)
        {
            var unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (var i = 0; i < valueArray.Length - 1; i++)
                {
                    var current = valueArray[i];
                    var next = valueArray[i + 1];
                    if (Char.ToLower(current) <= Char.ToLower(next)) continue;
                    unsorted = true;
                    valueArray[i] = next;
                    valueArray[i + 1] = current;
                }
            }
            return valueArray;
        }
        
        public string[] Sort(string[] valueArray)
        {
            var unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (var i = 0; i < valueArray.Length - 1; i++)
                {
                    var current = valueArray[i];
                    var next = valueArray[i + 1];
                    if (String.Compare(current, next) < 0) continue;
                    unsorted = true;
                    valueArray[i] = next;
                    valueArray[i + 1] = current;
                }
            }
            return valueArray;
        }
    }
}