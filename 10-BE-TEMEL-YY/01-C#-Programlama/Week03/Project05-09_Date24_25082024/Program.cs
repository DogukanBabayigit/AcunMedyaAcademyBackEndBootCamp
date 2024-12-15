namespace Homework_25082024;

class Program
{
    static void Main(string[] args)
    {
        #region Kullniciden alinan yildan yas hesaplama

        // Console.WriteLine("Dogum Yilinizi Giriniz:");
        // string input = Console.ReadLine();

        // int birthYear = int.Parse(input);
        // int calculatedAge = DateTime.Now.Year - birthYear;
        // string message = "Yasiniz : " + calculatedAge;
        // System.Console.WriteLine(message);

        #endregion

        #region Ürün Fiyat
        //Bir ürünün fiyatı girildiğinde, onun KDV dahil fiyatını hesaplayıp hem ham hem de KDV dahil fiyatını ekrana yazdıracağız.

        // System.Console.WriteLine("Urun fiyatini giriniz:");
        // decimal productPrice = decimal.Parse(Console.ReadLine());

        // double vatRate = 0.18;
        // double vat = (double)productPrice * vatRate;
        // decimal totalProductPrice = productPrice + (decimal)vat;

        // string resultMessage = $@"Urun Fiyati    : {productPrice} KDV:{vat} KDV Dahil Fiyat : {totalProductPrice}";

        // string resultMessage = $"Urun fiyati     :   {productPrice}\nKDV             :   {vat}\nKDV Dahil Fiyat :   {totalProductPrice}";

        // System.Console.WriteLine(resultMessage);


        #endregion

        #region Sicaklik Donusturme
        //Kullanıcıdan Celsius cinsinden alınan sıcaklık değerini, Fahrenheit cinsine çevirip ekrana her ikisini de alt alta yazdıran kodu hazırlıyoruz.

        // System.Console.WriteLine("Celcius Sicalik Degerini Giriniz: ");
        // double celcius = double.Parse(Console.ReadLine());
        // double Fahrenheit = (celcius * 1.8) + 32;

        // string resultMessage = $@"Celcius : {Convert.ToInt32(celcius)} fahrenheit: {Convert.ToInt32(Fahrenheit)}";
        // Console.Clear();
        // System.Console.WriteLine("Sonuc: ");
        // System.Console.WriteLine("-----");
        // System.Console.WriteLine(resultMessage);


        #endregion

        #region Agirlik Donusturme
        //Kullanıcının girdiği kg cinsinden ağırlığı gram'a çevirip sonucu ekrana yazdıran kodu hazırlayınız. 
        //Not: Küsüratlı değerler girilebilir.
        //Not: Sonuç ekranında hem kg hem gr değerlerini düzgünce göstermemiz gerekiyor.

        // System.Console.WriteLine("KG Cinsinden Agirlik Giriniz: ");
        // double kg = double.Parse(Console.ReadLine());
        // double gr = kg * 1000;

        // string resultMessage = $@"Kg: {kg} gr: {(int)gr}";

        // System.Console.WriteLine("Sonuc: ");
        // System.Console.WriteLine("-----");
        // System.Console.WriteLine(resultMessage);

        #endregion

        #region If Conditions

        // if (5>4)
        // {
        //     System.Console.WriteLine("İşlem Tamamlandi");
        // }
        // else
        // {
        //     System.Console.WriteLine("Hata!");
        // }

        // System.Console.WriteLine("Uygulama Sona Erdi..");

        #endregion

        #region If Condition Exp.
        //Kullanıcının klavyeden gireceği yaş bilgisini alıp eğer reşit değilse "Reşit değilsiniz, X sene sonra reşit olacaksınız" eğer reşit ise "Giriş yapabilirsiniz" yazdıran kodu hazırlayınız.

        #endregion

    }
}
