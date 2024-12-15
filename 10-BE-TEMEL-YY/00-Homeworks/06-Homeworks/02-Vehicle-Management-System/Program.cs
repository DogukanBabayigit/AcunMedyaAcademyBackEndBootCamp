namespace _02_Vehicle_Management_System;

public class Vehicle
{
    public string Brand;
    public string Model;
    public int Year;

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        System.Console.WriteLine($"Marka: {Brand}, Model: {Model}, Yıl: {Year}");
    }

}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string brand, string model, int year, int numberOfDoors) : base(brand, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Kapı Sayısı: {NumberOfDoors}");
    }
}

public class Bicycle : Vehicle
{
    public bool HasBasket { get; set; }

    public Bicycle(string brand, string model, int year, bool hasbasket) : base(brand, model, year)
    {
        HasBasket = hasbasket;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Sepet Var mı: {(HasBasket ? "Evet" : "Hayır")}");
    }
}

public class Motorcycle : Vehicle
{
    public bool HasSideCar { get; set; }

    public Motorcycle(string brand, string model, int year, bool hasSideCar) : base(brand, model, year)
    {
        HasSideCar = hasSideCar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Yan Sepet Var mı: {(HasSideCar ? "Evet" : "Hayır")}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Corolla", 2020, 4);
        Bicycle bicycle = new Bicycle("Giant", "Escape 3", 2022, true);
        Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2018, false);

        
        car.DisplayInfo();
        Console.WriteLine();
        bicycle.DisplayInfo();
        Console.WriteLine();
        motorcycle.DisplayInfo();
    }
}
