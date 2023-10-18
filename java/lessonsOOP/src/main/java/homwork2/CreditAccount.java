package homwork2;


class CreditAccount extends AbstractBankAccount {     // Кредит

    public CreditAccount() {
        this.balance = 0;
    }
    public CreditAccount(int balance) {
        this.balance = 0;
    }
    @Override
    public void setTake(int take){  // Снятие с проверкой на положительные числа
        if(take > 0){
            this.balance = this.balance - take;
            this.balance = this.balance + this.balance / 100;
        }
        else{
            throw new IllegalArgumentException("Некорректная сумма");
        }

    }
    @Override
    public Integer getAmount(){    // Вывод баланса
        return balance;
    }

}
