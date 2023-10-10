public class Main {
    public static void main(String[] args) {

//        FirstTask firstTask = new FirstTask(6, 'b', 'm');
//        firstTask.getResult();

//        SecondTask secondTask = new SecondTask();
//        secondTask.getUniqSequence();

        StringBuilder stringBuilder = new StringBuilder("ab");
        StringBuilder reversed = new StringBuilder(stringBuilder.reverse());
        boolean equals = stringBuilder.toString().equals(reversed.toString());
        System.out.println(equals);







        StringBuilder first = new StringBuilder("string");
        StringBuilder second = new StringBuilder(first.reverse());
        boolean equals1 = first.toString().equals(second.toString());
    }
}