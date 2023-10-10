import java.util.Objects;

public class MyObject {

    private int number;
    private String string;


    public MyObject(int number, String string) {
        this.number = number;
        this.string = string;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true; // в 8-ой джаве
        if (o == null || getClass() != o.getClass()) return false;
        MyObject myObject = (MyObject) o;
        return number == myObject.number && Objects.equals(string, myObject.string);
    }

//    @Override
//    public int hashCode() {
//        return Objects.hash(number, string);
//    }
}
