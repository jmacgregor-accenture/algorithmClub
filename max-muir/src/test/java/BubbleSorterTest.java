
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
    public void setUp()  {
        BubbleSorterTest.generateTestAndExpectedValues();
    }

    @Test
    public void sorterReturnsAnAscendingSortedArrayOfIntegers() {

        Integer[] sortedArray = BubbleSorter.sort(testValues);
        Arrays.sort(expectedvalues);

        assertArrayEquals(expectedvalues, sortedArray);
    }

    @Test
    public void sorterReturnsAnAlphabeticallySortedArrayOfChars() {
        Character[] charTestValues = {'c', 'd', 'b', 'a', 'e', 'f'};
        Character[] charExpectedValues = {'a', 'b', 'c', 'd', 'e', 'f'};

        Character[] sortedArray = BubbleSorter.sort(charTestValues);

        assertArrayEquals(charExpectedValues, charTestValues );
    }

    @Test
    public void sorterReturnsAnAlphabeticallySortedArrayOfCharsOfDifferentCase() {
        Character[] charTestValues = {'c', 'D', 'B', 'a', 'e', 'f'};
        Character[] charExpectedValues = {'a', 'B', 'c', 'D', 'e', 'f'};

        Character[] sortedArray = BubbleSorter.sort(charTestValues);

        assertArrayEquals(charExpectedValues, charTestValues );
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