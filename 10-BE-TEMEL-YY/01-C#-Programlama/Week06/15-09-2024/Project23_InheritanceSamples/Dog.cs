using System;

namespace Project23_InheritanceSamples;

public class Dog : Animal
{
    public Dog(string name, int age, int olfactionLevel, string breed) : base(name, age)
    {
        OlfactionLevel = olfactionLevel;
        Breed = breed;
    }
    public int OlfactionLevel { get; set; }
    public string Breed { get; set; }
    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name} havladi!");
    }

    public void Swim()
    {
        System.Console.WriteLine($"");
    }
}
