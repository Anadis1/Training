import json

def saveInJson(arg):    # Функция для сохранения в джейсон
    with open("guide.txt", 'w') as outfile:
        json.dump(arg, outfile)

with open("guide.txt") as json_file:
    guide = json.load(json_file)
print(guide)

team = int(input("Введите команду (введите 0 для получения справки) --- "))

if team == 0:           # Справка по командам
    print("Вывести список контактов 1")
    print("Поиск контакта по имени 2")
    print("Для добавления контакта введите 3")
    print("Для удаления контакта введите 4")
    print("Для импорта фаила нажмите 5")

elif team == 1:         # Вывести список контактов
    for el in guide:
        for i in el:
            print(i, end = " ")
            for j in el[i]:
                print(f"    Телефон - {j['tel']}    Адрес - {j['adres']}")

elif team == 2:         # Поиск контакта по имени
    searchName = input("Введите имя контакта для поиска --- ")
    for el in guide:
        for i in el:
            if i == searchName:
                print(i, end = " ")
                for j in el[i]:
                    print(f"    Телефон - {j['tel']}    Адрес - {j['adres']}")

elif team == 3:         # Добавление контакта
    temp = {input("Введите имя контакта --- "): [{"tel": input("Введите номер контакта --- "), "adres": input("Введите адрес контакта --- ")}]}
    guide.append(temp)
    saveInJson(guide)

elif team == 4:         # Удаление контакта
    temp = input("Введите имя контакта для удаления --- ")
    del1 = 0
    for el in range(len(guide)):
        for i in guide[el]:
            if i == temp:
                del1 = el
    guide.pop(del1)
    saveInJson(guide)
