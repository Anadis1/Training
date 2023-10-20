package homwork3;

import java.util.Comparator;

public class ComparatorDepartmentName implements Comparator<Employee> {

    @Override
    public int compare(Employee o1, Employee o2) {
        return o1.departmentName - o2.departmentName;
    }
}