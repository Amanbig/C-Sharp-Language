using System;

namespace Introduction
{
    /// <summary>
    /// Main program class that demonstrates basic C# program structure
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args">Command line arguments passed to the program</param>
        static void Main(string[] args)
        {
            // Single line comment example
            Console.WriteLine("Hello, World!"); // Prints text and adds a new line

            /* Multi-line comment example
             * WriteLine() - Prints text with a new line at the end
             * Write() - Prints text without a new line
             */
            
            // Print current date and time
            Console.WriteLine($"Current Date and Time: {DateTime.Now}");
            
            // Demonstrate basic string formatting
            string name = "C# Learner";
            Console.WriteLine($"Welcome, {name}!");
            
            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}