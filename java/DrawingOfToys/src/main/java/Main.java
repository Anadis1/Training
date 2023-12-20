//Напишите проект для розыгрыша в магазине игрушек. Функционал должен
//содержать добавление новых игрушек и задания веса для выпадения игрушек.


public class Main {
    public static void main(String[] args) {
        ToyVendingMachine toyVendingMachine = new ToyVendingMachine();
        System.out.println("Колличество игрушек в автомате - " + toyVendingMachine.ToysInTheVendingMachine());
        toyVendingMachine.setTake(17);  // Загружаем игрушки в автомат
        System.out.println("Колличество игрушек в автомате - " + toyVendingMachine.ToysInTheVendingMachine());
        toyVendingMachine.theButtonForTheDrawing();     // Человек 1 нажимает на кнопку розыгрыша игрушек
        toyVendingMachine.theButtonForTheDrawing();     // Человек 2 нажимает на кнопку розыгрыша игрушек
        toyVendingMachine.theButtonForTheDrawing();     // Человек 3 нажимает на кнопку розыгрыша игрушек
        toyVendingMachine.theButtonForTheDrawing();     // Человек 4 нажимает на кнопку розыгрыша игрушек
        toyVendingMachine.theButtonForTheDrawing();     // Человек 5 нажимает на кнопку розыгрыша игрушек
        toyVendingMachine.theButtonForTheDrawing();     // Человек 6 нажимает на кнопку розыгрыша игрушек
        toyVendingMachine.theButtonForTheDrawing();     // Человек 7 нажимает на кнопку розыгрыша игрушек
        toyVendingMachine.theButtonForTheDrawing();     // Человек 8 нажимает на кнопку розыгрыша игрушек
        toyVendingMachine.theButtonForTheDrawing();     // Человек 9 нажимает на кнопку розыгрыша игрушек
        toyVendingMachine.theButtonForTheDrawing();     // Человек 10 нажимает на кнопку розыгрыша игрушек
    }
}
