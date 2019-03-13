import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

public class BubbleSortTest {
    private int[] numbers;

    @Before
    public void setup(){
        numbers = new int[]{4,3,2,1};
    }
    @Test
    public void bubbleSortcreates(){
        BubbleSort bubbleSort = new BubbleSort();
        assertNotNull(bubbleSort);
    }
    @Test
    public void whenFirstNumberBiggerThanSecondSwap(){
        BubbleSort bubbleSort = new BubbleSort();
        int [] sorted = bubbleSort.sort(numbers);
         assertTrue(sorted[0] < sorted[1]);
    }



}
