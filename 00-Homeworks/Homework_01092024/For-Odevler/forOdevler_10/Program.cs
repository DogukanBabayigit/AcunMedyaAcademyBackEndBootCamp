namespace forOdevler_10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("İlk pozitif tam sayiyi giriniz: ");
        int baslangic = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İkinci pozitif tam sayiyi giriniz: ");
        int bitis = Convert.ToInt32(Console.ReadLine());

        if (baslangic > 0 && bitis > 0)
        {
            long carpim = 1;

            for (int i = baslangic; i <= bitis; i++)
            {
                carpim *= i;
            }
            System.Console.WriteLine($"{baslangic}'den {bitis}'e kadar olan sayilarin carpimi: {carpim}");
        }
        else
            System.Console.WriteLine("Lütfen pozitif bir tam sayi giriniz: ");
    }
}
