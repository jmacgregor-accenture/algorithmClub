
import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;

import static org.junit.Assert.*;

public class BubbleSorterTest {

    static Random random = new Random();
    static Integer[] intTestValues;
    static Integer[] intExpectedValues;
    static Character[] charTestValues;
    static Character[] charExpectedValues;

    @Before
    public void setUp()  {
        BubbleSorterTest.generateTestAndExpectedValues();
    }

    @Test
    public void sorterReturnsAnAscendingSortedArrayOfIntegers() {

        Integer[] sortedArray = BubbleSorter.sort(intTestValues);
        Arrays.sort(intExpectedValues);

        assertArrayEquals(intExpectedValues, sortedArray);
    }

    @Test
    public void sorterReturnsAnAlphabeticallySortedArrayOfChars() {

        Character[] sortedArray = BubbleSorter.sort(charTestValues);

        assertArrayEquals(charExpectedValues, sortedArray );
    }


    private static void generateTestAndExpectedValues(){
        List<Integer> randomIntValues = new ArrayList<>();
        List<Character> randomCharValues = new ArrayList<>();
        int arrayLength = random.nextInt(100);
        for(int i = 0; i < arrayLength; i++){
            randomIntValues.add(random.nextInt(100));
            randomCharValues.add((char)(random.nextInt(51) + 'a'));
        }
        intTestValues = new Integer[randomIntValues.size()];
        intTestValues = randomIntValues.toArray(intTestValues);
        charTestValues = new Character[randomIntValues.size()];
        charTestValues = randomCharValues.toArray(charTestValues);
        intExpectedValues = new Integer[intTestValues.length];
        charExpectedValues = new Character[charTestValues.length];
        for(int i = 0; i < intExpectedValues.length; i++){
            intExpectedValues[i] = intTestValues[i];
            charExpectedValues[i] = charTestValues[i];
        }

        Arrays.sort(intExpectedValues);
        Arrays.sort(charExpectedValues);

    }
}