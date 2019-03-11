namespace Sorter
{
    public class BubbleSorter
    {

        private static int[] inputArray;
        
        public int[] BubbleSort(int[] arr)
        {
            inputArray = arr;
            int swaps = 1;
            
            while (swaps > 0)
            {
                swaps = Sort();
            }

            return inputArray;
        }

        private int Sort()
        {
            int indexSwaps = 0;

            for (int i = 1; i < inputArray.Length; i++)
            {
                indexSwaps = IncrementSwaps(i, indexSwaps);
            }

            return indexSwaps;
        }

        private static int IncrementSwaps(int i, int indexSwaps)
        {
            if (SwapSuccessful(i))
            {
                indexSwaps++;
            }

            return indexSwaps;
        }

        private static bool SwapSuccessful(int i)
        {
            if (inputArray[i] < inputArray[i - 1])
            {
                SwapIndexes(i);

                return true;
            }

            return false;
        }

        private static void SwapIndexes(int i)
        {
            int tempCurrentIndex = inputArray[i];

            inputArray[i] = inputArray[i - 1];
            inputArray[i - 1] = tempCurrentIndex;
        }
    }
}