package homwork2;

public abstract class AbstractBankAccount implements Account {
    public Integer balance;

    public AbstractBankAccount(){
        this.balance = 0;
    }
    public AbstractBankAccount(int balance){
        this.balance = balance;
    }
    public Integer getAmount(){    // Вывод баланса
        return balance;
    }

    @Override
    public void gAmount() {
        System.out.println(balance);
    }

    @Override
    public void Put(double amount) {
        if (amount > 0) {
            this.balance = (int) (this.balance + amount);
        } else {
            throw new IllegalArgumentException("Некорректная сумма");
        }

    }

    @Override
    public void Take(double amount) {
        if(amount > 0){
            this.balance = (int) (this.balance - amount);
        }
        else{
            throw new IllegalArgumentException("Некорректная сумма");
        }

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
