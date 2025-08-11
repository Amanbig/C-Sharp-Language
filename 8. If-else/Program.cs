using System;

namespace IfElseExample
{
    class Program
    {
        #region Helper Methods
        /// <summary>
        /// Gets a valid integer input from the user within a specified range
        /// </summary>
        static int GetValidIntInput(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int result) && result >= min && result <= max)
                {
                    return result;
                }
                Console.WriteLine($"Please enter a valid number between {min} and {max}.");
            }
        }

        /// <summary>
        /// Determines the grade based on the score
        /// </summary>
        static string DetermineGrade(int score)
        {
            if (score >= 90) return "A";
            if (score >= 80) return "B";
            if (score >= 70) return "C";
            if (score >= 60) return "D";
            return "F";
        }

        /// <summary>
        /// Checks if a year is a leap year
        /// </summary>
        static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("C# Control Flow Statements Demonstration\n");

            // 1. Basic If-Else Statement
            Console.WriteLine("1. Basic If-Else Statement:");
            int number = GetValidIntInput("Enter a number: ", -100, 100);

            if (number > 0)
            {
                Console.WriteLine("   The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("   The number is negative.");
            }
            else
            {
                Console.WriteLine("   The number is zero.");
            }

            // 2. Nested If Statements
            Console.WriteLine("\n2. Nested If Statements:");
            int age = GetValidIntInput("Enter your age: ", 0, 120);
            double height = 1.75; // meters

            if (age >= 18)
            {
                if (height >= 1.7)
                {
                    Console.WriteLine("   You can ride all attractions!");
                }
                else
                {
                    Console.WriteLine("   You can ride most attractions.");
                }
            }
            else
            {
                if (height >= 1.5)
                {
                    Console.WriteLine("   You can ride some attractions.");
                }
                else
                {
                    Console.WriteLine("   Sorry, you can only ride children's attractions.");
                }
            }

            // 3. Logical Operators in Conditions
            Console.WriteLine("\n3. Logical Operators in Conditions:");
            bool hasTicket = true;
            bool isVIP = false;

            if (hasTicket && (isVIP || age >= 18))
            {
                Console.WriteLine("   Access granted to VIP area");
            }
            else if (hasTicket)
            {
                Console.WriteLine("   Access granted to general area");
            }
            else
            {
                Console.WriteLine("   Access denied");
            }

            // 4. Switch Statement
            Console.WriteLine("\n4. Switch Statement:");
            int day = GetValidIntInput("Enter a day number (1-7): ", 1, 7);
            
            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("   It's a weekday!");
                    switch (day)
                    {
                        case 1: Console.WriteLine("   (Monday)"); break;
                        case 2: Console.WriteLine("   (Tuesday)"); break;
                        case 3: Console.WriteLine("   (Wednesday)"); break;
                        case 4: Console.WriteLine("   (Thursday)"); break;
                        case 5: Console.WriteLine("   (Friday)"); break;
                    }
                    break;
                case 6:
                case 7:
                    Console.WriteLine("   It's the weekend!");
                    Console.WriteLine($"   ({(day == 6 ? "Saturday" : "Sunday")})");
                    break;
            }

            // 5. Pattern Matching (C# 8.0+)
            Console.WriteLine("\n5. Pattern Matching:");
            object value = "Hello";
            
            if (value is string str)
            {
                Console.WriteLine($"   String value: {str}");
            }
            else if (value is int num)
            {
                Console.WriteLine($"   Integer value: {num}");
            }

            // 6. Switch Expression (C# 8.0+)
            Console.WriteLine("\n6. Switch Expression:");
            string season = (DateTime.Now.Month) switch
            {
                12 or 1 or 2 => "Winter",
                >= 3 and <= 5 => "Spring",
                >= 6 and <= 8 => "Summer",
                >= 9 and <= 11 => "Fall",
                _ => "Invalid month"
            };
            Console.WriteLine($"   Current season: {season}");

            // 7. Ternary Operator
            Console.WriteLine("\n7. Ternary Operator:");
            int score = GetValidIntInput("Enter your test score (0-100): ", 0, 100);
            string grade = DetermineGrade(score);
            string result = score >= 60 ? "Passed" : "Failed";
            Console.WriteLine($"   Grade: {grade} ({result})");

            // 8. Complex Condition Example
            Console.WriteLine("\n8. Complex Condition Example:");
            int year = GetValidIntInput("Enter a year: ", 1900, 2100);
            
            if (IsLeapYear(year))
            {
                Console.WriteLine($"   {year} is a leap year!");
                Console.WriteLine("   February has 29 days.");
            }
            else
            {
                Console.WriteLine($"   {year} is not a leap year.");
                Console.WriteLine("   February has 28 days.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}