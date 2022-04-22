using System;

class WhileLoop {
    static void Main(string[] args) {

        var rand = new Random();

        while (rand.Next(0,2) == 0) {
            Console.WriteLine(1);
        }
    }
}