# Задание 1

number = int(input("Введите число ---> "))
sumNumber = 0
while number != 0:
    sumNumber = sumNumber + number % 10
    number = int(number / 10)

print(f"Сумма цифр в числе - {int(sumNumber)}")
