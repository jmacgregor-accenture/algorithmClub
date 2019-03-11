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
            int localSwaps = 0;

            for (int i = 1; i < arr.Length; i++){

                int tempCurrentIndex = arr[i];

                if (arr[i] < arr[i - 1])
                {
                    arr[i] = arr[i - 1];
                    arr[i - 1] = tempCurrentIndex;
                    
                    localSwaps++;
                }

            }

            return localSwaps;
        }

    }
}