using System;

namespace BubbleSortAlg
{
    public class BubbleSort
    {
        public int[] Sort(int[] numArray)
        {
            bool unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (int i = 0; i < numArray.Length - 1; i++)
                {
                    int current = numArray[i];
                    int next = numArray[i + 1];
                    if (current > next)
                    {
                        unsorted = true;
                        numArray[i] = next;
                        numArray[i + 1] = current;
                    }
                }
            }

            return numArray;
        }
    }
}