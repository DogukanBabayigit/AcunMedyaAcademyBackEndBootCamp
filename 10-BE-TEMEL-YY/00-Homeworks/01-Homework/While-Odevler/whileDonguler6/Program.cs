namespace whileDonguler6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir Metin Giriniz: ");
        string Metin = Console.ReadLine();
        int index = Metin.Length - 1;
        string tersMetin = " ";

        while (index >= 0)
        {
            tersMetin += Metin[index];
            index--;
        }
        System.Console.WriteLine("Ters Metin: " + tersMetin);
    }
}
