// Pupil Abstract Class
using System;

public abstract class Pupil
{
    public string Surname { get; set; }

    protected Pupil(string surname)
    {
        Surname = surname;
    }

    public abstract void Study();
    public abstract void Read();
    public abstract void Write();
    public abstract void Relax();
}

// ExcellentPupil (Derived Class)
public class ExcelentPupil : Pupil
{
    public ExcelentPupil(string surname) : base(surname) { }

    public override void Study() { Console.WriteLine($"{Surname} изучает материал очень быстро."); }
    public override void Read() { Console.WriteLine($"{Surname} читает с большим интересом."); }
    public override void Write() { Console.WriteLine($"{Surname} пишет аккуратно и грамотно."); }
    public override void Relax() { Console.WriteLine($"{Surname} отдыхает, занимаясь любимым хобби."); }
}

// GoodPupil (Derived Class)
public class GoodPupil : Pupil
{
    public GoodPupil(string surname) : base(surname) { }

    public override void Study() { Console.WriteLine($"{Surname} усердно учится."); }
    public override void Read() { Console.WriteLine($"{Surname} читает внимательно."); }
    public override void Write() { Console.WriteLine($"{Surname} пишет старательно."); }
    public override void Relax() { Console.WriteLine($"{Surname} отдыхает, смотря телевизор."); }
}

// BadPupil (Derived Class)
public class BadPupil : Pupil
{
    public BadPupil(string surname) : base(surname) { }

    public override void Study() { Console.WriteLine($"{Surname} учится неохотно."); }
    public override void Read() { Console.WriteLine($"{Surname} читает невнимательно."); }
    public override void Write() { Console.WriteLine($"{Surname} пишет небрежно."); }
    public override void Relax() { Console.WriteLine($"{Surname} отдыхает, играя в видеоигры."); }
}

// ClassRoom Class
public class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils) // Allows 2 or 3 arguments
    {
        if (pupils == null) { pupils = new Pupil[0]; }
        else if (pupils.Length > 4) { pupils = new Pupil[4]; Array.Copy(pupils, pupils, 4); }  // Limit to 4
        else { this.pupils = pupils; }

        if (pupils.Length < 4)
        {
            // Add default pupils if needed.  This is a placeholder - replace with actual logic.
            while (this.pupils.Length < 4)
            {
                this.pupils[this.pupils.Length] = new GoodPupil("DefaultSurname"); //Example
            }
        }

    }

    public void DisplayPupilActions()
    {
        foreach (Pupil pupil in pupils)
        {
            Console.WriteLine($"Ученик {pupil.Surname}:");
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
        }
    }
}

// Example Usage (in your Main method)
public class Program
{
    public static void Main(string[] args)
    {
        ClassRoom room = new ClassRoom(new ExcelentPupil("Ivanov"), new GoodPupil("Petrov")); // 2 pupils
        room.DisplayPupilActions();

        ClassRoom fullRoom = new ClassRoom(new ExcelentPupil("Ivanov"), new GoodPupil("Petrov"), new BadPupil("Sidorov"), new ExcelentPupil("Kuznetsov")); //4 pupils
        fullRoom.DisplayPupilActions();
    }
}
