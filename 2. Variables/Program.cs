using System;

namespace Variables{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("This is a variables example in C#");
            int age = 25;
            string name = "John Doe";
            double height  = 5.9;
            bool isEmployed = true;
            char initial = 'J';
            float salary = 50000.50f;
            long population = 7800000000L;
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}, Employed: {isEmployed}, Initial: {initial}, Salary: {salary}, Population: {population}");

            const int maxScore = 100;
            Console.WriteLine($"Maximum Score: {maxScore}");
    }
}
}