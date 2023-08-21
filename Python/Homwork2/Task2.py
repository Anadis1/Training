# Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница. Петя помогает Кате по математике.
# Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать.
# Для этого Петя делает две подсказки. Он называет сумму этих чисел S и их произведение P.
# Помогите Кате отгадать задуманные Петей числа.

def checkNumber():
    temp = int(input("Введите натуральное число 1000 ---> "))
    if 0 <= temp <= 1000:
        return temp
    else:
        print("Число не соответствует условию")
        exit()

def hiddenNumbers(sum, composition):
    for i in range(sum):
        for el in range(sum):
            if i + el == sum:
                if i * el == composition:
                    print(f"Загаданные числа {i} и {el}")
                    exit()

numberX = checkNumber()
numberY = checkNumber()

sum = numberX + numberY
composition = numberX * numberY

print(f"Петя дает подсказки - Сумма {sum}, произведение {composition}")
hiddenNumbers(sum, composition)



