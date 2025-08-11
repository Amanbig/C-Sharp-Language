using System;

namespace EnumsExample{
    enum Days{
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program{
        static void Main(string[] args){
            Days today = Days.Monday;
            Console.WriteLine("Today is " + today);
        }
    }
}