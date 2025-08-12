using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Operators Demonstration\n");

            // 1. Arithmetic Operators
            Console.WriteLine("1. Arithmetic Operators:");
            int a = 10;
            int b = 3;
            
            Console.WriteLine($"   Given: a = {a}, b = {b}");
            Console.WriteLine($"   Addition:       a + b = {a + b}");
            Console.WriteLine($"   Subtraction:    a - b = {a - b}");
            Console.WriteLine($"   Multiplication: a * b = {a * b}");
            Console.WriteLine($"   Division:       a / b = {a / b}");
            Console.WriteLine($"   Modulus:        a % b = {a % b}");
            
            // Float division example
            double x = 10.0;
            double y = 3.0;
            Console.WriteLine($"   Float Division: {x} / {y} = {x / y:F2}");

            // Increment/Decrement
            int i = 5;
            Console.WriteLine($"\n   Increment/Decrement (starting with i = {i}):");
            Console.WriteLine($"   Pre-increment:  ++i = {++i}");  // i is now 6
            Console.WriteLine($"   Post-increment: i++ = {i++}");  // shows 6, then increments to 7
            Console.WriteLine($"   Pre-decrement:  --i = {--i}");  // i is now 6
            Console.WriteLine($"   Post-decrement: i-- = {i--}");  // shows 6, then decrements to 5
            Console.WriteLine($"   Final value of i: {i}");

            // 2. Comparison Operators
            Console.WriteLine("\n2. Comparison Operators:");
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine($"   Given: num1 = {num1}, num2 = {num2}");
            Console.WriteLine($"   Equal to:            num1 == num2 is {num1 == num2}");
            Console.WriteLine($"   Not equal to:        num1 != num2 is {num1 != num2}");
            Console.WriteLine($"   Greater than:        num1 > num2  is {num1 > num2}");
            Console.WriteLine($"   Less than:           num1 < num2  is {num1 < num2}");
            Console.WriteLine($"   Greater or equal to: num1 >= num2 is {num1 >= num2}");
            Console.WriteLine($"   Less or equal to:    num1 <= num2 is {num1 <= num2}");

            // 3. Logical Operators
            Console.WriteLine("\n3. Logical Operators:");
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine($"   Given: isTrue = {isTrue}, isFalse = {isFalse}");
            Console.WriteLine($"   AND:  isTrue && isFalse is {isTrue && isFalse}");
            Console.WriteLine($"   OR:   isTrue || isFalse is {isTrue || isFalse}");
            Console.WriteLine($"   NOT:  !isTrue is {!isTrue}");

            // 4. Bitwise Operators
            Console.WriteLine("\n4. Bitwise Operators:");
            int bits1 = 12;  // 1100 in binary
            int bits2 = 10;  // 1010 in binary
            Console.WriteLine($"   Given: bits1 = {bits1} (binary: {Convert.ToString(bits1, 2).PadLeft(4, '0')})");
            Console.WriteLine($"          bits2 = {bits2} (binary: {Convert.ToString(bits2, 2).PadLeft(4, '0')})");
            Console.WriteLine($"   Bitwise AND:  bits1 & bits2  = {bits1 & bits2}  (binary: {Convert.ToString(bits1 & bits2, 2).PadLeft(4, '0')})");
            Console.WriteLine($"   Bitwise OR:   bits1 | bits2  = {bits1 | bits2}  (binary: {Convert.ToString(bits1 | bits2, 2).PadLeft(4, '0')})");
            Console.WriteLine($"   Bitwise XOR:  bits1 ^ bits2  = {bits1 ^ bits2}  (binary: {Convert.ToString(bits1 ^ bits2, 2).PadLeft(4, '0')})");
            Console.WriteLine($"   Left Shift:   bits1 << 1     = {bits1 << 1}     (binary: {Convert.ToString(bits1 << 1, 2).PadLeft(4, '0')})");
            Console.WriteLine($"   Right Shift:  bits1 >> 1     = {bits1 >> 1}     (binary: {Convert.ToString(bits1 >> 1, 2).PadLeft(4, '0')})");

            // 5. Assignment Operators
            Console.WriteLine("\n5. Assignment Operators:");
            int c = 15;
            Console.WriteLine($"   Starting with c = {c}");
            Console.WriteLine($"   Add and assign:      c += 5  -> {c += 5}");
            Console.WriteLine($"   Subtract and assign: c -= 3  -> {c -= 3}");
            Console.WriteLine($"   Multiply and assign: c *= 2  -> {c *= 2}");
            Console.WriteLine($"   Divide and assign:   c /= 4  -> {c /= 4}");
            Console.WriteLine($"   Modulus and assign:  c %= 3  -> {c %= 3}");

            // 6. Conditional (Ternary) Operator
            Console.WriteLine("\n6. Conditional (Ternary) Operator:");
            int age = 20;
            string status = age >= 18 ? "Adult" : "Minor";
            Console.WriteLine($"   Age: {age}");
            Console.WriteLine($"   Status: {status}");

            // 7. Null Coalescing Operator
            Console.WriteLine("\n7. Null Coalescing Operator:");
            string name = null;
            string displayName = name ?? "Unknown";
            Console.WriteLine($"   Name: {displayName}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            Console.WriteLine($"c after right shift assignment: {c}");


            // Logical operators
            bool x1 = true;
            bool y1 = false;
            Console.WriteLine($"x1 AND y1: {x1 && y1}");
            Console.WriteLine($"x1 OR y1: {x1 || y1}");
            Console.WriteLine($"NOT x1: {!x1}");
            Console.WriteLine($"NOT y1: {!y1}");
        }
    }
}