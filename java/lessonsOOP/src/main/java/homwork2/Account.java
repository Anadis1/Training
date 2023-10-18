package homwork2;

public interface Account{


    void gAmount(); //получение текущего баланса

    void Put(double amount); //пополнить счет

    void Take(double amount); //снять средства со счета
}
