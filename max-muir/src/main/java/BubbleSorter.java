import java.util.Arrays;

public class BubbleSorter {

    public Integer[] sort(Integer[] unsortedArray) {
        boolean unsorted = true;
        Integer[] sortedArray = unsortedArray;
        while(unsorted){
            unsorted = false;
            for(int i = 0; i < sortedArray.length -1 ; i++){
                int currentItem = sortedArray[i];
                int nextItem = sortedArray[i+1];
                if(currentItem > nextItem){
                    unsorted = true;
                    sortedArray[i] = nextItem;
                    sortedArray[i+1] = currentItem;
                }
            }
        }
        return sortedArray;
    }
}
