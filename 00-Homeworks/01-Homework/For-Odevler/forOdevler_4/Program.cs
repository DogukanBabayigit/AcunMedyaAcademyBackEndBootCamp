namespace forOdevler_4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Pozitif tam sayi giriniz: ");
        string girdi = Console.ReadLine();

        if (int.TryParse(girdi, out int satirSayisi) && satirSayisi > 0)
        {
            for (int i = 1; i <= satirSayisi; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        else
            System.Console.WriteLine("Geçerli bir tam sayi giriniz: ");
    }
}
