namespace minMax_Odev2;

class Program
{
    static void Main(string[] args)
    {
        int sayi, enBuyuk = int.MinValue, enKucuk = int.MaxValue;
        int sayac = 0;

        while (sayac < 5)
        {
            Console.Write($"{sayac + 1}. sayiyi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());


            if (sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }

            if (sayi < enKucuk)
            {
                enKucuk = sayi;
            }

            sayac++;
        }

        Console.WriteLine($"Girilen sayilardan en büyüğü: {enBuyuk}");
        Console.WriteLine($"Girilen sayilardan en küçüğü: {enKucuk}");
    }
}

