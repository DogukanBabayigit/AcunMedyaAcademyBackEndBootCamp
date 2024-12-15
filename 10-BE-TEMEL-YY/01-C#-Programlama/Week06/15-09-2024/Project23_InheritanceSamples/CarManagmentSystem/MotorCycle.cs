using System;

namespace Project23_InheritanceSamples.CarManagmentSystem;

public class MotorCycle : Vehicle
{
    public MotorCycle(string brand, string model, int year, string coolingSystem = null) : base(brand, model, year)
    {
        CoolingSystem = coolingSystem;
    }

    public string CoolingSystem { get; set; }
    public override void CarManagmentSystem()
    {
        base.CarManagmentSystem();
        System.Console.WriteLine($"Soğutma Sistemi: {CoolingSystem}");
    }
}
