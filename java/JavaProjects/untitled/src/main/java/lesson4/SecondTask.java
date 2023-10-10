package lesson4;

import java.util.LinkedList;
import java.util.Scanner;

/*
Реализовать консольное приложение, которое:
Принимает от пользователя строку вида
text~num (ex: aaaa~13)
Нужно рассплитить строку по ~, сохранить text в связный список на позицию num.
Если введено print~num, выводит строку из позиции num в связном списке и удаляет её из списка.
 */
public class SecondTask {
    private String string;

    public void addToLinkedList() {
        LinkedList<String> list = new LinkedList<>();
        do {
            Scanner in = new Scanner(System.in);
            string = in.next();
            String[] splited = string.split("~"); // splited[0] = text/print; splited[1] = "number"
            int num = Integer.parseInt(splited[1]);
            if (!"print".equals(splited[0])) {
                if (list.size() < num) { // 'aaa'~2 - 1-ая итерация, 'bbb'~3 - 2-ая итерация
                    for (int i = list.size(); i < num * 2; i++) {
                        list.add(i,null);
                    }
                }
                list.set(num, splited[0]);
            } else {
                if (num <= list.size()) {
                    System.out.println("Исходный " + list);
                    System.out.println("Получили: " + list.get(num));
                    String remove = list.remove(num);
                    System.out.println("Удалили: " + remove);
                    System.out.println("Окончательный список" + list);
                }
            }
        } while (!"Q".equals(string)); //"quit"
    }
}