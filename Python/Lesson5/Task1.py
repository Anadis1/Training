#  посчитаем сумму всех чисел от 1 до N, N вводит юзер

def summa_rec(num, upper):
    # if num == 1:
    #     return 1
    # return num + summa_rec(num - 1 )
    if num == upper:
        return upper
    return num + summa_rec(num + 1, upper )

# процесс погружения (5 + (4 + (3 + (2 + ))))
# процесс всплытия (5 + ( 4 + 6 )) = 15
print(summa_rec(1, 5))