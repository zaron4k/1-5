// Abstract Handler Class
using System;

public abstract class AbstractHandler
{
    public abstract void Open();
    public abstract void Create();
    public abstract void Change();
    public abstract void Save();
}

// XMLHandler Class
public class XMLHandler : AbstractHandler
{
    public override void Open() { Console.WriteLine("Открытие XML файла."); }
    public override void Create() { Console.WriteLine("Создание нового XML файла."); }
    public override void Change() { Console.WriteLine("Редактирование XML файла."); }
    public override void Save() { Console.WriteLine("Сохранение XML файла."); }
}

// TXTHandler Class
public class TXTHandler : AbstractHandler
{
    public override void Open() { Console.WriteLine("Открытие TXT файла."); }
    public override void Create() { Console.WriteLine("Создание нового TXT файла."); }
    public override void Change() { Console.WriteLine("Редактирование TXT файла."); }
    public override void Save() { Console.WriteLine("Сохранение TXT файла."); }
}

// DOCHandler Class
public class DOCHandler : AbstractHandler
{
    public override void Open() { Console.WriteLine("Открытие DOC файла."); }
    public override void Create() { Console.WriteLine("Создание нового DOC файла."); }
    public override void Change() { Console.WriteLine("Редактирование DOC файла."); }
    public override void Save() { Console.WriteLine("Сохранение DOC файла."); }
}

// Example Usage (in your Main method)
public class Program
{
    public static void Main(string[] args)
    {
        AbstractHandler xmlHandler = new XMLHandler();
        xmlHandler.Open();
        xmlHandler.Create();
        xmlHandler.Change();
        xmlHandler.Save();

        Console.WriteLine("---");

        AbstractHandler txtHandler = new TXTHandler();
        txtHandler.Open();
    }
}
