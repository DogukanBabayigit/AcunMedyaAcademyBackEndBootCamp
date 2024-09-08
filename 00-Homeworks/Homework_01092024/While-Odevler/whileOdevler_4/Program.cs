namespace whileOdevler_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int toplam = 0;
        while (sayi > 0)
        {
            int rakam = sayi % 10;
            toplam = toplam + rakam;
            sayi /= 10;

        }
        System.Console.WriteLine("Rakamlarin toplami: " + toplam);
    }
}
