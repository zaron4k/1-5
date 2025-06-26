// Abstract Vehicle Class
using System;

public abstract class Vehicle
{
    public double Price { get; set; }
    public double Speed { get; set; }
    public int Year { get; set; }

    protected Vehicle(double price, double speed, int year)
    {
        Price = price;
        Speed = speed;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Цена: {Price}, Скорость: {Speed}, Год выпуска: {Year}");
    }
}

// Plane Class
public class Plane : Vehicle
{
    public int PassengerCapacity { get; set; }
    public double Altitude { get; set; }

    public Plane(double price, double speed, int year, int passengerCapacity, double altitude) : base(price, speed, year)
    {
        PassengerCapacity = passengerCapacity;
        Altitude = altitude;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Пассажировместимость: {PassengerCapacity}, Высота: {Altitude}");
    }
}

// Ship Class
public class Ship : Vehicle
{
    public string PortOfRegistry { get; set; }
    public int PassengerCapacity { get; set; }

    public Ship(double price, double speed, int year, string portOfRegistry, int passengerCapacity) : base(price, speed, year)
    {
        PortOfRegistry = portOfRegistry;
        PassengerCapacity = passengerCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Порт приписки: {PortOfRegistry}, Пассажировместимость: {PassengerCapacity}");
    }
}

// Example Usage (in your Main method)
public class Program
{
    public static void Main(string[] args)
    {
        Plane plane = new Plane(1000000, 800, 2020, 300, 10000);
        Ship ship = new Ship(500000, 25, 2015, "Odessa", 500);

        plane.DisplayInfo();
        ship.DisplayInfo();
    }
}
