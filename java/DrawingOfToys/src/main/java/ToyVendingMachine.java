import java.util.concurrent.ThreadLocalRandom;

class ToyVendingMachine {
    private Integer toy;

    public ToyVendingMachine(){                 // Изначальное кол-во игрушек
        this.toy = 0;
    }

    public Integer ToysInTheVendingMachine(){   // Проверить сколько игрушек в автомате
        return toy;
    }

    public void setTake (int takeToys){         // Загрузить игрушки в автомат
        if (takeToys > 0) {
            this.toy = this.toy + takeToys;
        } else {
            throw new IllegalArgumentException("Число игрушек должно быть положительным");
        }
    }

    public void theButtonForTheDrawing(){       // Кнопка для розыгрыша игрушек
        int randomNumber = ThreadLocalRandom.current().nextInt(1, 11);
        if (this.toy <= 0){
            System.out.println("В автомате закончились игрушки, обратитесь к администратору магазина");
        } else { if (randomNumber > 5) {
            this.toy -= 1;
            System.out.println("Вы выйграли игрушку, ура! В автомате осталось - " + this.toy + " игрушек");
        } else {
            System.out.println("Вы ничего не выйграли, уфф :'(...  В автомате осталось - " + this.toy + " игрушек");
        }}
    }
}
