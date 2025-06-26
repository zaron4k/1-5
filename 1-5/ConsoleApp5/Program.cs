using System;

// Abstract base class Tovar (Goods)
public abstract class Tovar
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Tovar(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    // Abstract method to calculate the total cost.  Must be implemented by derived classes.
    public abstract decimal CalcSum();

    // Regular method to print information about the product
    public virtual void Print()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}");
    }
}

// Derived class Obuv (Shoes)
public class Obuv : Tovar
{
    public int Quantity { get; set; }
    public double Size { get; set; }

    public Obuv(string name, decimal price, int quantity, double size) : base(name, price)
    {
        Quantity = quantity;
        Size = size;
    }

    // Override the abstract CalcSum method for shoes.
    public override decimal CalcSum()
    {
        return Price * Quantity; // Simple calculation: price multiplied by quantity
    }

    //Override Print to include shoe-specific information
    public override void Print()
    {
        Console.WriteLine($"Type: Shoes, Name: {Name}, Price: {Price}, Quantity: {Quantity}, Size: {Size}");
    }
}

// Derived class Odejda (Clothing)
public class Odejda : Tovar
{
    public string Color { get; set; }
    public double Mass { get; set; } // in grams, for example.

    public Odejda(string name, decimal price, string color, double mass) : base(name, price)
    {
        Color = color;
        Mass = mass;
    }

    // Override the abstract CalcSum method for clothing.
    public override decimal CalcSum()
    {
        return Price * 1.2m; // Add a markup of 20% (example calculation)
    }

    //Override Print to include clothing-specific information
    public override void Print()
    {
        Console.WriteLine($"Type: Clothing, Name: {Name}, Price: {Price}, Color: {Color}, Mass: {Mass}");
    }
}

// Derived class Posuda (Dishes)
public class Posuda : Tovar
{
    public int Count { get; set; } // Number of items in the set.

    public Posuda(string name, decimal price, int count) : base(name, price)
    {
        Count = count;
    }

    // Override the abstract CalcSum method for dishes.
    public override decimal CalcSum()
    {
        return Price * Count; // Simple calculation: price multiplied by count
    }

    //Override Print to include dish-specific information
    public override void Print()
    {
        Console.WriteLine($"Type: Dishes, Name: {Name}, Price: {Price}, Count: {Count}");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        // Create instances of the derived classes
        Obuv shoes = new Obuv("Sneakers", 50.0m, 2, 42.5);
        Odejda clothing = new Odejda("T-Shirt", 25.0m, "Blue", 150.0);
        Posuda dishes = new Posuda("Plate Set", 75.0m, 4);

        // Demonstrate the CalcSum method
        Console.WriteLine($"Total cost of shoes: {shoes.CalcSum()}");
        Console.WriteLine($"Total cost of clothing: {clothing.CalcSum()}");
        Console.WriteLine($"Total cost of dishes: {dishes.CalcSum()}");

        //Demonstrate Print Method
        shoes.Print();
        clothing.Print();
        dishes.Print();


        Console.ReadKey(); // Keep the console window open until a key is pressed.
    }
}
