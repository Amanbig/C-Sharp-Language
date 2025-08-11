using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Math Operations Demonstration\n");

            // 1. Basic Math Operations
            Console.WriteLine("1. Basic Math Operations:");
            int a = 10;
            int b = 3;
            double x = 3.7;
            double y = 2.2;

            Console.WriteLine($"   Given: a = {a}, b = {b}, x = {x}, y = {y}");
            Console.WriteLine($"   Maximum:          Math.Max(a, b)    = {Math.Max(a, b)}");
            Console.WriteLine($"   Minimum:          Math.Min(a, b)    = {Math.Min(a, b)}");
            Console.WriteLine($"   Absolute Value:   Math.Abs(-15)     = {Math.Abs(-15)}");
            Console.WriteLine($"   Power:            Math.Pow(2, 3)    = {Math.Pow(2, 3)}");
            Console.WriteLine($"   Square Root:      Math.Sqrt(16)     = {Math.Sqrt(16)}");

            // 2. Rounding Operations
            Console.WriteLine("\n2. Rounding Operations:");
            double number = 3.14159;
            Console.WriteLine($"   Original number: {number}");
            Console.WriteLine($"   Round:           Math.Round({number})      = {Math.Round(number)}");
            Console.WriteLine($"   Round to 2 dec:  Math.Round({number}, 2)   = {Math.Round(number, 2)}");
            Console.WriteLine($"   Floor:           Math.Floor({number})      = {Math.Floor(number)}");
            Console.WriteLine($"   Ceiling:         Math.Ceiling({number})    = {Math.Ceiling(number)}");
            Console.WriteLine($"   Truncate:        Math.Truncate({number})   = {Math.Truncate(number)}");

            // 3. Trigonometric Functions
            Console.WriteLine("\n3. Trigonometric Functions:");
            double angle = Math.PI / 4; // 45 degrees
            Console.WriteLine($"   Angle: {angle} radians ({angle * 180 / Math.PI} degrees)");
            Console.WriteLine($"   Sine:             Math.Sin(angle)    = {Math.Sin(angle):F4}");
            Console.WriteLine($"   Cosine:           Math.Cos(angle)    = {Math.Cos(angle):F4}");
            Console.WriteLine($"   Tangent:          Math.Tan(angle)    = {Math.Tan(angle):F4}");
            
            // Inverse trigonometric functions
            double value = 0.707; // approximately sin(45°)
            Console.WriteLine($"   Arc Sine:         Math.Asin({value})   = {Math.Asin(value):F4} radians");
            Console.WriteLine($"   Arc Cosine:       Math.Acos({value})   = {Math.Acos(value):F4} radians");
            Console.WriteLine($"   Arc Tangent:      Math.Atan(1.0)    = {Math.Atan(1.0):F4} radians");

            // 4. Logarithmic Functions
            Console.WriteLine("\n4. Logarithmic Functions:");
            double num = 100;
            Console.WriteLine($"   Natural Log:      Math.Log({num})     = {Math.Log(num):F4}");
            Console.WriteLine($"   Log Base-10:      Math.Log10({num})   = {Math.Log10(num):F4}");
            Console.WriteLine($"   Exponential:      Math.Exp(1)       = {Math.Exp(1):F4}"); // e^1

            // 5. Constants and Special Values
            Console.WriteLine("\n5. Mathematical Constants:");
            Console.WriteLine($"   PI (π):           Math.PI           = {Math.PI}");
            Console.WriteLine($"   Euler's Number:   Math.E            = {Math.E}");

            // 6. Advanced Operations
            Console.WriteLine("\n6. Advanced Operations:");
            Console.WriteLine($"   Hypotenuse:       Math.Hypot(3, 4)  = {Math.Sqrt(Math.Pow(3, 2) + Math.Pow(4, 2))}");
            Console.WriteLine($"   Sign:             Math.Sign(-10)    = {Math.Sign(-10)}");
            Console.WriteLine($"   Distance:         Math.Max(Math.Abs(5), Math.Abs(-8)) = {Math.Max(Math.Abs(5), Math.Abs(-8))}");

            // 7. Practical Examples
            Console.WriteLine("\n7. Practical Examples:");
            
            // Calculate area of a circle
            double radius = 5;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"   Area of circle (radius={radius}): {area:F2}");

            // Calculate compound interest
            double principal = 1000;
            double rate = 0.05; // 5%
            int years = 3;
            double amount = principal * Math.Pow(1 + rate, years);
            Console.WriteLine($"   Compound Interest (${principal} at {rate*100}% for {years} years): ${amount:F2}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}