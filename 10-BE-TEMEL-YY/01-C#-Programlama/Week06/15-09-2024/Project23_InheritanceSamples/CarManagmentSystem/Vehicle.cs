using System;

namespace Project23_InheritanceSamples.CarManagmentSystem;

public abstract class Vehicle
{
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public Vehicle(string brand, string model, int year, bool v)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void Start() //Method
    {
        Console.WriteLine($"{Brand} {Model} ({Year}) çalıştırıldı.");
    }

    public void Stop() //Method
    {
        Console.WriteLine($"{Brand} {Model} ({Year}) durduruldu.");
    }


    public virtual void CarManagmentSystem()
    {
        System.Console.WriteLine($"Marka: {Brand}\nModel: {Model}\nYıl: {Year}");
    }

    public void GetSignal()
    {
        
    }



}
