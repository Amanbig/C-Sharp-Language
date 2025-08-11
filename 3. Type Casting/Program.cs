using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Type Casting Demonstration\n");

            // 1. Implicit Casting (Widening)
            Console.WriteLine("1. Implicit Casting (automatically done by C#):");
            Console.WriteLine("   Smaller to larger type conversion:");
            
            byte smallNumber = 123;
            int integer = smallNumber;    // byte to int
            long longNumber = integer;    // int to long
            float floatNumber = longNumber; // long to float
            double doubleNumber = floatNumber; // float to double

            Console.WriteLine($"   byte ({smallNumber}) -> int ({integer}) -> long ({longNumber}) ->");
            Console.WriteLine($"   float ({floatNumber}) -> double ({doubleNumber})");

            // 2. Explicit Casting (Narrowing)
            Console.WriteLine("\n2. Explicit Casting (requires manual conversion):");
            Console.WriteLine("   Larger to smaller type conversion:");

            double pi = 3.14159;
            float piFloat = (float)pi;    // double to float
            int piInt = (int)pi;         // double to int
            
            Console.WriteLine($"   Original double: {pi}");
            Console.WriteLine($"   Converted to float: {piFloat}");
            Console.WriteLine($"   Converted to int (truncated): {piInt}");

            // 3. Type Conversion Methods
            Console.WriteLine("\n3. Using Convert Class Methods:");
            
            string numberString = "123";
            string boolString = "true";
            string doubleString = "456.789";

            int convertedInt = Convert.ToInt32(numberString);
            bool convertedBool = Convert.ToBoolean(boolString);
            double convertedDouble = Convert.ToDouble(doubleString);

            Console.WriteLine($"   String to Int: \"{numberString}\" -> {convertedInt}");
            Console.WriteLine($"   String to Bool: \"{boolString}\" -> {convertedBool}");
            Console.WriteLine($"   String to Double: \"{doubleString}\" -> {convertedDouble}");

            // 4. Parse Methods
            Console.WriteLine("\n4. Using Parse Methods:");
            
            string intString = "789";
            string decimalString = "123.456";
            
            int parsedInt = int.Parse(intString);
            decimal parsedDecimal = decimal.Parse(decimalString);

            Console.WriteLine($"   String to Int using Parse: \"{intString}\" -> {parsedInt}");
            Console.WriteLine($"   String to Decimal using Parse: \"{decimalString}\" -> {parsedDecimal}");

            // 5. TryParse Methods (Safe Parsing)
            Console.WriteLine("\n5. Using TryParse Methods (Safe Conversion):");
            
            string validNumber = "456";
            string invalidNumber = "abc";

            if (int.TryParse(validNumber, out int result))
            {
                Console.WriteLine($"   Successfully parsed \"{validNumber}\" to {result}");
            }

            if (!int.TryParse(invalidNumber, out int invalidResult))
            {
                Console.WriteLine($"   Failed to parse \"{invalidNumber}\" to integer");
            }

            // 6. Special Cases and Potential Issues
            Console.WriteLine("\n6. Special Cases and Potential Issues:");

            // Overflow example
            try
            {
                int maxInt = int.MaxValue;
                Console.WriteLine($"   Maximum int value: {maxInt}");
                int willOverflow = checked((int)(maxInt + 1L)); // This will throw an exception
            }
            catch (OverflowException)
            {
                Console.WriteLine("   Overflow detected: Can't convert number larger than int.MaxValue");
            }

            // Information loss example
            double largeDouble = 123.789;
            int truncatedInt = (int)largeDouble;
            Console.WriteLine($"   Information loss in casting: {largeDouble} -> {truncatedInt}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}