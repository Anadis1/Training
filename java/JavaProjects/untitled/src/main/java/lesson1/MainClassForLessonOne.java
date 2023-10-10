package lesson1;

import java.util.Scanner;

public class MainClassForLessonOne {
    public static void main(String[] args) {
        System.out.println("Введите имя");
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        System.out.println("Добрый день"+" "+name);
    }

}