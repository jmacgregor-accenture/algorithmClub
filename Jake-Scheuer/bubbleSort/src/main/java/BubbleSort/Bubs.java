package BubbleSort;

import java.util.List;

class Bubs {

    static List<Number> subject;

    Bubs(List<Number> listToSort){

        subject = listToSort;

    }

    void bblSort1() {

        int firstElementIndex = 0;
        int lastElementIndex = subject.size()-1;

        for (int i = firstElementIndex; i < lastElementIndex; i++) {

            for (int j = firstElementIndex; j < lastElementIndex; j++) {

                double left = subject.get(j).doubleValue();
                double right = subject.get(j+1).doubleValue();

                if(left > right) {

                    subject.set(j, right);
                    subject.set(j+1, left);

                }
            }
        }
    }

    void bblSort2() {

        int firstElementIndex = 0;
        int lastElementIndex = subject.size()-1;

        for (int i = firstElementIndex, last = lastElementIndex; i < lastElementIndex; i++, last--) {

            for (int j = firstElementIndex; j < last; j++) {


                double left = subject.get(j).doubleValue();
                double right = subject.get(j+1).doubleValue();

                if (left > right) {

                    subject.set(j, right);
                    subject.set(j+1, left);

                }
            }
        }
    }

    void bblSort3() {

        int firstElementIndex = 0;
        int lastElementIndex = subject.size()-1;

        boolean didSwap = true;

        while (didSwap) {

            didSwap = false;

            for (int i = firstElementIndex; i < lastElementIndex; i++) {

                double left = subject.get(i).doubleValue();
                double right = subject.get(i+1).doubleValue();


                if (left > right) {

                    didSwap = true;
                    subject.set(i, right);
                    subject.set(i+1, left);

                }
            }
            lastElementIndex--;
        }
    }
}
