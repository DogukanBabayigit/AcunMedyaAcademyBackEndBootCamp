namespace forOdevler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen pozitif bir tam sayi giriniz: ");
        string girdi = Console.ReadLine();

        if (int.TryParse(girdi, out int sayi) && sayi > 0)
        {
            int toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i; //toplam = toplam+i
            }
            System.Console.WriteLine($"1'den {sayi}'ya olan sayilarin toplami:  {toplam}");
        }
        else
            System.Console.WriteLine("Lütfen pozitif bir sayi giriniz!!");



    }
}
