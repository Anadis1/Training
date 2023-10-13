package homwork1;

/*
 * 1. Создать класс "Счет в банке" - Account.                                                   +
 * У этого класса должно быть поле с текущим балансом на счете.                                 +
 * У этого класса должно быть 3 метода:                                                         +
 * - (put) Пополнить счет - принимат положительное число, увеличивает текущий баланс            +
 * - (take) Вывести средства - принимат положительное число, уменьшает текущий баланс           +
 * - (getAmount) Показать баланс - ничего не принимает, возвращает текущий баланс (getter)      +
 *
 * 2. Создать несколько наследников.                                                            +
 * - Кредитный счет (CreditAccount)                                                             +
 * Особенность: на каждое снятие нужно наложить комиссию в размере 1% от суммы снятия.          +
 * То есть, если снимаем 100 у.е., то снять нужно 101.                                          +
 * - Депозитный счет (DepositAccount) *
 * Особенность: нельзя снимать средства чаще, чем раз в месяц.
 * То есть, нужно завести поле с датой последнего снятия, и использовать его.
 * (Для дат лучше использовать LocalDate, пример в классе Dates в проекте урока)
 */

public class HomeworkMain {
    public static void main(String[] args) {
        BankAccount bankAccount = new BankAccount(47000);           //Счет в банке
        System.out.println("Баланс счета - " + bankAccount.getAmount());
        bankAccount.setPut(3000);       // Пополняем
        System.out.println("Баланс счета - " + bankAccount.getAmount());
        bankAccount.setTake(14000);      // Снятие
        System.out.println("Баланс счета - " + bankAccount.getAmount());

        System.out.println();

        CreditAccount creditAccount = new CreditAccount();                  //Кредит
        creditAccount.setTake(10000);    // взять в кредит
        System.out.println("Долг перед банком - " + creditAccount.getAmount());

    }



}
