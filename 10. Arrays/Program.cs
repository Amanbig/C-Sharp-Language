using System;
using System.Linq;

namespace ArrayExample{
    class Program{
        static void Main(string[] args){
            string[] fruits = {"Apple", "Banana", "Cherry"};
            Console.WriteLine("Fruits array:");
            foreach(string fruit in fruits){
                Console.WriteLine(fruit);
            }
            Console.WriteLine($"The total number of fruits is {fruits.Length}");

            string[] vegetables = new string[4];
            vegetables[0] = "Carrot";
            vegetables[1] = "Broccoli";
            vegetables[2] = "Spinach";
            vegetables[3] = "Pepper";

            Console.WriteLine("Vegetables array:");
            foreach(string vegetable in vegetables){
                Console.WriteLine(vegetable);
            }

            string[] cars = new string[3]{"Toyota", "Honda", "Ford"};
            Console.WriteLine("Cars array:");
            foreach(string car in cars){
                Console.WriteLine(car);
            }

            string[] grains = new string[]{"Rice", "Wheat", "Oats"};
            Console.WriteLine("Grains array:");
            foreach(string grain in grains){
                Console.WriteLine(grain);
            }

            int[] ar = new int[5]{1,  3,  2, 4, 5};
            Console.WriteLine("Array elements:");
            foreach(int num in ar){
                Console.WriteLine(num);
            }

            Array.Sort(ar);
            Console.WriteLine("Sorted array elements:");
            foreach(int num in ar){
                Console.WriteLine(num);
            }

            Console.WriteLine("Max element is" + ar.Max());
            Console.WriteLine("Min element is" + ar.Min());
            Console.WriteLine("Sum of elements is" + ar.Sum());

        }
    }
}