public class MyArrayDataException extends Throwable {
    public MyArrayDataException(int i, int j) {
        super("Еще одна ошибка, строка: " + i + " столбец: " + j);
    }
}
