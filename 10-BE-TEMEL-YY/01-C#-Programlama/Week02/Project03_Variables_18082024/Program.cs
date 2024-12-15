// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         /* int degiskenAdi=56;
//         int degiskenAdi2=2;
//         Console.WriteLine(degiskenAdi); */

//         // VS Code : Line Comment (ctrl+ö uncomment ctrl+k u)
//         // Universal Way: line Comment (ctrl+k C / uncomment yapmak içinse ctrl+ k u)

//         // Tam Sayılar ;

//         sbyte studentPoints=78; // between -128 / 127 (1 Byte = 8 Bit)
//         System.Console.WriteLine(studentPoints); 
//     }
// }


internal class Program
{
    private static void Main(string[] args)
    {
        #region Değişken İsimlendirme Kural Ve Teknikleri
        /* 
        1) C# BÜYÜK/küçük harf duyarlı bir dildir.
            Ör: adSoyad ile AdSoyad aynı değildir!
        2)  Özel karakterler değişken adı içerisinde yer alamaz.
            ör: istisna (_) /Ad Soyad, Ogrenci-Numarasi bunlar geçersiz isimlerdir.
                _AdSoyad, Ad_Soyad / Sayi1 , Sayi_2 , Sayi3Var
                1Sayi , 4Not bunlar yine geçersiz isimlerdir. Çünkü değişken isimleri harf veya _ ile başlamak zorundadır.  
        3)KeyWords;
        Değişken isimleri olarak kullanılamaz.
        ör: int "static" olamaz.
            string "void" olamaz
        4) Değişkenler anlamlı olmalıdır.
        5) camelCase tekniği kullanımladır.
            ör: string anneAdi;
            ör: anneadi; anne_adi; bunlar camelCase'e uygun değildir.
        6) Türkçe karakter yasak değildir. Tercih etmemek şiddetle önerilir. (ö,ğ,İ,ş,ç,ı)
        7) Sabit(Const) tanımlarken genellikle tamamen BÜYÜK HARF kullanılır.
            ör: const int MAX_AGE = 43;
                farklı bir satırda MAX_AGE = 40 ; yazarsak değer değişmez! Atanan değer sabittir.
        
         */
        #endregion

        #region Tam_Sayilar

        /*         byte studentPoints2=255; //Between 0 - 255 1 Byte (8 Bit)
                System.Console.WriteLine(studentPoints2); 

                sbyte studentPoints=78; // between -128 / 127 (1 Byte = 8 Bit)
                 System.Console.WriteLine(studentPoints);

                 //C#'ta ayrıca belirtilmedikçe tüm sayısal değerler int tipinde varsayılır.

                 short price = 500; // Between -32768 / 32768 (16 Bit)
                 ushort price2 = 600; // (unassigned short) no minus number (65535) (16 Bit = 2 Byte)
                 int number = -589; // 32 Bit (4 Byte) 
                 uint  number2 = 97; // 32 Bit (4 Byte) no minus number
                 long   longNumber = 98897987; // 64 Bit (8 Byte)
                 ulong  longNumber2 = 545; // 64 Bit no minus number (8 Byte) */

        #endregion

        #region Ondalik_Sayilar
        /* float oran = 0.5f; // 32 Bit sens. = 7 Steps // "f" koymadığmız sürece double convert yapmaya çalışıyor. 
        double oran2 = 0.5; // 64 Bit //"d" if need // sens : 15-16 steps
        decimal maas = 0.5m; // 128 Bit Sens : 28-29 Steps // "m" koymadığmız sürece double convert yapmaya çalışıyor. */
        #endregion

        #region Diger Tipler

        /*         bool varMi= true;  // 1 Byte (8 Bit)       
                bool gecerliMi= false; // 1 Byte (8 Bit) 

                char cevap = 'E'; // Can inclued one character
                char symbol = '&'; // UTF-16 - 16 Bit Character */

        #endregion

        #region Value Types
        /*             
            Yukaridaki tüm tipler C# Value Types'dır.
            Bellekte direk olarak değer saklayan yapılardır.
            Ayrıca bunlara Primitive Types de denir.
         */

        #endregion

        #region Reference Types

        /*  
        Ram'in stack kısnıbda verinin yerine , verinin bulunduğu
        yerin adresini tutn veri tipleridir.
        Yani reference type,bir nesneyi ya da edğeri işaret eder.
         */

        #endregion

        #region Temel Referans Tipler
        /* string adSoyad = "Doğukan Babayiğit";
        object nesne = 15;
        object nesne2 = true;
        object nesne3 = "Merhaba"; // Veri ayırtmez. Her türlü veriyi tutabilir.

        //String ve object tiplerinin bellekte ne kadar yer kapladığını araştır. */

        #endregion

        #region Consts(Sabitler)

            /* const int MAX_AGE=43;
            System.Console.WriteLine(MAX_AGE); */

        #endregion
    }
}