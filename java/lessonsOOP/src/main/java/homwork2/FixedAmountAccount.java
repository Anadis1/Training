package homwork2;

public class FixedAmountAccount extends AbstractBankAccount {
    public FixedAmountAccount() {
        this.balance = 0;
    }
    public FixedAmountAccount(int balance){
        this.balance = balance;
    }
    @Override
    public void setPut(int put){    // Пополнение с проверкой на положительные числа
        if (put > 0) {
        } else {
            throw new IllegalArgumentException("Некорректная сумма");
        }
    }
    @Override
    public void setTake(int take){  // Снятие с проверкой на положительные числа
        if(take > 0){
        }
        else{
            throw new IllegalArgumentException("Некорректная сумма");
        }

    }
}
