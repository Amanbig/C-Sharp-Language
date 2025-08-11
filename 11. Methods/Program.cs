using System;

namespace Methods
{
    class Program
    {
        #region Basic Methods

        /// <summary>
        /// Demonstrates a simple method that prints a message
        /// </summary>
        /// <param name="message">The message to print</param>
        static void PrintMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        /// <summary>
        /// Demonstrates a method with an optional parameter
        /// </summary>
        /// <param name="message">Optional message parameter with default value</param>
        static void PrintWithDefault(string message = "Hello")
        {
            Console.WriteLine($"Default Message: {message}");
        }

        #endregion

        #region Methods with Return Values

        /// <summary>
        /// Demonstrates a method that returns a value
        /// </summary>
        /// <param name="number">Number to increment</param>
        /// <returns>Incremented number</returns>
        static int Increment(int number)
        {
            return number + 1;
        }

        /// <summary>
        /// Calculates the sum of two integers
        /// </summary>
        /// <param name="x">First number</param>
        /// <param name="y">Second number</param>
        /// <returns>Sum of the two numbers</returns>
        static int Add(int x, int y)
        {
            return x + y;
        }

        #endregion

        #region Method Overloading

        /// <summary>
        /// Adds two integers - Demonstrates method overloading
        /// </summary>
        static void Calculate(int x, int y)
        {
            Console.WriteLine($"Adding integers: {x} + {y} = {x + y}");
        }

        /// <summary>
        /// Adds two doubles - Demonstrates method overloading
        /// </summary>
        static void Calculate(double x, double y)
        {
            Console.WriteLine($"Adding doubles: {x} + {y} = {x + y}");
        }

        /// <summary>
        /// Multiplies two numbers - Demonstrates method overloading
        /// </summary>
        static void Calculate(int x, int y, string operation = "multiply")
        {
            Console.WriteLine($"Multiplying: {x} * {y} = {x * y}");
        }

        #endregion

        #region Named Parameters

        /// <summary>
        /// Demonstrates named parameters
        /// </summary>
        static void DisplayPersonInfo(string name, int age, string city)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        }

        #endregion

        #region Ref and Out Parameters

        /// <summary>
        /// Demonstrates 'ref' parameter - modifies the original variable
        /// </summary>
        static void ModifyNumber(ref int number)
        {
            number *= 2;
        }

        /// <summary>
        /// Demonstrates 'out' parameter - must assign a value inside the method
        /// </summary>
        static void DivideNumbers(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("C# Methods Demonstration\n");

            // 1. Basic Method Calls
            Console.WriteLine("1. Basic Methods:");
            PrintMessage("Hello, World!");
            PrintWithDefault();
            PrintWithDefault("Custom message");

            // 2. Methods with Return Values
            Console.WriteLine("\n2. Methods with Return Values:");
            int number = 5;
            int incremented = Increment(number);
            Console.WriteLine($"Incremented {number} to {incremented}");
            Console.WriteLine($"Sum of 10 and 20 is {Add(10, 20)}");

            // 3. Method Overloading
            Console.WriteLine("\n3. Method Overloading:");
            Calculate(5, 3);                // Uses integer version
            Calculate(5.5, 3.3);           // Uses double version
            Calculate(4, 5, "multiply");   // Uses multiplication version

            // 4. Named Parameters
            Console.WriteLine("\n4. Named Parameters:");
            DisplayPersonInfo(name: "John", age: 30, city: "New York");
            DisplayPersonInfo(city: "London", name: "Alice", age: 25); // Order doesn't matter

            // 5. Ref and Out Parameters
            Console.WriteLine("\n5. Ref and Out Parameters:");
            int x = 10;
            Console.WriteLine($"Original value: {x}");
            ModifyNumber(ref x);
            Console.WriteLine($"After ref modification: {x}");

            int quotient, remainder;
            DivideNumbers(17, 5, out quotient, out remainder);
            Console.WriteLine($"17 divided by 5: Quotient = {quotient}, Remainder = {remainder}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}