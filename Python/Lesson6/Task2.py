from random import randint


N = int(input("Введите длинну первого массива: "))
list_N = [randint(1,10) for _ in range(N)]
M = int(input("Введите длинну второго массива: "))
list_M = [randint(1,10) for _ in range(M)]

print(list_N)
print(list_M)

print([x for x in list_N if x not in set(list_M) ])