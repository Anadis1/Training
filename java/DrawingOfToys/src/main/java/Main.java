//Напишите проект для розыгрыша в магазине игрушек. Функционал должен
//содержать добавление новых игрушек и задания веса для выпадения игрушек.


public class Main {
    public static void main(String[] args) {
        ToyVendingMachine toyVendingMachine = new ToyVendingMachine();
        System.out.println("Колличество игрушек в автомате - " + toyVendingMachine.ToysInTheVendingMachine());
        toyVendingMachine.setTake(17);  // Загружаем игрушки в автомат
        System.out.println("Колличество игрушек в автомате - " + toyVendingMachine.ToysInTheVendingMachine());
        toyVendingMachine.theButtonForTheDrawing();     // Человек 1 нажимает на кнопку розыгрыша игрушек
    }
}
