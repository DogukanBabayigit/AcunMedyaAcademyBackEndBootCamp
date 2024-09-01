namespace question05;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Aranacak Metni Girin: ");
        string text1 = Console.ReadLine();

        System.Console.WriteLine("içinde Aranacak metni Girin: ");
        string text2 = Console.ReadLine();

        int index = text1.IndexOf(text2);

        if (index != -1)
        {
            System.Console.WriteLine("İlk Index: "+ index);
        }
        else
        {
            System.Console.WriteLine("Aranan Metin Bulunamadi.");
        }
    }
}
