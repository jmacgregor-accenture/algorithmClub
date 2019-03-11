
import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;

import static org.junit.Assert.*;

public class BubbleSorterTest {

    static Random random = new Random();
    static Integer[] testValues;
    static Integer[] expectedvalues;

    @Before
    public void setUp() throws Exception {
        BubbleSorterTest.generateTestAndExpectedValues();
    }

    @Test
    public void returnASortedArrayOfIntegers() {
        BubbleSorter bubbleSorter = new BubbleSorter();

        Integer[] sortedArray = bubbleSorter.sort(testValues);
        Arrays.sort(expectedvalues);

        assertArrayEquals(expectedvalues, sortedArray);
    }


    private static void generateTestAndExpectedValues(){
        List<Integer> randomValues = new ArrayList<>();
        int arrayLength = random.nextInt(100);
        for(int i = 0; i < arrayLength; i++){
            randomValues.add(random.nextInt(100));
        }
        testValues = new Integer[randomValues.size()];
        testValues = randomValues.toArray(testValues);
        expectedvalues = new Integer[testValues.length];
        for(int i = 0; i < expectedvalues.length; i++){
            expectedvalues[i] = testValues[i];
        }
        Arrays.sort(expectedvalues);

    }
}