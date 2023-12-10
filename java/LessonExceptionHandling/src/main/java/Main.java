public class Main {
    public static void main(String[] args) {
        TempClass tempClass = new TempClass();
        tempClass.pluss(10);
        tempClass.print();
        tempClass.pluss(33);
        tempClass.print();


    }

    static class TempClass{
        private int sum;

        public void pluss (int arg){
            this.sum += arg;
        }

        public void print(){
            System.out.println(this.sum);
        }
    }
}


