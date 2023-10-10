package lesson1;

public class task2 {
    public static void main(String[] args) {
        int[] list1 = new int[] {1, 1, 0, 1, 1, 1};
        int num = 0;
        int max = 0;
        for (int i = 0; i < list1.length; i++) {
            if(list1[i] == 1) {
                num++;
            }
            if(max < num) {
                max = num;
            }
            if(list1[i] == 0) {
                num = 0;
            }
        }
        System.out.println(max);
    }
}
