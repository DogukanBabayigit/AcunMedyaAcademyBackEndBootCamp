namespace _01_Zoological_Application;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }


    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Hayvan bir ses çıkardı.");
    }
}

public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age, "Lion") { }

    public override void MakeSound()
    {
        Console.WriteLine("Kükreme!");
    }
}

public class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age, "Elephant") { }

    public override void MakeSound()
    {
        Console.WriteLine("Boru!");
    }
}

public class Giraffe : Animal
{
    public Giraffe(string name, int age) : base(name, age, "Giraffe") { }

    public override void MakeSound()
    {
        Console.WriteLine("Zürafanın kendine özgü bir sesi yok.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new("Simba", 5);
        Elephant elephant = new("Dumbo", 10);
        Giraffe giraffe = new("Melman", 7);

        System.Console.WriteLine($"{lion.Name} bir {lion.Species} ve yaşı {lion.Age}, Sesi:");
        lion.MakeSound();
        System.Console.WriteLine($"{elephant.Name} bir {elephant.Species} ve yaşı {elephant.Age}, Sesi:");
        elephant.MakeSound();
        System.Console.WriteLine($"{giraffe.Name} bir {giraffe.Species} ve yaşı {giraffe.Age}, Sesi:");
        giraffe.MakeSound();
    }
}

