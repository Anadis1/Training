package homwork1;

public class BankAccount {      //Счет в банке
    private Integer balance;

    public BankAccount(){
        this.balance = 0;
    }
    public BankAccount(int balance){
        this.balance = balance;
    }
    public Integer getAmount(){    // Вывод баланса
        return balance;
    }
    public void setPut(int put){    // Пополнение с проверкой на положительные числа
        if (put > 0) {
            this.balance = this.balance + put;
        } else {
            throw new IllegalArgumentException("Некорректная сумма");
        }
    }
    public void setTake(int take){  // Снятие с проверкой на положительные числа
        if(take > 0){
            this.balance = this.balance - take;
        }
        else{
            throw new IllegalArgumentException("Некорректная сумма");
        }

    }
}