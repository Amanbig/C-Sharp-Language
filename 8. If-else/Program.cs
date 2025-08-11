using System;

namespace IfElseExample{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("This is the program that utilizes if-else statements");
            Console.Write("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number>0){
                Console.WriteLine("The number is positive.");
            }
            else if(number<0){
                Console.WriteLine("The number is negative.");
            }
            else{
                Console.WriteLine("The number is zero.");
            }

            string numberResult = number >= 0 ? "Positive or Zero" : "Negative";
            Console.WriteLine($"Using ternary operator: The number is {numberResult}.");

            Console.Write("Enter a week day in number (1-7):");
            int day = Convert.ToInt32(Console.ReadLine());
            switch(day){
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}