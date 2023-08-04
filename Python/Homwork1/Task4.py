n = int(input("Введите длину шоколадки ---> "))
m = int(input("Введите ширину шоколадки---> "))
slices = int(input("колько долек вы хотите отломать? ---> "))
slicesOfEverything = n * m
if slices % n == 0 or slices % m == 0 or slices < slicesOfEverything:
    print("Можно отломать за один раз")
else:
    print("Не получится отломать за один раз")


