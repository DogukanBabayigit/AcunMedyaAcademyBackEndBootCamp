namespace forOdevler_6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("10'dan büyük bir sayi giriniz: ");
        string girdi = Console.ReadLine();

        if (int.TryParse(girdi, out int sayi) && sayi > 10)
        {
            System.Console.WriteLine("Sayilarin kareleri: ");

            for (int i = 1; i <= sayi; i++)
            {
                int kare = i * i;
                System.Console.WriteLine($"{i}^2= {kare}");
            }
        }
        else
            System.Console.WriteLine("10'dan küçük sayi girdiniz. Tekrar deneyiniz.");
    }
}
