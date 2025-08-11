using System;

namespace ClassesExample{
    class Program{
        static void Main(string[] args){
            Car car = new Car();
            car.make = "Toyota";
            Console.WriteLine("Car make: " + car.make);
            Car car2 = new Car();
            car2.make = "Honda";
            Console.WriteLine("Car make: " + car2.make);

            MyClass myObject = new MyClass();
            myObject.DisplayInfo();

            Test testObject = new Test("Alice", 30);
            testObject.Display();

            Person person = new Person();
            person.Num = 5;
            Console.WriteLine("Person Num: " + person.Num);
        }
    }
}

class Car{
    public string make;
}

class MyClass{
    public string color = "red";
    public int speed = 100;
    public void DisplayInfo(){
        Console.WriteLine("Color: " + color + ", Speed: " + speed);
    }
}

class Test{
    public string name;
    public int age;
    public Test(string name, int age){
        this.name = name;
        this.age = age;
    }
    public void Display(){
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }
}

class Person{
    private int num;
    public int Num{
        get { return num; }
        set { num = value; }
    }
}