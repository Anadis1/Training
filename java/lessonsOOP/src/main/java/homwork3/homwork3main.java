package homwork3;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

/**
 * Реализовать класс Сотрудник (Employee) c полями: +
 * 1. Имя +
 * 2. Возраст +
 * 3. Зарплата +
 * 4. Наименование департамента +
 *
 * Необходимо:
 * 1. Создать список из разных сотрудников (штук 20) +
 * 2. Отсортировать список по возрастанию возраста,+ по убыванию зарплаты+, и по наименованию отдела (в лексикографическом порядке) (вывести на консоль).+
 * Подумать о том, какую сортирвку сделать по умолчанию (заложить в класс, интерфейс Comparable), а какие две сделать внешними (интерфейс Comparator).
 */
public class homwork3main {
    public static void main(String[] args) {
        Employee employee1 = new Employee("Тип",15,24000,1);
        employee1.getEmployee();
        Employee employee2 = new Employee("Лула",32,23000,4);
        employee2.getEmployee();
        Employee employee3 = new Employee("Ипкис",17,34000,2);
        employee3.getEmployee();
        Employee employee4 = new Employee("Майк",45,34000,2);
        employee4.getEmployee();
        Employee employee5 = new Employee("Стен",26,54000,1);
        employee5.getEmployee();
        Employee employee6 = new Employee("Овип",54,76000,3);
        employee6.getEmployee();
        Employee employee7 = new Employee("Лора",53,25000,1);
        employee7.getEmployee();
        Employee employee8 = new Employee("Джес",21,67000,1);
        employee8.getEmployee();
        Employee employee9 = new Employee("Арчи",12,43000,4);
        employee9.getEmployee();
        Employee employee10 = new Employee("Лучёк",34,54000,4);
        employee10.getEmployee();
        Employee employee11 = new Employee("Андро",67,36000,4);
        employee11.getEmployee();
        Employee employee12 = new Employee("Кофе",24,60000,1);
        employee12.getEmployee();
        Employee employee13 = new Employee("Конь",53,54000,3);
        employee13.getEmployee();
        Employee employee14 = new Employee("Джон",21,41000,4);
        employee14.getEmployee();
        Employee employee15 = new Employee("Петр",32,26000,1);
        employee15.getEmployee();
        Employee employee16 = new Employee("Вася",42,42000,4);
        employee16.getEmployee();
        Employee employee17 = new Employee("Стас",13,52000,2);
        employee17.getEmployee();
        Employee employee18 = new Employee("Настя",21,21000,2);
        employee18.getEmployee();
        Employee employee19 = new Employee("Вика",22,32000,4);
        employee19.getEmployee();
        Employee employee20 = new Employee("Арчи",33,24000,3);
        employee20.getEmployee();

        List<Employee> allEmployee = new ArrayList<>();
        allEmployee.add(employee1);
        allEmployee.add(employee2);
        allEmployee.add(employee3);
        allEmployee.add(employee4);
        allEmployee.add(employee5);
        allEmployee.add(employee6);
        allEmployee.add(employee7);
        allEmployee.add(employee8);
        allEmployee.add(employee9);
        allEmployee.add(employee10);
        allEmployee.add(employee11);
        allEmployee.add(employee12);
        allEmployee.add(employee13);
        allEmployee.add(employee14);
        allEmployee.add(employee15);
        allEmployee.add(employee16);
        allEmployee.add(employee17);
        allEmployee.add(employee18);
        allEmployee.add(employee19);
        allEmployee.add(employee20);

        Collections.sort(allEmployee);
        System.out.println("По возрасту -------------");
        System.out.println(allEmployee);
        System.out.println("По убыванию зарплаты ----");
        Comparator salaryReduction = new ComparatorSalaryReduction();
        Collections.sort(allEmployee, salaryReduction);
        System.out.println(allEmployee);
        System.out.println("По номеру отдела --------");
        Comparator DepartmentNameReduction = new ComparatorDepartmentName();
        Collections.sort(allEmployee, DepartmentNameReduction);
        System.out.println(allEmployee);
    }
}
