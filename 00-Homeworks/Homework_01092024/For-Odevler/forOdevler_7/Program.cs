namespace forOdevler_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen tam sayi giriniz: ");
        string girdi = Console.ReadLine();

        if (int.TryParse(girdi, out int sayi) && sayi > 0)
        {
            int toplam = 0;
            for (int i = 2; i <= sayi; i += 2)
            {
                toplam += i;
            }
            System.Console.WriteLine($"1'den {sayi}'ya kadar olan çift sayilarin toplami: {toplam}");
        }
        else
            System.Console.WriteLine("Geçerli bir pozitif tam sayi giriniz: ");
    }
}
