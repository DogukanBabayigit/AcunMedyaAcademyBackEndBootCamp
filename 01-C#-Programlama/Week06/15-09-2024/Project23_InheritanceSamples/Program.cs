using Project23_InheritanceSamples.CarManagmentSystem;
using Project23_InheritanceSamples.SchoolSystem;

namespace Project23_InheritanceSamples;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new("Seat", "Cupra", 2013, 4);
        car1.CarManagmentSystem();
        car1.OpenTrunk();
        System.Console.WriteLine("Çalıştırmak için Start");
        string command = Console.ReadLine();
        switch (command.ToLower())
        {
            case "start":
                car1.Start();
                break;

            case "stop":
                car1.Stop();
                break;

        }

        System.Console.WriteLine("************");

        MotorCycle motorCycle1 = new("Honda", "CBR", 2015, "Var");
        motorCycle1.CarManagmentSystem();
        motorCycle1.Start();
        System.Console.WriteLine("************");

    }
}
