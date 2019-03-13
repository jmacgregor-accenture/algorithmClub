import java.util.Collections;
import java.util.List;

public class BubbleSort {

    public int[] sort(int[] numbers) {
       boolean isSorting = true;
        while(isSorting){
            isSorting = false;
            for (int i = 1; i < numbers.length ; i++) {
                if (numbers[i-1] > numbers[i]) {
                    isSorting = true;
                    int toSwap = numbers[i - 1];
                    numbers[i - 1] = numbers[i];
                    numbers[i] = toSwap;
//                    System.out.println(Arrays.toString(numbers));
                }
            }
        }
        return numbers;
    }

    public List<Comparable> sortComparables(List<Comparable> objects){
        Collections.sort(objects);
        return objects;
    }
}
