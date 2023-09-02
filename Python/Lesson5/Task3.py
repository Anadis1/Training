# Задача №31. Решение в группах
# Последовательностью Фибоначчи называется
# последовательность чисел a0
# , a1
# , ..., an
# , ..., где
# a0
#  = 0, a1
#  = 1, ak
#  = ak-1 + ak-2 (k > 1).
# Требуется найти N-е число Фибоначчи
# Input: 7
# Output: 21

def num_fib(arg):
    if arg == 1:
        return 0
    elif arg == 2:
        return 1
    return num_fib(arg - 1) + num_fib(arg - 2)




num = int(input("Введите число N --- "))
print(num_fib(num))

