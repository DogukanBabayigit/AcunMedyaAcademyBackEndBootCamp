namespace dateTime_6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir yil giriniz: ");
        int yil = int.Parse(Console.ReadLine());

        if (yil % 4 == 0 && yil % 100 != 0 || yil % 400 == 0)
        {
            System.Console.WriteLine($"{yil} yili artik yildir.");
        }
        else
            System.Console.WriteLine($"{yil} yil artik yil değildir.");
    }
}
