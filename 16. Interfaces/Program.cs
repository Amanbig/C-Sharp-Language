using System;

namespace InterfacesExample{
    interface IAnimal{
        void Speak();
    }

    class Dog : IAnimal{
        public void Speak(){
            Console.WriteLine("Dog barks");
        }
    }

    class Program{
        static void Main(string[] args){
            IAnimal myDog = new Dog();
            myDog.Speak();
        }
    }
}