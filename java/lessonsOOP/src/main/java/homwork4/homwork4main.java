package homwork4;

import java.util.ArrayList;

/**
 * Необходимо создать класс Box, описывающий коробку с фруктами. В одной коробке должны быть фрукты только одного типа.
 * У коробки должны быть методы:
 * 1. Метод добавления нового фрукта в коробку add(Fruit fruit)
 * 2. Метод подсчета суммарного веса коробки getWeight()
 * 3. Метод пересыпания фруктов одной коробки в другую move(Box box)
 * 4. * Реализовать итератор на коробке. То есть должно быть доступно написать foreach, который итерируется по фруктам в коробке.
 */
public class homwork4main {
    static class Box<T extends Fruit> {

        private ArrayList<T> fruits;
        private int weight;

        public Box(){
            this.fruits = new ArrayList<>();
        }

        public void add(T fruit) {
            fruits.add(fruit);
            this.weight += fruitWeight(fruit);
        }

        private int fruitWeight(T fruit){
            if (fruit instanceof Apple){
                return 1;
            }
            else if (fruit instanceof Orange){
                return 1;
            }
            else{
                return 0;
            }
        }

        public int getWeight() {
            return weight;
        }
    }

    static class Fruit {

        private int weight;

        public Fruit(int weight) {
            this.weight = weight;
        }

        public int getWeight() {
            return weight;
        }
    }

    static class Apple extends Fruit {
        public Apple() {
            super(1);
        }
    }

    static class GoldenApple extends Apple {
        public GoldenApple() {
            super();
        }
    }

    static class Orange extends Fruit {
        public Orange() {
            super(1);
        }
    }
    public static void main(String[] args) {
        Box<Apple> appleBox = new Box();
        System.out.println("Всего яблок в коробке --- " + appleBox.getWeight()); // 0

        appleBox.add(new Apple()); // Должно компилироваться
        appleBox.add(new Apple()); // Должно компилироваться
        System.out.println("Всего яблок в коробке --- " + appleBox.getWeight());
        //appleBox.add(new Orange(4)); // Не должно компилироваться!!!
        appleBox.add(new GoldenApple()); // Должно компилироваться
        System.out.println("Всего яблок в коробке --- " + appleBox.getWeight());

        Box<Orange> orangeBox = new Box();
        //orangeBox.add(new Apple(2)); // Не должно компилироваться!!!
        orangeBox.add(new Orange()); // Должно компилироваться
        System.out.println("Всего Апельсинов в коробке --- " + orangeBox.getWeight());

        Box<GoldenApple> goldenAppleBox = new Box();
        goldenAppleBox.add(new GoldenApple()); // Должно компилироваться
        //goldenAppleBox.add(new Apple(20)); // Не должно компилироваться!!!


        System.out.println("Всего золотых яблок в коробке --- " + goldenAppleBox.getWeight());
        System.out.println("Всего яблок в коробке --- " + appleBox.getWeight());
    }
}
