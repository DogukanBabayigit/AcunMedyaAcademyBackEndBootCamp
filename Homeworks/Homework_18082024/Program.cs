namespace Homework_18082024;

class Program
{
    static void Main(string[] args)
    {
        #region odevSoru1

        /* int number1 = 20;
        int number2 = 30;
        
        int toplam = number1 + number2;
        System.Console.WriteLine("Toplam: " + toplam); */

        #endregion

        #region odevSoru2

        /*  double number = 3.14;
         double karesi = number*number;
         System.Console.WriteLine("Sayinin Karesi: " + karesi); */

        #endregion

        #region odevSoru3

        /* string ad = "Dogukan";
        int yas = 24;
        System.Console.WriteLine("Benim adim " + ad + " ve ben " + yas + " yasindayim."); */

        #endregion

        #region odevSoru4

        /*  char harf = 'd'; //charlar 'd' isareti ile belirtilir.
         int asciiDegeri = (int)harf;
         System.Console.WriteLine("ASCII Değeri: " + asciiDegeri ); */

        #endregion

        #region odevSoru5

        /* bool dogru = true;
        bool yanlis = false;

        System.Console.WriteLine(dogru);
        Console.Write(yanlis); */

        #endregion

        #region odevSoru6

        /*   byte deger1 = 255;
          int Intdeger = deger1;
          System.Console.WriteLine("Int Değeri: " + Intdeger); */

        #endregion

        #region odevSoru7

        /* int Intdeger = 987654;
        byte myByte = Convert.ToByte(Intdeger);
        System.Console.WriteLine(myByte);

        //Sonucun Byte değerine göre çok büyük veya çok küçük olmasından kaynaklı hata verdi(Byte 0-255). Aynı zamanda Byte (8 Bit) iken Int (32 Bit) */

        #endregion

        #region odevSoru8

        /* double myDouble = 3.14d;
        int myInt = (int)myDouble;
        System.Console.WriteLine("Pi sayısının int karşılığı: " + myInt);

        //Ekrana 3 sayısını yazması gerekir genelde.
        //double'dan int'e dönüşüm yaparken, ondalıklı kısım atılır.Yani 3.14 değeri, en yakın tam sayı olan 3'e yuvarlanır. */

        #endregion

        #region odevSoru9

        /* string myString = "42";
        int degerInt = int.Parse(myString);
        System.Console.WriteLine("Sayının int karşılığı: " + degerInt); */

        #endregion

        #region odevSoru10

        /* int deger1 = 5;
        int deger2 = 10;
        int deger3 = 15;

        double ortalama =(deger1+deger2+deger3)/3;
        System.Console.WriteLine("Int 3 Sayinin Ortalamasi: " + ortalama); */


        #endregion

        #region odevSoru11

        /* decimal price1 = 10.25m;
        decimal price2 = 5.75m;
        decimal toplam = price1+price2;

        System.Console.WriteLine("Toplam Fiyat: " + toplam); */

        #endregion

        #region odevSoru12

        /* float fdegisken = 1.23f;
        double ddeger = fdegisken;

        System.Console.WriteLine("Float Deger: " + fdegisken);
        Console.Write("Double Deger: " + ddeger); */

        #endregion,

        #region odevSoru13
        /* 
                long ldeger = 500000000000;
                int Ideger = (int)ldeger;

                System.Console.WriteLine(Ideger); //int tipine sığmayan bir değerdir. () */

        #endregion

        #region odevSoru14

        /* string ad = "Dogukan";
        string soyad = "Babayigit";

        System.Console.WriteLine("Ad Soyad: " + ad + " " + soyad);
 */

        #endregion

        #region odevSoru15

        /* string sdegisken = "true";
        bool bdeger = bool.TryParse(sdegisken, out bdeger);
        System.Console.WriteLine(bdeger); */

        #endregion

        #region odevSoru16

        /* double pi = 3.14159d;
        float fpi = (float)pi;
        System.Console.WriteLine("Pi Double Değeri: " + pi);
        Console.Write("Pi Float  Değeri: " + fpi); */

        #endregion

        #region odevSoru17

        /* byte byteValue = 42;
        short shortValue = 42;
        int IntValue = 42;
        long longValue = 42;

        Console.WriteLine("byte tipinde 42 sayısı " + sizeof(byte) + " byte yer kaplar.");
        Console.WriteLine("short tipinde 42 sayısı " + sizeof(short) + " byte yer kaplar.");
        Console.WriteLine("int tipinde 42 sayısı " + sizeof(int) + " byte yer kaplar.");
        Console.WriteLine("long tipinde 42 sayısı " + sizeof(long) + " byte yer kaplar."); */

        #endregion

        #region odevSoru18

        string text = "Merhaba Ben Doğukan Babayiğit.";
        int chrcount = text.Length;

        System.Console.WriteLine("Cümledeki karakter sayisi: " + chrcount);


        #endregion
    }
}
