namespace whileOdevler3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pozitif sayi giriniz: ");
        int sayi = default;

        while (true)
        {
            sayi = Convert.ToInt32(Console.ReadLine);
            if (sayi < 0)
            {
                break;
            }

            System.Console.WriteLine(sayi + "sayinin karesi: " + (sayi * sayi));


        }

    }
}
