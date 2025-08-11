using System;

namespace InheritanceExample{
    // sealed class Animal{
    //     public void Speak(){
    //         Console.WriteLine("Animal speaks");
    //     }
    // }
    class Animal{
        public void Speak(){
            Console.WriteLine("Animal speaks");
        }
    }

    class Dog : Animal{
        public void Bark(){
            Console.WriteLine("Dog barks");
        }
    }

    class Program{
        static void Main(string[] args){
            Dog dog = new Dog();
            dog.Speak();
            dog.Bark();
        }
    }
}