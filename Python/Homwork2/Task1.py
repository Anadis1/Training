# На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом.
# Определите минимальное число монеток, которые нужно
# перевернуть, чтобы все монетки были повернуты вверх одной и той же стороной.
# Выведите минимальное количество монет, которые нужно перевернуть

import random

def minFlipOver(emblem, tails):
    if emblem < tails:
        return emblem
    elif emblem > tails:
        return tails
    else:
        return emblem

many = int(input("Сколько монеток лежит на столе? "))
emblem = random.randrange(0, many)
tails = many - emblem

print(f"На столе лежит {many} монет")
print(f"Из них гербом лежит {emblem} а решкой {tails}")
print(f"Достаточно перевернуть {minFlipOver(emblem, tails)} для достижения цели")


