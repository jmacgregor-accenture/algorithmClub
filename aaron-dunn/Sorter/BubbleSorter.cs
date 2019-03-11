namespace Sorter
{
    public class BubbleSorter
    {

        public int[] BubbleSort(int[] arr)
        {
            int swaps = 1;
            
            while (swaps != 0)
            {
                swaps = Sort(arr);
            }

            return arr;
        }

        private int Sort(int[] arr)
        {
            int indexSwaps = 0;

            for (int i = 1; i < arr.Length; i++){

                if (SwapSuccessful(arr, i))
                {
                    indexSwaps++;
                }

            }

            return indexSwaps;
        }

        private static bool SwapSuccessful(int[] arr, int i)
        {
            if (arr[i] < arr[i - 1])
            {
                int tempCurrentIndex = arr[i];
            
                arr[i] = arr[i - 1];
                arr[i - 1] = tempCurrentIndex;

                return true;
            }

            return false;
        }
    }
}