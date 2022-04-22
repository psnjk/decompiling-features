import java.util.Random;

class IfStatement {
    public static void main(String[] args) {

        Random random = new Random();

        if (random.nextInt(2)==0) {
            System.out.println(1);
        } else {
            System.out.println(2);
        }
    }
}
