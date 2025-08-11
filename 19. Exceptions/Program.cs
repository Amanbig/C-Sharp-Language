using System;

namespace ExceptionsExample{
    class Program{
        static void Main(string[] args){
            try{
                int[] numbers = {1, 2, 3};
                Console.WriteLine(numbers[5]);
            }catch(IndexOutOfRangeException e){
                Console.WriteLine("Error: " + e.Message);
            }
            finally
{
  Console.WriteLine("The 'try catch' is finished.");
}
        }
    }
}