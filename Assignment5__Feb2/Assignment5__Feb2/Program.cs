using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5__Feb2
{ 

//SingleInheritance

    class Animal
    {
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Sleep();
        }
    }
}
/////////////////////////////////////////////////////////

//Multilevel Inheritence

class GrandFather
{
    public void Property()
    {
        Console.WriteLine("GrandFather's Property");
    }
}
class Father : GrandFather
{
    public void Money()
    {
        Console.WriteLine("Father's Money");
    }
}
class Son : Father
{
    public void Land()
    {
        Console.WriteLine("Son's Land");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Son son = new Son();
        son.Property();
        son.Money();
        son.Land();
    }
}

//////////////////////////////////////////////////////////

//Hierarcheal Inheritence

class Vehicle
{
    public void Name()
    {
        Console.WriteLine("Vehicle Name is Bus");
    }
}
class Car : Vehicle
{
    public void Color()
    {
        Console.WriteLine("Car Color is Red");
    }
}
class Bike : Vehicle
{
    public void Mileage()
    {
        Console.WriteLine("Bike mileage is 40");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Color();
        car.Name();
        Bike bike = new Bike();
        bike.Mileage();
        bike.Name();
    }
}





