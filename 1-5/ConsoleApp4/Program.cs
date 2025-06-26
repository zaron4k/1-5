// Abstract Person Class
using System;

public abstract class Person
{
    public string Name { get; set; }

    public virtual void SayGreeting()
    {
        Console.WriteLine("Hello"); // Default greeting
    }
}

// RussianPerson Class
public class RussianPerson : Person
{
    public RussianPerson(string name) : base(name) { }

    public override void SayGreeting()
    {
        Console.WriteLine($"Привет, я {Name}");
    }
}

// AmericanPerson Class
public class AmericanPerson : Person
{
    public AmericanPerson(string name) : base(name) { }

    public override void SayGreeting()
    {
        Console.WriteLine($"Hi, I'm {Name}");
    }
}

// Example Usage (in your Main method)
public class Program
{
    public static void Main(string[] args)
    {
        Person russian = new RussianPerson("Ivan");
        russian.SayGreeting();

        Person american = new AmericanPerson("John");
        american.SayGreeting();
    }
}
