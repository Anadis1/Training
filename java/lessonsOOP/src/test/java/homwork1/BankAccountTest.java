package homwork1;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

/**
 * Протестировать классы Account, CreditAccount из ДЗ #1.
 *
 * 1. Создать Account. Пополнить его на X рублей. Проверить, что на счету X рублей.
 * 2. Создать Account. Пополнить его на X рублей. Снять с него Y рублей. Проверить, что на счету X-Y рублей.
 * 3. Создать CreditAccount. Пополнить его на X рублей. Снять с него Y рублей. Проверить, что на счету X - 1.01*Y рублей.
 * 4. ** Протестировать DepositAccount. Тест-кейсы придумать самостоятельно.
 *
 * Примерный код:
 * Account testObject = new Account();
 * testObject.put(10);
 * Assertions.assertEquals(10, testObject.getAmount());
 *
 */

class BankAccountTest {
    @Test
    void setPut(){
        BankAccount bankAccount = new BankAccount(0);
        int testPut = bankAccount.setPut(3000);
        int expectedGetAmount = 3000;

        Assertions.assertEquals(testPut, expectedGetAmount);

    }

    @Test
    void setPutTake(){
        BankAccount bankAccount = new BankAccount(0);
        int testPut = bankAccount.setPut(3000);
        int expectedGetAmount = 3000;
        Assertions.assertEquals(testPut, expectedGetAmount);
        int testTake = bankAccount.setTake(1000);
        int expectedGetAmount2 = 2000;
        Assertions.assertEquals(testTake, expectedGetAmount2);
    }
}