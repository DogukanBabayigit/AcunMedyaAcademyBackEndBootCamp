namespace whileOdevler2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir metin giriniz: ");
        string metin = Console.ReadLine();

        string buyukHarf = " ";
        int i = 0;
        while (i < metin.Length)
        {
            char harf = metin[i];
            if (char.IsLetter(harf))
            {
                buyukHarf += char.ToUpper(harf);
            }
            else
            {
                buyukHarf += harf;
            }
            i++;

            System.Console.WriteLine("Büyük harf ile yazilmis metin: " + buyukHarf);
        }
    }
}
