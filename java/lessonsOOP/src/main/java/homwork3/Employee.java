package homwork3;


public class Employee implements Comparable<Employee> {

    public String name;
    public int age;
    public int salary;
    public int departmentName;

    public void getEmployee(){
        System.out.println("Имя - " + name + "\t\tВозраст - " + age + "\t\tЗарплата - " + salary +  "\t\tДепартамент - " + departmentName);
    }

    public Employee(String name, int age, int salary, int departmentName){
        this.name = name;
        this.age = age;
        this.salary = salary;
        this.departmentName = departmentName;
    }

    @Override
    public int compareTo(Employee o) {
        return this.age - o.age;
    }

    @Override
    public String toString() {
        return "(" + "Имя - " + name + "| Возраст - " + age + "| Зарплата - " + salary +  "| Департамент - " + departmentName + ")\n";
    }
}

