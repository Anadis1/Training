package homwork1;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

// * 3. Создать CreditAccount. Пополнить его на X рублей. Снять с него Y рублей. Проверить, что на счету X - 1.01*Y рублей.

class CreditAccountTest {
    @Test
    void setPutTake(){
        CreditAccount creditAccount = new CreditAccount();
        int testPut = creditAccount.setPut(3000);
        int expectedGetAmount = 3000;
        Assertions.assertEquals(testPut, expectedGetAmount);
        int testTake = creditAccount.setTake(1000);
        int expectedGetAmount2 = -1010;
        Assertions.assertEquals(testTake, expectedGetAmount2);
    }
}