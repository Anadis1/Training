# Даны два неупорядоченных набора целых чисел (может быть, с повторениями).
# Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. n — кол-во элементов первого множества. m — кол-во
# элементов второго множества. Затем пользователь вводит сами элементы множеств.

def list_func(arg):
    listTemp = []
    for el in range(arg):
        listTemp.append(int(input("Введите элемент множества ---> ")))
    return listTemp

def listN_end_listM(arg1,arg2):
    listTemp = []
    for el in range(len(arg1)):
        for i in range(len(arg2)):
            if arg1[el] == arg2[i]:
                listTemp.append(arg2[i])
    setTemp = set(listTemp)
    listTemp = list(setTemp)
    listTemp.sort()
    return listTemp


n = int(input("Введите кол-во элементов первого множества ---> "))
listN = list_func(n)
m = int(input("Введите кол-во элементов второго множества ---> "))
listM = list_func(m)
print(f"Первое множество ---> {listN}")
print(f"Второе множество ---> {listM}")

print(listN_end_listM(listN, listM))