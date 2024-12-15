using System.ComponentModel;

namespace question02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci sayiyi giriniz: ");
        double no1 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("İkinci sayiyi giriniz: ");
        double no2 = Convert.ToDouble(Console.ReadLine());

        if (no1 > no2)
        {
            System.Console.WriteLine($"Birinci Sayi {no1} Büyüktür {no2}");
        }
        else if (no2 > no1)
        {
            System.Console.WriteLine($"İkinci Sayi {no2} Büyüktür {no1}");
        }

        else
        {
            System.Console.WriteLine("İki Sayi Eşittir.");
        }
    }
}
