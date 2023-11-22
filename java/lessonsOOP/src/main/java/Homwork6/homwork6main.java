package Homwork6;

/**
 * Класс документ - описывает структуру документа.
 *
 * Нужно спроектировать систему отчетов, которая будет формировать отчеты для документа.
 *
 * 1. Формирование PDF-файла (потенциально может быть несколько типом разметки PDF-файла).
 * 2. Формирование JSON-файла с полями документа.
 * 3. Формирование XML-файла с полями документа.
 * 4. ... потенциально могут добавляться разные типы отчетов.
 *
 * После реализации задать себе 2 вопроса и прикрепить их к сданной ДЗ:
 * 1. Насколько сложно добавить поддержку нового типа отчета?
 * 2. Как будет выглядеть проект, если в нем будет 1000+ типов отчетов?
 *
 *
 */

public class homwork6main {
    public static void main(String[] args) {
        Document document = new Document(1, "Произвольный текст"); //Создали документ
        document.printDoc(); // мотрим документ
        document.importDoc("json");
    }

}
class Document {            //Класс документ
    public Integer id;
    public String text;
    public String type;

    public Document(Integer id, String text){
        this.id = id;
        this.text = text;
    }
    public void printDoc(){
        System.out.println("ID документа - " + id + " ... Текст в документе - " + text);
    }
    public void importDoc(String type){
        this.type = type;
        System.out.println("Документ сохранен   " + id + "." + type);
    }

}
