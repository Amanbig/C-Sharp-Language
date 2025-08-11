using System;

namespace TypeCasting{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Type casting example");
            //Implicit casting
            // from smaller to larger type
            // char to int to long to float to double
            int myint = 4;
            double a = myint; // automatic casting

            //Explicit Casting
            // From larger to smaller type
            // double to float to long to int to char
            double mydouble = 4.5;
            int b = (int)mydouble; // manual casting


            int temp = 2;
            double mydouble2 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(temp));
            Console.WriteLine(Convert.ToDouble(temp));
            Console.WriteLine(Convert.ToInt32(mydouble2));
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Convert.ToInt64(temp));
            Console.WriteLine(Convert.ToBoolean(1));
        }
    }
}