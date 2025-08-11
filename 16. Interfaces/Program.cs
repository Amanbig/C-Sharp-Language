using System;
using System.Collections.Generic;

namespace InterfacesExample
{
    #region Basic Interface
    /// <summary>
    /// Basic interface defining animal behavior
    /// </summary>
    interface IAnimal
    {
        // Property declaration in interface
        string Name { get; set; }
        
        // Method declaration
        void Speak();
        
        // Default interface method (C# 8.0+)
        void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping...");
        }
    }
    #endregion

    #region Additional Interfaces
    /// <summary>
    /// Interface for movement capabilities
    /// </summary>
    interface IMoveable
    {
        void Move();
    }

    /// <summary>
    /// Interface for feeding behavior
    /// </summary>
    interface IFeedable
    {
        void Eat();
        bool IsHungry { get; }
    }
    #endregion

    #region Classes implementing interfaces
    /// <summary>
    /// Dog class implementing multiple interfaces
    /// </summary>
    class Dog : IAnimal, IMoveable, IFeedable
    {
        public string Name { get; set; }
        private bool _isHungry = true;
        
        public Dog(string name)
        {
            Name = name;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} is running on four legs");
        }

        public void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating dog food");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        public bool IsHungry => _isHungry;
    }

    /// <summary>
    /// Bird class implementing multiple interfaces
    /// </summary>
    class Bird : IAnimal, IMoveable
    {
        public string Name { get; set; }

        public Bird(string name)
        {
            Name = name;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} says: Tweet!");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} is flying in the sky");
        }
    }
    #endregion

    #region Interface with generic type
    /// <summary>
    /// Generic interface for data storage
    /// </summary>
    interface IRepository<T>
    {
        void Add(T item);
        T Get(int id);
        IEnumerable<T> GetAll();
    }

    /// <summary>
    /// Simple implementation of generic repository
    /// </summary>
    class AnimalRepository : IRepository<IAnimal>
    {
        private List<IAnimal> _animals = new List<IAnimal>();

        public void Add(IAnimal item)
        {
            _animals.Add(item);
        }

        public IAnimal Get(int id)
        {
            return _animals[id];
        }

        public IEnumerable<IAnimal> GetAll()
        {
            return _animals;
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Interfaces Demonstration\n");

            // 1. Basic interface usage
            Console.WriteLine("1. Basic Interface Usage:");
            IAnimal dog = new Dog("Buddy");
            dog.Speak();
            dog.Sleep(); // Using default interface method

            // 2. Multiple interface implementation
            Console.WriteLine("\n2. Multiple Interface Implementation:");
            Dog rex = new Dog("Rex");
            rex.Speak();
            rex.Move();
            rex.Eat();
            rex.Eat(); // Second attempt when not hungry

            Bird sparrow = new Bird("Tweety");
            sparrow.Speak();
            sparrow.Move();

            // 3. Interface as type
            Console.WriteLine("\n3. Interface as Type in Collections:");
            List<IMoveable> moveableAnimals = new List<IMoveable>
            {
                new Dog("Max"),
                new Bird("Robin")
            };

            foreach (var animal in moveableAnimals)
            {
                animal.Move();
            }

            // 4. Generic interface usage
            Console.WriteLine("\n4. Generic Interface Usage:");
            IRepository<IAnimal> animalRepo = new AnimalRepository();
            animalRepo.Add(new Dog("Charlie"));
            animalRepo.Add(new Bird("Polly"));

            Console.WriteLine("All animals in repository:");
            foreach (var animal in animalRepo.GetAll())
            {
                animal.Speak();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}