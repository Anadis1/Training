class Pets:
    def __init__(self, view, name):
        self.view = view
        self.name = name
    def WatchPets(self):
        print(f"{self.view} по имени {self.name}")

def AddAPet():
    tempView = input("Введите вид животного ---> ")
    tempName = input("Введите имя животного ---> ")
    tempPet = Pets(tempView, tempName)
    print("В питомник прибыло новое домашнее животное")
    tempPet.WatchPets()
    PetArray.append([tempView, tempName, []])

def AddPackAnimals():
    tempView = input("Введите вид животного ---> ")
    tempName = input("Введите имя животного ---> ")
    tempPet = Pets(tempView, tempName)
    print("В питомник прибыло новое вьючное животное")
    tempPet.WatchPets()
    PackAnimalsArray.append([tempView, tempName, []])

def AllAnimals():
    print("Домашние животные в питомнике:")
    for i in range(len(PetArray)):
        tempView = PetArray[i][0]
        tempName = PetArray[i][1]
        tempPet = Pets(tempView, tempName)
        tempPet.WatchPets()

    print()
    print("Вьючные животные в питомнике:")
    for i in range(len(PackAnimalsArray)):
        tempView = PackAnimalsArray[i][0]
        tempName = PackAnimalsArray[i][1]
        tempPet = Pets(tempView, tempName)
        tempPet.WatchPets()

def SkillAnimals():
    tempPetArray = list()
    print("Имена питомцев содержащихся в питомнике:")
    for i in range(len(PetArray)):
        tempPetArray.append(PetArray[i])
        print(PetArray[i][1], end=" ")
    for i in range(len(PackAnimalsArray)):
        tempPetArray.append(PackAnimalsArray[i])
        print(PackAnimalsArray[i][1], end=" ")
    print(end="\n")
    tempArg = input("Введите имя питомца чьи навыки желаете посмотреть ---> ")
    for i in range(len(tempPetArray)):
        if tempArg == tempPetArray[i][1]:
            for el in range(len(tempPetArray[i][2])):
                print(f"{el + 1} - {tempPetArray[i][2][el]}")

def ToTeachASkill():
    print("Имена питомцев содержащихся в питомнике:")
    for i in range(len(PetArray)):
        print(PetArray[i][1], end=" ")
    for i in range(len(PackAnimalsArray)):
        print(PackAnimalsArray[i][1], end=" ")
    print(end="\n")
    tempArg = input("Введите имя питомца которому нужно добавить навык ---> ")
    for i in range(len(PetArray)):
        if tempArg == PetArray[i][1]:
            PetArray[i][2].append(input("Введите навык которому научился питомец ---> "))
    for i in range(len(PackAnimalsArray)):
        if tempArg == PackAnimalsArray[i][1]:
            PackAnimalsArray[i][2].append(input("Введите навык которому научился питомец ---> "))

def main():
    print(f"\nВ питомнике живет домашних питомцев: {len(PetArray)}")
    print(f"В питомнике живет вьючных животных: {len(PackAnimalsArray)}")

    team = input("\nВы в главном меню (0 подсказка по меню) ---> ")

    if (team == "1"):  # Добавить питомца AddAPet
        AddAPet()

    if (team == "2"):  # Добавить вьючного AddAPet
        AddPackAnimals()

    if (team == "3"):  # Вывести всех питомцев
        AllAnimals()

    if (team == "4"):  # показать навыки питомца
        SkillAnimals()

    if (team == "5"):  # показать навыки питомца
        ToTeachASkill()

    if (team == "6"):
        exit()

    if (team == "0"):
        print("Чтобы добавить домашнего питомца --- 1")
        print("Чтобы добавить вьючного питомца --- 2")
        print("Показать всех животных в питомнике --- 3")
        print("Показать навыки питомцев --- 4")
        print("Обучить питомца новому навыку --- 5")
        print("Для выхода из программы введите --- 6")

    main()

print("Чтобы добавить домашнего питомца --- 1")
print("Чтобы добавить вьючного питомца --- 2")
print("Показать всех животных в питомнике --- 3")
print("Показать навыки питомцев --- 4")
print("Обучить питомца новому навыку --- 5")
print("Для выхода из программы введите --- 6")

PetArray = [["Кошка", "Луна", ["Кувырок", "Стоит на задних лапах"]], ["Собака", "Джеса", ["Дает лапу"]], ["Хомяк", "Чакнорис", ["Ест"]]]
PackAnimalsArray = [["Лошадь", "Молния", ["Галоп"]], ["Ослик", "Иа", ["Махать хвостом"]]]

main()