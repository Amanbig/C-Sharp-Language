using System;
using System.Collections.Generic;

namespace LoopExample
{
    class Program
    {
        #region Helper Methods
        /// <summary>
        /// Generates a multiplication table for a given number
        /// </summary>
        static void PrintMultiplicationTable(int number)
        {
            Console.WriteLine($"\nMultiplication table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"   {number} x {i} = {number * i}");
            }
        }

        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("C# Loops Demonstration\n");

            // 1. For Loop
            Console.WriteLine("1. For Loop Examples:");
            
            // Basic for loop
            Console.WriteLine("   Basic counting:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // Nested for loop (Pattern printing)
            Console.WriteLine("\n   Pattern printing:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // 2. While Loop
            Console.WriteLine("\n2. While Loop Examples:");
            
            // Number guessing game
            Console.WriteLine("   Number guessing game:");
            Random random = new Random();
            int targetNumber = random.Next(1, 11);
            int attempts = 0;
            bool guessed = false;

            while (!guessed && attempts < 3)
            {
                Console.Write("   Guess a number between 1 and 10: ");
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    attempts++;
                    if (guess == targetNumber)
                    {
                        Console.WriteLine($"   Correct! You guessed it in {attempts} attempts!");
                        guessed = true;
                    }
                    else
                    {
                        Console.WriteLine($"   Wrong! {(guess < targetNumber ? "Too low" : "Too high")}");
                    }
                }
            }
            if (!guessed)
            {
                Console.WriteLine($"   Game over! The number was {targetNumber}");
            }

            // 3. Do-While Loop
            Console.WriteLine("\n3. Do-While Loop Example:");
            
            // Menu system
            int choice;
            do
            {
                Console.WriteLine("\n   Menu:");
                Console.WriteLine("   1. Print Hello");
                Console.WriteLine("   2. Print Current Time");
                Console.WriteLine("   3. Exit");
                Console.Write("   Enter your choice (1-3): ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("   Hello!");
                            break;
                        case 2:
                            Console.WriteLine($"   Current time: {DateTime.Now:T}");
                            break;
                        case 3:
                            Console.WriteLine("   Exiting menu...");
                            break;
                        default:
                            Console.WriteLine("   Invalid choice!");
                            break;
                    }
                }
            } while (choice != 3);

            // 4. Foreach Loop
            Console.WriteLine("\n4. Foreach Loop Examples:");
            
            // Array iteration
            string[] fruits = { "Apple", "Banana", "Orange", "Mango", "Grape" };
            Console.WriteLine("   Fruits in the basket:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"   - {fruit}");
            }

            // List iteration with index
            List<string> colors = new List<string> { "Red", "Green", "Blue", "Yellow" };
            Console.WriteLine("\n   Colors with index:");
            int index = 0;
            foreach (string color in colors)
            {
                Console.WriteLine($"   [{index++}] {color}");
            }

            // 5. Advanced Loop Examples
            Console.WriteLine("\n5. Advanced Loop Examples:");

            // Break and Continue
            Console.WriteLine("   First 5 prime numbers between 1 and 20:");
            int primesFound = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (primesFound == 5) break;  // Break example
                
                if (!IsPrime(i)) continue;    // Continue example
                
                Console.Write($"{i} ");
                primesFound++;
            }
            Console.WriteLine();

            // Multiplication table
            PrintMultiplicationTable(5);

            // 6. Loop with LINQ
            Console.WriteLine("\n6. LINQ with Loops:");
            var numbers = Enumerable.Range(1, 10);
            
            Console.WriteLine("   Even numbers from 1 to 10:");
            foreach (var num in numbers.Where(n => n % 2 == 0))
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}