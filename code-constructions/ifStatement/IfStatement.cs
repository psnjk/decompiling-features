using System;

class IfStatement {
    static void Main(string[] args) {

        var rand = new Random();

        if (rand.Next(0,2) == 0) {
            Console.WriteLine(1);
        } else {
            Console.WriteLine(2);
        }
    }
}