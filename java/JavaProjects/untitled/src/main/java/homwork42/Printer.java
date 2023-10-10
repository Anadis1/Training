package homwork42;

import java.util.LinkedList;

//В классе MyQueue реализуйте очередь с помощью LinkedList со следующими методами:
//
//        enqueue() - помещает элемент в конец очереди
//        dequeue() - возвращает первый элемент из очереди и удаляет его
//        first() - возвращает первый элемент из очереди, не удаляя
//        getElements() - возвращает все элементы в очереди
class MyQueue<T> {
    private LinkedList<T> queue = new LinkedList<T>();
    // Напишите свое решение ниже

    public void enqueue(T element){
        queue.addLast(element);
        // Напишите свое решение ниже

    }

    public T dequeue(){
        return (T) queue.pollFirst();
        // Напишите свое решение ниже

    }

    public T first(){
        return (T) queue.peekFirst();
        // Напишите свое решение ниже

    }

    public LinkedList<T> getElements() {
        return queue;
        // Напишите свое решение ниже

    }
}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Printer {
    public static void main(String[] args) {
        MyQueue<Integer> queue;
        queue = new MyQueue<>();

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            queue.enqueue(1);
            queue.enqueue(10);
            queue.enqueue(15);
            queue.enqueue(5);
        } else {
            queue.enqueue(Integer.parseInt(args[0]));
            queue.enqueue(Integer.parseInt(args[1]));
            queue.enqueue(Integer.parseInt(args[2]));
            queue.enqueue(Integer.parseInt(args[3]));
        }

        System.out.println(queue.getElements());

        queue.dequeue();
        queue.dequeue();
        System.out.println(queue.getElements());

        System.out.println(queue.first());
    }
}