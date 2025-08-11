using System;
using System.Linq;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Arrays Demonstration\n");

            // 1. Array Declaration and Initialization
            Console.WriteLine("1. Different ways to declare and initialize arrays:");
            
            // Method 1: Array initialization with values
            string[] fruits = { "Apple", "Banana", "Cherry" };
            
            // Method 2: Fixed size array with separate initialization
            string[] vegetables = new string[4];
            vegetables[0] = "Carrot";
            vegetables[1] = "Broccoli";
            vegetables[2] = "Spinach";
            vegetables[3] = "Pepper";
            
            // Method 3: Array declaration with size and values
            int[] numbers = new int[5] { 1, 3, 2, 4, 5 };

            // 2. Accessing and Displaying Arrays
            Console.WriteLine("\n2. Iterating through arrays:");
            
            // Using foreach loop
            Console.WriteLine("\nFruits (foreach loop):");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"  {fruit}");
            }

            // Using for loop with index
            Console.WriteLine("\nVegetables (for loop with index):");
            for (int i = 0; i < vegetables.Length; i++)
            {
                Console.WriteLine($"  [{i}] {vegetables[i]}");
            }

            // 3. Array Methods and Properties
            Console.WriteLine("\n3. Array operations:");
            
            // Sort the numbers array
            Console.WriteLine("\nOriginal numbers:");
            Console.WriteLine($"  [{string.Join(", ", numbers)}]");
            
            Array.Sort(numbers);
            Console.WriteLine("Sorted numbers:");
            Console.WriteLine($"  [{string.Join(", ", numbers)}]");

            // Array properties and LINQ methods
            Console.WriteLine($"\nArray statistics:");
            Console.WriteLine($"  Length: {numbers.Length}");
            Console.WriteLine($"  Sum: {numbers.Sum()}");
            Console.WriteLine($"  Average: {numbers.Average():F2}");
            Console.WriteLine($"  Maximum: {numbers.Max()}");
            Console.WriteLine($"  Minimum: {numbers.Min()}");

            // 4. Multi-dimensional Arrays
            Console.WriteLine("\n4. Multi-dimensional array example:");
            int[,] matrix = new int[2, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            // 5. Array Methods
            Console.WriteLine("\n5. Additional array methods:");
            
            // Reverse an array
            Array.Reverse(fruits);
            Console.WriteLine($"  Reversed fruits: [{string.Join(", ", fruits)}]");
            
            // Search in array
            string searchFruit = "Banana";
            int index = Array.IndexOf(fruits, searchFruit);
            Console.WriteLine($"  Index of '{searchFruit}': {index}");

            // Copy array
            string[] fruitsCopy = new string[fruits.Length];
            Array.Copy(fruits, fruitsCopy, fruits.Length);
            Console.WriteLine($"  Copied array: [{string.Join(", ", fruitsCopy)}]");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
            Console.WriteLine("Sum of elements is" + ar.Sum());

            int[,] multiDimensionalArray = new int[2, 3]{
                {1, 2, 3},
                {4, 5, 6}
            };
            Console.WriteLine("Multidimensional array elements:");
            for(int i =0;i<multiDimensionalArray.GetLength(0);i++){
                for(int j=0;j<multiDimensionalArray.GetLength(1);j++){
                    Console.Write(multiDimensionalArray[i,j]+" ");
                }
            }

        }
    }
}