# Напишите проект, содержащий функционал работы с заметками. Программа должна уметь создавать заметку,
# сохранять её, читать список заметок, редактировать заметку, удалять заметку.

def main():
    print("Создавать заметку введите --- 1")
    print("Прочитать заметки введите --- 2")
    print("Редактировать или удалить заметку введите --- 3")
    print("Для завершения работы введите --- 4")

    team = input("---> ")

    my_file = open("notes.txt", "r")  # Открыть фаил для чтения
    allNotes = my_file.read()
    my_file.close()
    listNotes = allNotes.split("\n")


    if(team == "1"):                                                # создавать заметку +
        createNote(allNotes)

    if(team == "2"):                                                # читать список заметок
        readingNotes(listNotes)

    if (team == "3"):                                               # редактировать или удалить заметку
        editDelNote(listNotes, allNotes)

    if (team == "4"):                                               # Завершить работу
        exit()

    main()

def createNote(allNotes):
    print("Введите название заметки")
    nameNote = input()
    print("Введите заметку")
    contentNote = input()
    my_file = open("notes.txt", "w+")
    temp = nameNote + "\n" + contentNote + "\n" + allNotes
    my_file.write(temp)
    my_file.close()

def readingNotes(listNotes):
    numberNote = 1
    for i in range(len(listNotes) - 1):
        if i % 2 == 0:
            print(f"Заметка № {numberNote}: {listNotes[i]}")
            numberNote += 1
        else:
            print(f"{listNotes[i]}\n")

def editDelNote(listNotes, allNotes):
    setNote = {}
    numberNote = 1
    allNotes = ""
    for i in range(len(listNotes) - 1):
        if i % 2 == 0:
            setNote[listNotes[i]] = listNotes[i + 1]
            print(f"Заметка № {numberNote}: {listNotes[i]}")
            numberNote += 1
        else:
            print(f"{listNotes[i]}\n")
    print("Введите 1 для редактирования заметки --->")
    print("Введите 2 для удаления заметки --->")
    print("Введите другую клавишу для отмены --->")
    temp = input("---> ")
    if temp == "1":                                                         # Блок редактирования заметки
        delNoteNumber = int(input("Введите номер заметки ---> "))
        for i, el in enumerate(setNote):
            if delNoteNumber != i + 1:
                allNotes += el + "\n" + setNote[el] + "\n"
        createNote(allNotes)
    if  temp == "2":                                                        # Блок удаления заметки
        delNoteNumber = int(input("Введите номер заметки ---> "))
        for i, el in enumerate(setNote):
            if delNoteNumber != i + 1:
                allNotes += el + "\n" + setNote[el] + "\n"
        my_file = open("notes.txt", "w+")
        my_file.write(allNotes)
        my_file.close()
        print("Заметка удалена \n")


my_file = open("notes.txt", "a+")                                   # Создаст фаил если его нет
my_file.close()

main()