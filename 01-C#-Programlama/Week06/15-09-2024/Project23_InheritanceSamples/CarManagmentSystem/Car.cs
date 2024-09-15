using System;

namespace Project23_InheritanceSamples.CarManagmentSystem;

public class Car : Vehicle
{

    public Car(string brand, string model, int year, int countOfDoors) : base(brand, model, year)
    {
        CountOfDoors = countOfDoors;
    }
    public int CountOfDoors { get; set; }

    public void OpenTrunk()
    {
        Console.WriteLine($"{Brand} {Model} ({Year}) aracının bagajı açıldı.");
    }

    public override void CarManagmentSystem()
    {
        base.CarManagmentSystem();
        System.Console.WriteLine($"Kapı Sayısı: {CountOfDoors}");
    }
}
