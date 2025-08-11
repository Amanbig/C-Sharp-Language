using System;

namespace AbstractionExample{
    abstract class Animal{
        public abstract void Speak();
    }

    class Dog : Animal{
        public override void Speak(){
            Console.WriteLine("Dog barks");
        }
    }

    class Program{
        static void Main(string[] args){
            Animal myDog = new Dog();
            myDog.Speak();
        }
    }
}