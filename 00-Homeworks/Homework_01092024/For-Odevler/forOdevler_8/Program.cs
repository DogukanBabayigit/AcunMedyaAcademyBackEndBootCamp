using System.Runtime.Serialization;

namespace forOdevler_8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pozitif tam sayi giriniz: ");
        string girdi = Console.ReadLine();

        if (int.TryParse(girdi, out int sayi) && sayi > 0)
        {
            System.Console.WriteLine("Sayilarin kareleri (Geriye Doğru)");

            for (int i = sayi; i >= sayi; i--)
            {
                int kare = i * i;
                System.Console.WriteLine($"{i}^2={kare}");
            }
        }
        else
            System.Console.WriteLine("Geçerli bir pozitif tam sayi giriniz.");
    }
}
