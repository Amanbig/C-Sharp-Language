using System;

namespace Operators{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Operators in C#");

            // Arithmetic operators
            int a = 10;
            int b = 5;
            Console.WriteLine($"addtition: {a+b}");
            Console.WriteLine($"substraction: {a-b}");
            Console.WriteLine($"multiplication: {a*b}");
            Console.WriteLine($"division: {a/b}");
            Console.WriteLine($"modulus: {a%b}");
            Console.WriteLine($"increment: {++a}");
            Console.WriteLine($"decrement: {--b}");
            Console.WriteLine($"negation: {-a}");


            // Relational operators
            Console.WriteLine($"a is greater than b: {a > b}");
            Console.WriteLine($"a is less than b: {a < b}");
            Console.WriteLine($"a is equal to b: {a == b}");
            Console.WriteLine($"a is not equal to b: {a != b}");
            Console.WriteLine($"a is greater than or equal to b: {a >= b}");
            Console.WriteLine($"a is less than or equal to b: {a <= b}");

            // assignment operators
            int c = 20;
            Console.WriteLine($"c before assignment: {c}");
            c += 5;
            Console.WriteLine($"c after addition assignment: {c}");
            c -= 3;
            Console.WriteLine($"c after subtraction assignment: {c}");
            c *= 2;
            Console.WriteLine($"c after multiplication assignment: {c}");
            c /= 4;
            Console.WriteLine($"c after division assignment: {c}");
            c %= 3;
            Console.WriteLine($"c after modulus assignment: {c}");
            c &= 1;
            Console.WriteLine($"c after bitwise AND assignment: {c}");
            c |= 2;
            Console.WriteLine($"c after bitwise OR assignment: {c}");
            c ^= 1;
            Console.WriteLine($"c after bitwise XOR assignment: {c}");
            c <<= 1;
            Console.WriteLine($"c after left shift assignment: {c}");
            c >>= 1;
            Console.WriteLine($"c after right shift assignment: {c}");


            // Logical operators
            bool x = true;
            bool y = false;
            Console.WriteLine($"x AND y: {x && y}");
            Console.WriteLine($"x OR y: {x || y}");
            Console.WriteLine($"NOT x: {!x}");
            Console.WriteLine($"NOT y: {!y}");
        }
    }
}