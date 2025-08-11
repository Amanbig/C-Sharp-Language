using System;

namespace Variables
{
    class Program
    {
        // Constant declaration - value cannot be changed during runtime
        private const int MAX_SCORE = 100;
        private const double PI = 3.14159;

        static void Main(string[] args)
        {
            Console.WriteLine("C# Variable Types Demonstration\n");

            // Integer types
            sbyte smallNumber = 127;                 // -128 to 127
            int regularNumber = 25;                  // -2^31 to 2^31-1
            long largeNumber = 7_800_000_000L;      // -2^63 to 2^63-1
            
            // Floating-point types
            float salary = 50_000.50f;              // 7 digits precision
            double height = 5.9;                    // 15-17 digits precision
            decimal bankBalance = 12345.67M;        // 28-29 digits precision

            // Text and character types
            string name = "John Doe";               // Text string
            char initial = 'J';                     // Single character

            // Boolean type
            bool isEmployed = true;                 // true or false

            // Display all variables
            Console.WriteLine("--- Numeric Types ---");
            Console.WriteLine($"Small Number (sbyte): {smallNumber}");
            Console.WriteLine($"Regular Number (int): {regularNumber}");
            Console.WriteLine($"Large Number (long): {largeNumber:N0}");
            
            Console.WriteLine("\n--- Floating Point Types ---");
            Console.WriteLine($"Salary (float): ${salary:F2}");
            Console.WriteLine($"Height (double): {height:F1} feet");
            Console.WriteLine($"Bank Balance (decimal): ${bankBalance:F2}");
            
            Console.WriteLine("\n--- Text Types ---");
            Console.WriteLine($"Name (string): {name}");
            Console.WriteLine($"Initial (char): {initial}");
            
            Console.WriteLine("\n--- Boolean Type ---");
            Console.WriteLine($"Employed (bool): {isEmployed}");
            
            Console.WriteLine("\n--- Constants ---");
            Console.WriteLine($"Maximum Score: {MAX_SCORE}");
            Console.WriteLine($"PI: {PI}");

            // Variable type inference using 'var'
            var inferredInt = 100;                  // Compiler infers int
            var inferredString = "Hello";           // Compiler infers string
            Console.WriteLine("\n--- Type Inference ---");
            Console.WriteLine($"Inferred Int Type: {inferredInt.GetType()}");
            Console.WriteLine($"Inferred String Type: {inferredString.GetType()}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
}