import java.util.Arrays;

public class BubbleSorter {

    public static Integer[] sort(Integer[] intArray) {
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

    public static Character[] sort(Character[] charArray) {
        boolean unsorted = true;
        while(unsorted){
            unsorted = false;
            for(int i = 0; i < charArray.length -1 ; i++){
                char currentItem = charArray[i];
                char nextItem = charArray[i+1];
                if(Character.toLowerCase(currentItem) > Character.toLowerCase(nextItem)){
                    unsorted = true;
                    charArray[i] = nextItem;
                    charArray[i+1] = currentItem;
                }
            }
        }
        return charArray;
    }
}
