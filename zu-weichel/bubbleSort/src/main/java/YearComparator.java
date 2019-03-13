import java.util.Comparator;

public class YearComparator implements Comparator<Movie> {

    @Override
    public int compare(Movie m1, Movie m2) {
        return m2.getYear()-m1.getYear();
    }
}
