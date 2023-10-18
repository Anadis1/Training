package homwork2;

public class BankAccount extends AbstractBankAccount   {//Счет в банке
    public BankAccount(){
        this.balance = 0;
    }

    public BankAccount(int balance){
        this.balance = balance;
    }
}

