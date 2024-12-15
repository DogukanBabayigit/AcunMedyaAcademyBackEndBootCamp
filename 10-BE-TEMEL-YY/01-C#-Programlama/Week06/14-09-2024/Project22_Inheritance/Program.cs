using System.Reflection.PortableExecutable;

namespace Project22_Inheritance;

class Program
{
    //Sınıfın sahip olduğunu herşeyi başka bir Sınıfa devredilebilmesine Inheritance(Miras bırakmak.)
    //Bir Class birden çok Class'a Inhertance verebilir. Sadece tek Class'dan Inheritance alabilir. Bir Class 2 Adet Inheritance alamaz.

    class Bird
    {
        public void Fly()
        {
            System.Console.WriteLine("Kuş Uçuyor.");
        }
    }

    class Penguen : Bird //Bu Sınıfın artık her iki özelliğide var.(Inheritance sayesinde)
    {
        public void Swim()
        {
            System.Console.WriteLine("Penguen Yüzüyor.");

        }
    }

    class Auto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int ModelYear { get; set; }
    }

    class InnerBurnAuto : Auto
    {
        public string FuelType { get; set; }
        public string HorsePower { get; set; }

    }

    class Evehicle : Auto
    {
        public string Mile { get; set; }
        public bool SelfCharge { get; set; }

    }



    static void Main(string[] args)
    {
        Evehicle eVehicle1 = new Evehicle();
        eVehicle1.Brand = "Tesla";






        /* Penguen penguen1 = new();
        penguen1.Swim();
        penguen1.Fly(); */
    }
}
