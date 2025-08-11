using System;

namespace UserInput{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Here is your name:"+name);

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are" + age + "years old.");
        }
    }
}