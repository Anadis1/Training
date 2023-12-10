package Homwork;

//Напишите приложение, которое будет запрашивать у пользователя следующие данные в произвольном порядке, разделенные пробелом: +
//Фамилия Имя Отчество датарождения номертелефона пол +
//
//Форматы данных:
//фамилия, имя, отчество - строки
//датарождения - строка формата dd.mm.yyyy
//номертелефона - целое беззнаковое число без форматирования
//пол - символ латиницей f или m.
//
//Приложение должно проверить введенные данные по количеству. Если количество не совпадает с требуемым, +
//вернуть код ошибки, обработать его и показать пользователю сообщение, что он ввел меньше и больше данных, чем требуется. +
//
//Приложение должно попытаться распарсить полученные значения и выделить из них требуемые параметры. +
//Если форматы данных не совпадают, нужно бросить исключение, соответствующее типу проблемы. +
//Можно использовать встроенные типы java и создать свои. Исключение должно быть корректно обработано, +
//пользователю выведено сообщение с информацией, что именно неверно. +
//
//Если всё введено и обработано верно, должен создаться файл с названием, равным фамилии,
//в него в одну строку должны записаться полученные данные, вида
//
//<Фамилия><Имя><Отчество><датарождения> <номертелефона><пол>
//
//Однофамильцы должны записаться в один и тот же файл, в отдельные строки.
//
//Не забудьте закрыть соединение с файлом.
//
//При возникновении проблемы с чтением-записью в файл, исключение должно быть корректно обработано, пользователь должен увидеть стектрейс ошибки.

import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class HomworkMain {
    public static void main(String[] args) throws IOException {
        String name = "";
        String gender = "";
        String dateOfBirth = "";
        String phoneNumber = "";
        System.out.printf("Введите данные через пробел - Фамилия Имя Отчество дата рождения номертелефона пол \n");
        Scanner scanner = new Scanner(System.in);
        String newInput = scanner.nextLine();
        scanner.close();
//        String newInput = "Филимонов Николый Александрович 01.01.2000 88888888888 f";
        String[] stringsArray = newInput.split(" ");
        if (stringsArray.length != 6) {
            throw new IOException("Введено данных - " + stringsArray.length + " требуется - " + 6);
        }
        for (String s : stringsArray) {
            int temp = 0;
            if(s.length() == 1){
                gender = s;
                temp = 1;
                if(!s.equals("f") & !s.equals("m")){
                    throw  new IOException("Пол нужно указать латинскими - m или f... вы указали - " + s);
                }
            }
            if(s.contains(".")){
                temp = 1;
                dateOfBirth = s;
                String dateOfBirthTemp = dateOfBirth.replace(".", "");
                int NumberOfPoints = dateOfBirth.length() - dateOfBirthTemp.length();   // Так я понял сколько точек в строке
                if(s.length() != 10 | NumberOfPoints != 2){
                    throw  new IOException("Дата рождения указанна не верно... Вы ввели - " + s + " Пример ввода - 01.01.2000");
                }
            }
            if(s.contains("8")){
                temp = 1;
                phoneNumber = s;
                if(s.length() != 11){
                    throw  new IOException("Номер телефона состоит из 11 цифр... вы ввели " + s.length() + " цифр - "  + s);
                }
            }
            if(temp == 0){    // Сделал костыль... Когда я писал else добавлялись и другие строки.((((
                name = name + s + " ";
            }
        }
        String nameTemp = name.replace(" ", "");
        int NumberOfSpaces = name.length() - nameTemp.length();
        if(NumberOfSpaces != 3){
            throw  new IOException("Не корректно введены ФИО... Вы ввели - " + name + " Пример ввода - Иванов Иван Иванович");
        }
        System.out.println("\nФИО - "+ name + "\nДата рождения - " + dateOfBirth + "\nНомер телефона - " + phoneNumber + "\nпол - " + gender);


        try {
            FileWriter writeMy = new FileWriter(name +".txt");
            writeMy.write(name);
            writeMy.write(dateOfBirth + " ");
            writeMy.write(phoneNumber + " ");
            writeMy.write(gender + " ");
            writeMy.close();
        }
        catch(IOException e){

            System.out.println("Произошла ошибка при работе с фаилом");
        }

    }
}
