namespace minMax_Odev;

class Program
{
    static void Main(string[] args)
    {
        int sayi;
        int enBuyuk = int.MinValue;
        int enKucuk = int.MaxValue;

        for (int i = 0; i < 5; i++)
        {
            System.Console.Write($"{i + 1}. sayiyi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > enBuyuk)
            {
                enBuyuk = sayi;

            }
            if (sayi < enKucuk)
            {
                enKucuk = sayi;

            }
            System.Console.WriteLine($"Girilen sayilardan en büyüğü: {enBuyuk}");
            System.Console.WriteLine($"Girilen sayilardan en küçüğü: {enKucuk}");
        }

    }
}
