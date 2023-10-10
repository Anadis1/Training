
package lesson5;

import java.util.*;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) {
        HashMap<Character, Character> brackets = new HashMap<>();

        brackets.put('}', '{');
        brackets.put(']', '[');
        brackets.put(')', '(');


        Stack<Character> stack = new Stack<>();
        char[] chars = "[a+(1*3])".toCharArray();
        for (char myChar : chars) {
            if (brackets.containsValue(myChar)) {
                stack.push(myChar);
            } else if (brackets.containsKey(myChar)) {
                if (stack.isEmpty() || stack.pop() != brackets.get(myChar)) {
                    System.out.println("false");
                    return;
                }
            }
        }
        System.out.println(stack.isEmpty());
    }
}