# Хакер Василий получил доступ к классному журналу и
# хочет заменить все свои минимальные оценки на
# максимальные. Напишите программу, которая
# заменяет оценки Василия, но наоборот: все
# максимальные – на минимальные.
# Input: 5 -> 1 3 3 3 4
# Output: 1 3 3 3 1

# def maxS(arg):
#     temp = 0
#     for el in arg:
#         if el > temp:
#             temp = el
#     return temp
#
# def minS(arg):
#     temp = arg[0]
#     for el in arg:
#         if el < temp:
#             temp = el
#     return temp
#
# def rec(arg, min, max):
#     i = 0
#     if i == int(len(arg)):
#         return arg
#     else:
#         if arg[i] == max:
#             arg[i] = min
#         rec(arg[i + 1], min, max)
#
#
#
#
# list1 = [1, 3, 3, 3, 4]
# print(rec(list1, minS(list1), maxS(list1)))


def change_qual(mini, maxi, n):
    if n < 0:
        return
    else:
        if list1[n] == maxi:
            list1[n] = mini
        change_qual(min, max, n - 1)


list1 = [1, 3, 3, 3, 4]
change_qual(min(list1), max(list1), len(list1) - 1)
print(list1)







