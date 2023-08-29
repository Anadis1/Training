# Ягоды растут на круглой грядке, причём кусты высажены
# только по окружности. Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растёт N кустов.
# Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло различное число ягод — на i-ом кусте выросло a[i] ягод.
# В этом фермерском хозяйстве внедрена система автоматического сбора черники. Эта система состоит из управляющего модуля и нескольких
# собирающих модулей. Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с двух соседних с ним.
# Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, находясь
# перед некоторым кустом заданной во входном списке урожайности грядки.

import random

def berries():
    bush = int(input("Введите количество кустов --- "))
    listTemp = []
    for el in range(bush):
        temp = random.randrange(0, 10)
        listTemp.append(temp)
    print(f"Ягод на кустах --- {listTemp}")
    return listTemp

def sumBerries(arg):
    index = 0
    sumTemp = 0
    while index < 3:
        sumTemp = sumTemp + bushBerries[index]
        index += 1
    return sumTemp

bushBerries = berries()
bushBerries.append(bushBerries[0])
bushBerries.append(bushBerries[1])

sumMax = 0
sum = 0
while len(bushBerries) > 2:
    sum = sumBerries(bushBerries)
    if sumMax < sum:
        sumMax = sum
    del bushBerries[0]

print(sumMax)
