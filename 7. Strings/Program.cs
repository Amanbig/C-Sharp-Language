using System;
using System.Text;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# String Operations Demonstration\n");

            // 1. String Creation and Basic Properties
            Console.WriteLine("1. String Creation and Basic Properties:");
            string str1 = "Hello, World!";
            string str2 = new string('*', 10);
            
            Console.WriteLine($"   Original string: \"{str1}\"");
            Console.WriteLine($"   Length: {str1.Length}");
            Console.WriteLine($"   Repeated character string: {str2}");

            // 2. String Manipulation
            Console.WriteLine("\n2. String Manipulation:");
            Console.WriteLine($"   Uppercase: {str1.ToUpper()}");
            Console.WriteLine($"   Lowercase: {str1.ToLower()}");
            Console.WriteLine($"   Trim spaces: \"{" Hello ".Trim()}\"");
            Console.WriteLine($"   Replace: {str1.Replace("World", "C#")}");

            // 3. String Concatenation
            Console.WriteLine("\n3. String Concatenation:");
            string firstName = "John";
            string lastName = "Doe";
            
            // Using + operator
            string fullName1 = firstName + " " + lastName;
            Console.WriteLine($"   Using + operator: {fullName1}");
            
            // Using string.Format
            string fullName2 = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine($"   Using string.Format: {fullName2}");
            
            // Using string interpolation
            string fullName3 = $"{firstName} {lastName}";
            Console.WriteLine($"   Using string interpolation: {fullName3}");
            
            // Using StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append(firstName);
            sb.Append(" ");
            sb.Append(lastName);
            Console.WriteLine($"   Using StringBuilder: {sb}");

            // 4. String Searching
            Console.WriteLine("\n4. String Searching:");
            string sentence = "The quick brown fox jumps over the lazy dog";
            
            Console.WriteLine($"   Original sentence: \"{sentence}\"");
            Console.WriteLine($"   Contains 'fox': {sentence.Contains("fox")}");
            Console.WriteLine($"   Index of 'quick': {sentence.IndexOf("quick")}");
            Console.WriteLine($"   Last index of 'the': {sentence.LastIndexOf("the")}");
            Console.WriteLine($"   Starts with 'The': {sentence.StartsWith("The")}");
            Console.WriteLine($"   Ends with 'dog': {sentence.EndsWith("dog")}");

            // 5. String Splitting and Joining
            Console.WriteLine("\n5. String Splitting and Joining:");
            string csvData = "John,Doe,30,New York";
            string[] parts = csvData.Split(',');
            
            Console.WriteLine("   Split string:");
            foreach (string part in parts)
            {
                Console.WriteLine($"   - {part}");
            }
            
            string joined = string.Join(" | ", parts);
            Console.WriteLine($"   Joined with separator: {joined}");

            // 6. String Comparison
            Console.WriteLine("\n6. String Comparison:");
            string str3 = "Hello";
            string str4 = "hello";
            
            Console.WriteLine($"   Exact comparison: {str3 == str4}");
            Console.WriteLine($"   Case-insensitive comparison: {str3.Equals(str4, StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"   Compare result: {string.Compare(str3, str4)}");

            // 7. Substring and Character Access
            Console.WriteLine("\n7. Substring and Character Access:");
            string text = "C# Programming";
            Console.WriteLine($"   Original text: \"{text}\"");
            Console.WriteLine($"   Substring(3): \"{text.Substring(3)}\"");
            Console.WriteLine($"   Substring(3, 11): \"{text.Substring(3, 8)}\"");
            Console.WriteLine($"   First character: '{text[0]}'");
            Console.WriteLine($"   Last character: '{text[text.Length - 1]}'");

            // 8. Special Strings
            Console.WriteLine("\n8. Special Strings:");
            string path = "C:\\Program Files\\dotnet"; // Regular string
            string verbatimPath = @"C:\Program Files\dotnet"; // Verbatim string
            string multiLine = @"This is a
multi-line
string";
            
            Console.WriteLine($"   Regular string path: {path}");
            Console.WriteLine($"   Verbatim string path: {verbatimPath}");
            Console.WriteLine("   Multi-line string:");
            Console.WriteLine(multiLine);

            // 9. String Formatting
            Console.WriteLine("\n9. String Formatting:");
            double price = 123.45;
            DateTime now = DateTime.Now;
            
            Console.WriteLine($"   Currency: {price:C}");
            Console.WriteLine($"   Number with 2 decimals: {price:F2}");
            Console.WriteLine($"   Percentage: {0.75:P}");
            Console.WriteLine($"   Date: {now:d}");
            Console.WriteLine($"   Time: {now:T}");
            Console.WriteLine($"   Custom format: {now:yyyy-MM-dd HH:mm:ss}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}