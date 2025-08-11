using System;

namespace UserInput
{
    class Program
    {
        #region Input Validation Methods
        /// <summary>
        /// Gets a valid integer input from the user
        /// </summary>
        static int GetValidIntInput(string prompt, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    if (result >= minValue && result <= maxValue)
                    {
                        return result;
                    }
                    Console.WriteLine($"Please enter a number between {minValue} and {maxValue}.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        /// <summary>
        /// Gets a valid string input from the user
        /// </summary>
        static string GetValidStringInput(string prompt, int minLength = 1, int maxLength = 50)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(input) && input.Length >= minLength && input.Length <= maxLength)
                {
                    return input;
                }
                Console.WriteLine($"Please enter text between {minLength} and {maxLength} characters.");
            }
        }

        /// <summary>
        /// Gets a valid yes/no response from the user
        /// </summary>
        static bool GetYesNoInput(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt} (y/n): ");
                string input = Console.ReadLine()?.ToLower().Trim();

                if (input == "y" || input == "yes")
                    return true;
                if (input == "n" || input == "no")
                    return false;

                Console.WriteLine("Please enter 'y' or 'n'.");
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("C# User Input Demonstration\n");

            // 1. Basic String Input
            Console.WriteLine("1. Basic String Input:");
            string name = GetValidStringInput("Enter your name: ", 2, 30);
            Console.WriteLine($"Hello, {name}!");

            // 2. Numeric Input with Validation
            Console.WriteLine("\n2. Numeric Input:");
            int age = GetValidIntInput("Enter your age: ", 0, 150);
            Console.WriteLine($"You are {age} years old.");

            // 3. Password Input (Masked)
            Console.WriteLine("\n3. Password Input (Masked):");
            Console.Write("Enter your password: ");
            string password = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Enter)
                {
                    if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password[..^1];
                        Console.Write("\b \b");
                    }
                    else if (key.Key != ConsoleKey.Backspace)
                    {
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine("\nPassword accepted!");

            // 4. Multiple Choice Input
            Console.WriteLine("\n4. Multiple Choice Input:");
            Console.WriteLine("Choose your favorite color:");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Green");
            Console.WriteLine("4. Yellow");

            int colorChoice = GetValidIntInput("Enter your choice (1-4): ", 1, 4);
            string chosenColor = colorChoice switch
            {
                1 => "Red",
                2 => "Blue",
                3 => "Green",
                4 => "Yellow",
                _ => "Invalid Color"
            };
            Console.WriteLine($"You chose {chosenColor}!");

            // 5. Yes/No Input
            Console.WriteLine("\n5. Yes/No Input:");
            bool likesProgramming = GetYesNoInput("Do you like programming?");
            Console.WriteLine(likesProgramming ? 
                "Great! Programming is fun!" : 
                "That's okay, everyone has different interests!");

            // 6. Console Color and Formatting
            Console.WriteLine("\n6. Colored Output Based on Input:");
            int score = GetValidIntInput("Enter your test score (0-100): ", 0, 100);
            
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = score >= 70 ? ConsoleColor.Green : 
                                    score >= 50 ? ConsoleColor.Yellow : 
                                    ConsoleColor.Red;
            
            Console.WriteLine($"Your score: {score}");
            Console.ForegroundColor = originalColor;

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}