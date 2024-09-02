namespace Project13_GuessNumberGame;

/* Sayı tahmin oyunu = uygulamanın rastgele üreteceği 1-100 arasındaki bir sayıyı kullanıcın tahmin ederek
bulmasını sağlayan bir kod yazınız. 
*Kullanın tahmini üretilen sayıdan küçükse ya da byükse buna göre yönlendirme yapılsın
*Kullanıcın 5 Ttahmin hakkı olsun.
*Kullanıcı doğru tahmin yaptıysa ya da tahmin hakkı dolduysa uygun mesajı vererek oyun sona ersin.
*/

class Program
{
    static void Main(string[] args)
    {
        string answer;
        Random rnd = new Random();
        int generatedNumber = rnd.Next(1, 101);
        System.Console.WriteLine($"HİLE=> {generatedNumber}");
        System.Console.WriteLine("*****************");
        System.Console.WriteLine();

        int guessNo;
        int live = 1;
        int liveLimit = 5;
        string resultMessage = "";

        do
        {

            Console.Write($"{live}.Hak(1-100): ");
            guessNo = int.Parse(Console.ReadLine());

            if (guessNo < generatedNumber)
            {
                resultMessage = "Daha büyük bir sayı dene.";
            }

            else if (guessNo > generatedNumber)
            {
                resultMessage = "Daha küçük bir sayı dene.";
            }

            if (guessNo != generatedNumber)
            {
                live++;
            }

            if (live <= liveLimit && guessNo != generatedNumber)
            {
                System.Console.WriteLine(resultMessage);
            }

            System.Console.WriteLine("Tekrar oynamak ister misin ? (E/H)");
            System.Console.WriteLine("-----------------------------------");
            answer = Console.ReadLine();
            if (answer != "E")
            {
                Console.WriteLine("\nSayı Tahmin Oyununu oynadığınız için teşekkürler!");
            }

        } while (guessNo != generatedNumber && live <= liveLimit && answer != "H");
        resultMessage = guessNo == generatedNumber ? "Kazandın" : "Kaybettin";
        System.Console.WriteLine(resultMessage);
    }
}
