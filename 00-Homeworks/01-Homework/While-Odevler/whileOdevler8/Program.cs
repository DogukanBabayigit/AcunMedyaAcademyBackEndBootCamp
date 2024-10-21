namespace whileOdevler8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("100'e kadar tam sayi giriniz (yüz girilmesi program sonlanmasi):");
        int sayi = 0;
        int sayac = 0;
        int toplam = 0;

        while (true)
        {
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi <= 100 && sayi > 0)
            {
                toplam = toplam + sayi;
                sayac++;
            }
            else if (sayi > 100)
            {
                System.Console.WriteLine("100'den büyük sayi girdiniz!");
                break;
            }
            else
            {
                Console.WriteLine("Lütfen pozitif bir tam sayi giriniz.");
            }

        }
        if (sayac > 0)
        {
            double ortalama = (double)toplam / sayac;
            System.Console.WriteLine($"Girilen sayilarin toplami: {toplam}");
            System.Console.WriteLine($"Girilen sayilarin ortalamasi: {ortalama}");
        }
    }
}
