# Задача 34:  Винни-Пух попросил Вас посмотреть, есть ли в его стихах ритм. Поскольку разобраться в его
# кричалках не настолько просто, насколько легко он их придумывает, Вам стоит написать программу.
# Винни-Пух считает, что ритм есть, если число слогов (т.е. число гласных букв) в каждой фразе стихотворения
# одинаковое. Фраза может состоять из одного слова, если во фразе несколько слов, то они разделяются дефисами.
# Фразы отделяются друг от друга пробелами. Стихотворение  Винни-Пух вбивает в программу с клавиатуры.
# В ответе напишите “Парам пам-пам”, если с ритмом все в порядке и “Пам парам”, если с ритмом все не в порядке
#
# *Пример:*
#
# **Ввод:** пара-ра-рам рам-пам-папам па-ра-па-да
#     **Вывод:** Парам пам-пам
def songCorrection(arg):
    listTemp = arg.split()
    for el in range(len(listTemp)):
        listTemp[el] = listTemp[el].lower()
    return listTemp


def songCheck(arg1):
    vowels = ("а", "у", "о", "ы", "и", "э", "я", "ю", "ё", "е")
    listTemp = []
    for el in arg1:
        temp1 = 0
        for i in vowels:
            temp1 = temp1 + el.count(i)
        listTemp.append(temp1)
    return listTemp


def printSong(arg):
    temp = arg[0]
    temp1 = 1
    for el in listSong:
        if el != temp or temp == 0:
            temp1 = 0
    if temp1 == 0:
        print("Пам парам")
    elif temp1 == 1:
        print("Парам пам-пам")


# song = "пара-ра-рам рам-пам-папам па-ра-па-да"
song = input("Введите песню --- ")

listSong = songCorrection(song)
listSong = songCheck(listSong)
printSong(listSong)