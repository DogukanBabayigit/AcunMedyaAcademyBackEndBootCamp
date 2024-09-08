namespace forOdevler_9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("P.Tam sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        bool asalMi = true;

        if (sayi == 1)
        {
            asalMi = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    break;
                }
            }
        }

        if (asalMi)
        {
            System.Console.WriteLine("Asal Sayidir!");
        }
        else
            System.Console.WriteLine("Asal Sayi Değildir!");
    }
}
