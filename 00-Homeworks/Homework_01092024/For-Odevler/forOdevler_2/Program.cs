namespace forOdevler_2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen pozitif bir tam sayi giriniz: ");
        string girdi = Console.ReadLine();

        if (int.TryParse(girdi, out int sayi) && sayi > 0)
        {
            for (int i = 1; i <= sayi; i++)
            {
                int kup = i * i * i;
                System.Console.WriteLine($"{i}^3={kup}");
            }
        }
        else
            System.Console.WriteLine("Lütfen geçerli bir tam sayi giriniz!!");
    }
}
