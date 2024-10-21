namespace whileOdevler7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üst sinir değerini giriniz: ");
        int ustSinir = Convert.ToInt32(Console.ReadLine());

        while (sayi <= ustSinir)
        {
            System.Console.WriteLine(sayi);
            sayi = sayi * 2;
        }
    }
}
