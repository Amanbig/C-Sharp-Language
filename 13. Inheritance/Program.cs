using System;

namespace InheritanceExample
{
    #region Base Classes
    /// <summary>
    /// Base class demonstrating inheritance fundamentals
    /// </summary>
    public class Animal
    {
        // Protected field - accessible in derived classes
        protected string name;
        
        // Private field - only accessible in this class
        private readonly string species;
        
        // Public property with protected setter
        public int Age { get; protected set; }

        // Constructor
        public Animal(string name, string species, int age)
        {
            this.name = name;
            this.species = species;
            this.Age = age;
        }

        // Virtual method that can be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine($"{name} makes a generic sound");
        }

        // Method that can't be overridden
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Species: {species}, Age: {Age}");
        }

        // Protected method - accessible in derived classes
        protected virtual string GetSpecialAbility()
        {
            return "No special ability";
        }
    }

    /// <summary>
    /// Abstract base class demonstrating abstract members
    /// </summary>
    public abstract class Pet
    {
        public string Name { get; set; }
        
        // Abstract method - must be implemented by derived classes
        public abstract void Play();
        
        // Virtual method - can be overridden but has default implementation
        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping peacefully");
        }
    }
    #endregion

    #region Derived Classes
    /// <summary>
    /// Derived class demonstrating inheritance and method overriding
    /// </summary>
    public class Dog : Animal
    {
        private bool isTrained;

        public Dog(string name, int age, bool isTrained) 
            : base(name, "Dog", age)
        {
            this.isTrained = isTrained;
        }

        // Override virtual method
        public override void MakeSound()
        {
            Console.WriteLine($"{name} says: Woof!");
        }

        // New method specific to Dog
        public void Fetch()
        {
            if (isTrained)
                Console.WriteLine($"{name} fetches the ball");
            else
                Console.WriteLine($"{name} looks confused");
        }

        protected override string GetSpecialAbility()
        {
            return "Excellent sense of smell";
        }
    }

    /// <summary>
    /// Another derived class demonstrating multiple inheritance levels
    /// </summary>
    public class Cat : Animal
    {
        private int lives = 9;

        public Cat(string name, int age) 
            : base(name, "Cat", age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{name} says: Meow!");
        }

        public void Land()
        {
            Console.WriteLine($"{name} lands gracefully on their feet");
        }

        protected override string GetSpecialAbility()
        {
            return $"Has {lives} lives remaining";
        }
    }

    /// <summary>
    /// Class implementing abstract base class
    /// </summary>
    public class Hamster : Pet
    {
        public override void Play()
        {
            Console.WriteLine($"{Name} runs in their wheel");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping in their little house");
        }
    }
    #endregion

    #region Sealed Class Example
    /// <summary>
    /// Sealed class that cannot be inherited from
    /// </summary>
    public sealed class GoldFish : Pet
    {
        public override void Play()
        {
            Console.WriteLine($"{Name} swims in circles");
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Inheritance Demonstration\n");

            // 1. Basic Inheritance
            Console.WriteLine("1. Basic Inheritance:");
            Dog rex = new Dog("Rex", 3, true);
            rex.DisplayInfo();
            rex.MakeSound();
            rex.Fetch();

            // 2. Another Derived Class
            Console.WriteLine("\n2. Another Derived Class:");
            Cat whiskers = new Cat("Whiskers", 2);
            whiskers.DisplayInfo();
            whiskers.MakeSound();
            whiskers.Land();

            // 3. Abstract Class Usage
            Console.WriteLine("\n3. Abstract Class Usage:");
            Hamster hammy = new Hamster { Name = "Hammy" };
            hammy.Play();
            hammy.Sleep();

            // 4. Polymorphism through Inheritance
            Console.WriteLine("\n4. Polymorphism through Inheritance:");
            Animal[] animals = { rex, whiskers };
            foreach (Animal animal in animals)
            {
                animal.MakeSound();  // Calls the appropriate overridden method
            }

            // 5. Sealed Class
            Console.WriteLine("\n5. Sealed Class Usage:");
            GoldFish goldie = new GoldFish { Name = "Goldie" };
            goldie.Play();

            // 6. Type Checking and Casting
            Console.WriteLine("\n6. Type Checking and Casting:");
            Animal someAnimal = new Dog("Max", 2, false);
            
            // Using 'is' operator
            if (someAnimal is Dog)
            {
                Dog dog = (Dog)someAnimal;
                dog.Fetch();
            }

            // Using 'as' operator
            Cat maybeCat = someAnimal as Cat;
            if (maybeCat != null)
            {
                maybeCat.Land();
            }
            else
            {
                Console.WriteLine("This animal is not a cat");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}