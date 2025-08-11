using System;
using System.IO;

namespace ExceptionsExample
{
    #region Custom Exception
    /// <summary>
    /// Custom exception class for age validation
    /// </summary>
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base() { }
        public InvalidAgeException(string message) : base(message) { }
        public InvalidAgeException(string message, Exception inner) : base(message, inner) { }
    }
    #endregion

    class Program
    {
        #region Exception Handling Methods
        /// <summary>
        /// Demonstrates array bounds checking with exception handling
        /// </summary>
        static void DemonstrateArrayException()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine($"Attempting to access index 5 in array of length {numbers.Length}");
                Console.WriteLine(numbers[5]); // This will throw an exception
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Array Error: {e.Message}");
                Console.WriteLine($"Stack Trace: {e.StackTrace}");
            }
        }

        /// <summary>
        /// Demonstrates handling multiple exception types
        /// </summary>
        static void DemonstrateMultipleExceptions()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);
                int result = 100 / number;
                Console.WriteLine($"100 / {number} = {result}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Error: Please enter a valid number. ({e.Message})");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Division Error: Cannot divide by zero. ({e.Message})");
            }
            catch (Exception e)
            {
                Console.WriteLine($"General Error: {e.Message}");
            }
        }

        /// <summary>
        /// Demonstrates file operations with exception handling
        /// </summary>
        static void DemonstrateFileException()
        {
            string filePath = "nonexistent.txt";
            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"File Error: The file '{filePath}' was not found.");
                Console.WriteLine($"Details: {e.Message}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"IO Error: {e.Message}");
            }
        }

        /// <summary>
        /// Demonstrates custom exception usage
        /// </summary>
        static void ValidateAge(int age)
        {
            if (age < 0 || age > 150)
            {
                throw new InvalidAgeException($"Age must be between 0 and 150. Provided age: {age}");
            }
            Console.WriteLine($"Age {age} is valid.");
        }

        /// <summary>
        /// Demonstrates exception filtering with when clause
        /// </summary>
        static void DemonstrateExceptionFiltering()
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine($"Processing index {i}...");
                    ProcessArrayElement(numbers, i);
                }
            }
            catch (IndexOutOfRangeException e) when (e.Message.Contains("5"))
            {
                Console.WriteLine("Caught specific index error for index 5");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Caught general index error: {e.Message}");
            }
        }

        static void ProcessArrayElement(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                throw new IndexOutOfRangeException($"Invalid index: {index}");
            }
            Console.WriteLine($"Element at index {index}: {arr[index]}");
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("C# Exception Handling Demonstration\n");

            // 1. Basic Array Exception
            Console.WriteLine("1. Array Exception Handling:");
            DemonstrateArrayException();

            // 2. Multiple Exception Types
            Console.WriteLine("\n2. Multiple Exception Types:");
            DemonstrateMultipleExceptions();

            // 3. File Operation Exception
            Console.WriteLine("\n3. File Operation Exception:");
            DemonstrateFileException();

            // 4. Custom Exception
            Console.WriteLine("\n4. Custom Exception:");
            try
            {
                ValidateAge(200); // This will throw our custom exception
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine($"Age Validation Error: {e.Message}");
            }

            // 5. Exception Filtering
            Console.WriteLine("\n5. Exception Filtering:");
            DemonstrateExceptionFiltering();

            // 6. Finally Block
            Console.WriteLine("\n6. Finally Block Usage:");
            try
            {
                Console.WriteLine("Attempting risky operation...");
                throw new Exception("Simulated error");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Caught error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed - cleanup code goes here");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}