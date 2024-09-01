namespace question03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir Sayi Girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        double mutlakDeger = Math.Abs(sayi1);

        System.Console.WriteLine("Sayinin Mutlak Degeri: " + mutlakDeger);
    }
}
