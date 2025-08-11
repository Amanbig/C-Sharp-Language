using System;

namespace PolymorhpismExample{

    class Animal {
        public virtual void Speak() {
            Console.WriteLine("Animal speaks");
        }
    }

    class Dog : Animal {
        public override void Speak() {
            Console.WriteLine("Dog barks");
        }
    }

    class Program {
        static void Main(string[] args) {
            Animal myAnimal = new Animal();
            myAnimal.Speak();

            Dog myDog = new Dog();
            myDog.Speak();
        }
    }
}