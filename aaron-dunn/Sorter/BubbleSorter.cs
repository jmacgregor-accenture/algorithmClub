namespace Sorter
{
    public class BubbleSorter
    {

        private static int[] _inputArray;
        
        public int[] BubbleSort(int[] arr)
        {
            _inputArray = arr;
            int swaps = 1;
            
            while (swaps > 0)
            {
                swaps = Sort();
            }

            return _inputArray;
        }

        private int Sort()
        {
            int indexSwapCounter = 0;

            for (int i = 1; i < _inputArray.Length; i++)
            {
                indexSwapCounter = IncrementSwapCounter(i, indexSwapCounter);
            }

            return indexSwapCounter;
        }

        private static int IncrementSwapCounter(int i, int indexSwapCounter)
        {
            if (SwapSuccessful(i))
            {
                indexSwapCounter++;
            }

            return indexSwapCounter;
        }

        private static bool SwapSuccessful(int i)
        {
            if (_inputArray[i] < _inputArray[i - 1])
            {
                SwapIndexes(i);

                return true;
            }

            return false;
        }

        private static void SwapIndexes(int i)
        {
            int tempCurrentIndex = _inputArray[i];

            _inputArray[i] = _inputArray[i - 1];
            _inputArray[i - 1] = tempCurrentIndex;
        }
    }
}