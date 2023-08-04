# Задание 3

number = int(input("Введите шестизначный номер билета ---> "))
temp = number
sumNumber1 = 0
sumNumber2 = 0
index = 0

if 99999 < number < 1000000:
    while index < 6:
        if index < 3:
            sumNumber1 = sumNumber1 + temp % 10
            temp = int(temp / 10)
            index += 1
        elif 2 < index < 6:
            sumNumber2 = sumNumber2 + temp % 10
            temp = int(temp / 10)
            index += 1
    if sumNumber1 == sumNumber2:
        print(f"{number} Счастливый билетик :)")
    else:
        print(f"{number} Билетик не счастливый :,(")
else:
    print("Номер должен быть шестизначным!")

