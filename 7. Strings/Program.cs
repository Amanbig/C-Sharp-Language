using System;

namespace StringMethods{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("This is the program for string operatiosn");
            string a = "Nice to meet you";
            Console.WriteLine(a.Lenght);
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());
            string b = "Hello";
            string c = a + c;
            Console.WriteLine(c);
            string d = string.Concat(a,b);
            Console.WriteLine(d);

            string e = $" Hello Everyone {a} {b}";
            Console.WriteLine(e);

            Console.WriteLine(a[0]);    
            Console.WriteLine(a.IndexOf("Hello"));

            string name = a.Substring(4);
            Console.WriteLine(name);

            string temp = "Hello I\'m a string and i love \"C#\"  \\";
            Console.WriteLine(temp);
        }
    }
}