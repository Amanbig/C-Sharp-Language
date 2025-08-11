using System;

namespace Methods{
    class Program{
        static void PrintMessage(string message){
            Console.WriteLine(message);
        }
        static void Prints(string message = "Hello"){
            Console.WriteLine(message);
        }
        static int Increments(int number){
            number++;
            return number;
        }
        static void  Temp(string child1, string child2){
            Console.WriteLine($"Child 1: {child1}, Child 2: {child2}"); 
        }
        static void PlusMethod(int x, int y){
            Console.WriteLine($"Sum: {x + y}");
        }
        static void PlusMethod(double x, double y){
            Console.WriteLine($"Sum: {x + y}");
        }
        static void Main(string[] args){
            PrintMessage("Hello, World!");
            Prints();
            int result = Increments(5);
            Console.WriteLine("Incremented value is: " + result);
            Temp(child1:"Hello",child2:"Welcome");
            PlusMethod(5, 10);
            PlusMethod(5.5, 10.5);
        }
    }
}