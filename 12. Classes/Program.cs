using System;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Classes Demonstration\n");

            // 1. Basic Class Usage
            Console.WriteLine("1. Basic Class Usage:");
            Car car1 = new Car("Toyota", "Camry", 2022);
            car1.DisplayInfo();
            
            Car car2 = new Car("Honda", "Civic", 2023);
            car2.DisplayInfo();

            // 2. Properties and Auto-implemented Properties
            Console.WriteLine("\n2. Properties Usage:");
            Person person = new Person("John Doe", 30);
            person.Email = "john@example.com"; // Using property
            Console.WriteLine($"Person: {person.FullName}, Age: {person.Age}, Email: {person.Email}");
            Console.WriteLine($"Is Adult: {person.IsAdult}"); // Read-only property

            // 3. Constructor and Method Overloading
            Console.WriteLine("\n3. Constructor Overloading:");
            BankAccount account1 = new BankAccount("12345");
            BankAccount account2 = new BankAccount("67890", 1000.0m);

            account1.Deposit(500.0m);
            account2.Withdraw(200.0m);

            account1.DisplayBalance();
            account2.DisplayBalance();

            // 4. Static Members
            Console.WriteLine("\n4. Static Members:");
            Console.WriteLine($"Total Accounts Created: {BankAccount.AccountCount}");
            Console.WriteLine($"Bank Name: {BankAccount.BankName}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Represents a car with basic properties
    /// </summary>
    class Car
    {
        // Private fields
        private string _make;
        private string _model;
        private int _year;

        // Constructor
        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        // Method
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {_year} {_make} {_model}");
        }
    }

    /// <summary>
    /// Demonstrates properties and validation
    /// </summary>
    class Person
    {
        // Auto-implemented properties
        public string FullName { get; private set; }
        public int Age { get; private set; }

        // Property with backing field
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains("@"))
                    _email = value;
                else
                    throw new ArgumentException("Invalid email format");
            }
        }

        // Read-only property
        public bool IsAdult => Age >= 18;

        // Constructor
        public Person(string name, int age)
        {
            FullName = name;
            Age = age;
        }
    }

    /// <summary>
    /// Demonstrates static members, constructor overloading, and encapsulation
    /// </summary>
    class BankAccount
    {
        // Static fields
        public static string BankName { get; } = "Example Bank";
        public static int AccountCount { get; private set; }

        // Instance fields
        private readonly string _accountNumber;
        private decimal _balance;

        // Constructor overloading
        public BankAccount(string accountNumber) : this(accountNumber, 0) { }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            _accountNumber = accountNumber;
            _balance = initialBalance;
            AccountCount++;
        }

        // Methods
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive");
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive");
            if (amount > _balance)
                throw new InvalidOperationException("Insufficient funds");
            _balance -= amount;
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Account {_accountNumber} balance: ${_balance:F2}");
        }
    }
}
    private int num;
    public int Num{
        get { return num; }
        set { num = value; }
    }
}