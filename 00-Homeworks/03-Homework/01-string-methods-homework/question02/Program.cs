namespace question02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir metin giriniz: ");
        string metin = Console.ReadLine();

        string text1 = metin.ToUpper();
        string text2 = metin.ToLower();

        System.Console.Write(text1 + "\n" + text2);
    }
}
