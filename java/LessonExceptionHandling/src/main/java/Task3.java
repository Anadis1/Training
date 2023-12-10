import java.io.*;
import java.nio.file.Files;
import java.nio.file.Path;

//Создайте класс Счетчик, у которого есть метод add(), увеличивающий значение внутренней
//int переменной на 1. Сделайте так, чтобы с объектом такого типа можно было работать
//в блоке try-with-resources. Подумайте, что должно происходить при закрытии этого ресурса?
//Напишите метод для проверки, закрыт ли ресурс. При попытке вызвать add() у закрытого ресурса, должен выброситься IOException


//1. Создайте класс исключения, который будет выбрасываться при делении на 0. Исключение должно
//        отображать понятное для пользователя сообщение об ошибке.
//
//2. Создайте класс исключений, которое будет возникать при обращении к пустому элементу в
//        массиве ссылочного типа. Исключение должно отображать понятное для пользователя сообщение об ошибке.
//
//3. Создайте класс исключения, которое будет возникать при попытке открыть несуществующий файл.
//        Исключение должно отображать понятное для пользователя сообщение об ошибке.


//Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4. При подаче массива другого размера необходимо
//бросить исключение MyArraySizeException.
//
//1. Далее метод должен пройтись по всем элементам массива, преобразовать в int и просуммировать.
//Если в каком-то элементе массива преобразование не удалось (например, в ячейке лежит символ или
//текст вместо числа), должно быть брошено исключение MyArrayDataException с детализацией, в какой именно ячейке лежат неверные данные.
//2. В методе main() вызвать полученный метод, обработать возможные исключения MyArraySizeException и MyArrayDataException и
//вывести результат расчета (сумму элементов, при условии что подали на вход корректный массив).


public class Task3 {
    public static void main(String[] args) throws ZeroNoFiles {
        String[][] strings = {
                {"1", "1", "1", "1"},
                {"1", "a", "1", "1"},
                {"1", "1", "1", "1"},
                {"1", "1", "1", "1"}
        };
        try {
            System.out.println(sumArray(strings));

        } catch (MyArraySizeException | MyArrayDataException e){
            e.printStackTrace();
        }

//        rwLine(Path.of("pom.xml"), Path.of("pot.xml"));
//        Counter counter = new Counter();
//        counter.add();
//        counter.close();
//        counter.add();

//        fileReader.close();
//        fileReader = null;
//        String[] arrey = {"строка", null};
//        try {
//            FileReader fileReader = new FileReader("files.txt");
//            fileReader.read();
//            for (String s : arrey) {
//                System.out.println(s.length());
//            }
//            int num1 = 7 / 0;
//        } catch (ArithmeticException e) {
//            throw new ZeroExeption();
//        } catch (NullPointerException e) {
//            throw new ZeroNull();
//        } catch (IOException e) {
//            throw new ZeroNoFiles();
//        }


    }

    public static void rwLine(Path pathRead, Path pathWrite) throws IOException {
        try (BufferedReader in = Files.newBufferedReader(pathRead); BufferedWriter out = Files.newBufferedWriter(pathWrite)) {
            out.write(in.readLine());
        } finally {
        }
    }

    public static int sumArray(String[][] strings) throws MyArraySizeException, MyArrayDataException {
        int counter = 0;
        int row = strings.length;
        boolean isRect = true;

        for (String[] string : strings) {
            if (string.length != row) {
                isRect = false;
            }
        }
        if (!isRect) {
            throw new MyArraySizeException();
        }

        if (strings.length == strings[0].length) {

            for (int i = 0; i < strings.length; i++) {
                for (int j = 0; j < strings[i].length; j++) {
                    try {
                        counter += Integer.parseInt(strings[i][j]);
                    } catch (NumberFormatException e) {
                        throw new MyArrayDataException(i, j);
                    }
                }
            }
        }
        return counter;
    }
}