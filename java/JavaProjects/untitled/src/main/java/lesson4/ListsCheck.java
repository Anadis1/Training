package lesson4;

import java.util.ArrayList;
import java.util.Date;
import java.util.LinkedList;

/*
1) Замерьте время, за которое в ArrayList добавятся 10000 элементов.
2) Замерьте время, за которое в LinkedList добавятся 10000 элементов. Сравните с предыдущим.

 */
public class ListsCheck {
    public static void arrayListTime() {
        ArrayList<Integer> arrayList = new ArrayList<>();

//        System.out.println("Start date: " + startDate);
        for (int i = 0; i < 10000; i++) {
            arrayList.add(i);
        }
        Date startDate = new Date();
        for (int i = 0; i < arrayList.size(); i++) {
            arrayList.get(i);
        }
        Date endDate = new Date();
//        System.out.println("End date: " + endDate);
        long duration = endDate.getTime() - startDate.getTime();
        System.out.println("ArrayList: " + duration);
    }

    public static void linkedListTime() {
        LinkedList<Integer> linkedList = new LinkedList<>();

//        System.out.println("Start date: " + startDate);
        for (int i = 0; i < 10000; i++) {
            linkedList.add(i);
        }
        Date startDate = new Date();
        for (int i = 0; i < linkedList.size(); i++) {
            linkedList.get(i);
        }
        Date endDate = new Date();
//        System.out.println("End date: " + endDate);
        long duration = endDate.getTime() - startDate.getTime();
        System.out.println("LinkedList: " + duration);
    }
}