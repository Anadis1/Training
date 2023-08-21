# Требуется вывести все целые степени двойки (т.е. числа вида 2^k), не превосходящие числа N.

number = int(input("Введите число ---> "))
variable = 1
print(variable, end = " ")
while variable < number:
    variable = variable * 2
    if variable < number:
        print(variable, end = " ")
