using System;
namespace LoopExample{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("This is the program that utilizes loops");

            // For loop example
            Console.WriteLine("For loop:");
            for(int i = 1; i <= 5; i++){
                Console.WriteLine($"Iteration {i}");
            }

            // While loop example
            Console.WriteLine("While loop:");
            int j = 1;
            while(j <= 5){
                Console.WriteLine($"Iteration {j}");
                j++;
            }

            // Do-while loop example
            Console.WriteLine("Do-while loop:");
            int k = 1;
            do{
                Console.WriteLine($"Iteration {k}");
                k++;
            }while(k <= 5);


            string[] temp = {"1","2","3","4","5"};
            foreach(string item in temp){
                Console.WriteLine($"Item: {item}");
            }
        }
    }
}