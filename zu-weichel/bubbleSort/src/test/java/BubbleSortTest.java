import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class BubbleSortTest {
    private int[] numbers;
    private BubbleSort bubbleSort;

    @Before
    public void setup(){
        bubbleSort = new BubbleSort();
        numbers = new int[]{4,3,2,1};

    }
    @Test
    public void bubbleSortcreates(){
        assertNotNull(bubbleSort);
    }
    @Test
    public void whenFirstNumberBiggerThanSecondSwap(){
        int [] sorted = bubbleSort.sort(numbers);
         assertTrue(sorted[0] < sorted[1]);
    }
    @Test
    public void firstNumberIsLowerThanLast(){
        int[] sorted = bubbleSort.sort(numbers);
        assertTrue(sorted[0] <sorted[sorted.length-1]);
    }

    @Test
    public void orderMoviesByRating(){
        List<Comparable> list = new ArrayList<>();
        list.add(new Movie("Rambo", 1982, 3.4));
        list.add(new Movie("Titanic", 1997, 4));
        list.add(new Movie("Toy Story", 1995, 4.3));

        assertEquals("Toy Story",bubbleSort.sortComparables(list).get(0).toString());
    }

    @Test
    public void orderMoviesByYear(){
        List<Movie> list = new ArrayList<>();
        list.add(new Movie("Rambo", 1982, 3.4));
        list.add(new Movie("Titanic", 1997, 4));
        list.add(new Movie("Toy Story", 1995, 4.3));
        YearComparator comparByYear = new YearComparator();

        Collections.sort(list, comparByYear);

        assertEquals("Titanic", list.get(0).toString());
    }

    @Test
    public void orderMoviesByName(){
        List<Movie> list = new ArrayList<>();
        list.add(new Movie("Rambo", 1982, 3.4));
        list.add(new Movie("Titanic", 1997, 4));
        list.add(new Movie("Toy Story", 1995, 4.3));
        NameComparator comapreByName = new NameComparator();

        Collections.sort(list, comapreByName);

        assertEquals("Rambo", list.get(0).toString());
        assertEquals("Titanic", list.get(1).toString());
    }
}
