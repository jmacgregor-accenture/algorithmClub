
import org.junit.Test;

import java.util.Arrays;

import static org.junit.Assert.*;

public class BubbleSorterTest {

    @Test
    public void returnASortedArrayOfIntegers() {
        int[] testArray = new int[]{1, 2, 3, 4, 5};
        BubbleSorter bubbleSorter = new BubbleSorter();
        int[] sortedArray = bubbleSorter.sort(testArray);
        Arrays.sort(testArray);
        assertArrayEquals(testArray, sortedArray);
    }
}