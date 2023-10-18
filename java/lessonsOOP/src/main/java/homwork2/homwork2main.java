package homwork2;

/**
 * 1. Класс Account превратить в интерфейс с методами:  +
 * # double getAmount() - получение текущего баланса    +
 * # void put(double amount) - пополнить счет           +
 * # void take(double amount) - снять средства со счета +
 *
 * 2. Создать базовый абстрактный класс AbstractAccount, в котором будет общая часть: +
 * # поле с балансом +
 * # конструктор, который принимает начальное значение баланса +
 * # реализация всех методов +
 *
 * 3. Добавить еще один класс FixedAmountAccount с особенностью: методы put, take НЕ изменяют баланс. +
 */


public class homwork2main {

    public static void main (String[] args) {
        BankAccount bankAccount = new BankAccount(47000);            //Счет в банке
        bankAccount.gAmount();
        bankAccount.Put(3000);      // Пополнение
        bankAccount.gAmount();
        bankAccount.Take(14000);    // Снятие
        bankAccount.gAmount();

        System.out.println();

        CreditAccount creditAccount = new CreditAccount();                  //Кредит
        creditAccount.setTake(10000);    // взять в кредит
        System.out.println("Долг перед банком: " + creditAccount.getAmount());

        System.out.println();

        FixedAmountAccount fixedAmountAccount = new FixedAmountAccount(1000);
        System.out.println("Зафиксированное количество средств на счете: " + fixedAmountAccount.getAmount());
        fixedAmountAccount.setPut(3000);
        fixedAmountAccount.setTake(30000000);
        System.out.println("После снятия и пополнения: " + fixedAmountAccount.getAmount());

    }



}