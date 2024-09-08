using System.Runtime.Serialization;

namespace forOdevler_3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen pozitif tam sayi giriniz: ");
        string girdi = Console.ReadLine();

        if (int.TryParse(girdi, out int sayi) && sayi > 0)
        {
            System.Console.WriteLine($"{sayi} sayisinin tam bölenleri: ");

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    System.Console.Write(i + " ");
                }
            }
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine("Pozitif bir tam sayi giriniz.");
        }
    }
}