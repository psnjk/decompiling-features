import java.util.Random;

class WhileLoop {
    public static void main(String[] args) {

        Random random = new Random();

        while (random.nextInt(2)==0) {
            System.out.println(1);
        }
    }
}
