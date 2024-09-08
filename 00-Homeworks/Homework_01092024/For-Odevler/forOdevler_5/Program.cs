namespace forOdevler_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1'den 100'e kadar olan asal sayilar: ");

        for (int sayi = 2; sayi <= 100; sayi++)
        {
            bool asalMi = true;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    break;
                }
                if (asalMi)
                {
                    System.Console.Write(sayi + " ");
                    break;
                }
            }
        }

    }
}
