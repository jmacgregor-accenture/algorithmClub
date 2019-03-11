import java.util.Arrays;

public class BubbleSorter {

    public Integer[] sort(Integer[] intArray) {
        boolean unsorted = true;
        while(unsorted){
            unsorted = false;
            for(int i = 0; i < intArray.length -1 ; i++){
                int currentItem = intArray[i];
                int nextItem = intArray[i+1];
                if(currentItem > nextItem){
                    unsorted = true;
                    intArray[i] = nextItem;
                    intArray[i+1] = currentItem;
                }
            }
        }
        return intArray;
    }
}
