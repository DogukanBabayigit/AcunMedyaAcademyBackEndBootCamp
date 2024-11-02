namespace _05_Hw_Answers;

class Program
{
    private static int i;

    static void Main(string[] args)
    {
        #region Que1

        // int[] numbers = new int[10]; //iceriye 10 atadik
        // Random random = new Random(); 
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = random.Next(1, 101);
        // }


        // Console.WriteLine("Oluşturulan dizi:");
        // foreach (int number in numbers)
        // {
        //     Console.Write(number + " ");
        // }
        // Console.WriteLine();


        // Console.WriteLine("Kendinden önceki ve sonraki sayıdan büyük olan elemanlar:");
        // for (int i = 1; i < numbers.Length - 1; i++)
        // {
        //     if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
        //     {
        //         Console.WriteLine(numbers[i]);
        //     }
        // }

        #endregion

        #region Que2

        // int[] sayilar = new int[10]; // 10 elamanli dizi oluşturduk.
        // int[] ciftSayilar = new int[10];// Max. 10 çift sayi olacağından 10 elemanli dizi oluşturduk.
        // int ciftSayiSayaci = 0;//Çift sayiların kaç tane olduğunu takip edecek.

        // System.Console.WriteLine("Lütfeb 10 Adet Sayi Giriniz: ");

        // //Sayilari diziye atama:

        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //     System.Console.WriteLine("{0}.Sayi= ", i + 1);
        //     sayilar[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // //Çift sayi bulma:

        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //     if (sayilar[i] % 2 == 0)
        //     {
        //         ciftSayilar[ciftSayiSayaci] = sayilar[i];
        //         ciftSayiSayaci++;
        //     }
        // }

        // //Çift sayilari siralama

        // for (int i = 0; i < ciftSayiSayaci; i++)
        // {
        //     for (int j = 0; j < ciftSayiSayaci; j++)
        //     {
        //         if (ciftSayilar[j] > ciftSayilar[j + 1])
        //         {
        //             int temp = ciftSayilar[j];
        //             ciftSayilar[j] = ciftSayilar[j + 1];
        //             ciftSayilar[j + 1] = temp;
        //         }
        //     }
        // }

        // //ekrana yazdirma

        // System.Console.WriteLine("Siralanmis Cift Sayilar");

        // for (int i = 0; i < ciftSayiSayaci; i++)
        // {
        //     System.Console.WriteLine(ciftSayilar[i]);
        // }

        #endregion

        #region Que3

        /* int i;
        int[] dizi = new int[10];
        Random rnd = new Random();
        for (i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rnd.Next(-100, 100);
        }

        // Pozitif ve negatif sayılar için yeni diziler oluşturma
        List<int> pozitifSayilar = new List<int>();
        List<int> negatifSayilar = new List<int>();


        i = 0;
        while (i < dizi.Length)
        {
            if (dizi[i] > 0)
            {
                pozitifSayilar.Add(dizi[i]);
            }
            else if (dizi[i] < 0)
            {
                negatifSayilar.Add(dizi[i]);
            }
            i++;
        }


        Console.WriteLine("Orijinal Dizi:");
        foreach (int sayi in dizi)
        {
            Console.Write(sayi + " ");
        }

        Console.WriteLine("\nPozitif Sayılar:");
        foreach (int sayi in pozitifSayilar)
        {
            Console.Write(sayi + " ");
        }

        Console.WriteLine("\nNegatif Sayılar:");
        foreach (int sayi in negatifSayilar)
        {
            Console.Write(sayi + " ");
        }

        Console.ReadLine(); */

        #endregion

        #region Que5
        /*         Random rnd = new Random();
                int[] numbers = new int[100];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(1, 50);
                }

                Console.WriteLine("Dizi: " + string.Join(", ", numbers));

                System.Console.WriteLine("Kontrol edilecek sayiyi giriniz: ");
                int inputNumber = int.Parse(Console.ReadLine());

                List<int> indices = new();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == inputNumber)
                    {
                        indices.Add(i);// Sayının bulunduğu indeksleri listeye ekliyoruz
                    }
                }

                if (indices.Count > 0)
                {
                    Console.WriteLine($"Sayi {inputNumber} dizide bulundu.");
                    Console.WriteLine($"Bulunduğu indeksler: {string.Join(", ", indices)}");
                    Console.WriteLine($"Tekrar sayisi: {indices.Count}");
                }
                else
                {
                    Console.WriteLine($"Sayi {inputNumber} dizide bulunamadi.");
                }
         */
        #endregion

        #region Que6
        /*         Random rnd = new();
                int[] numbers = new int[100];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(1, 100);
                }
                Console.WriteLine("Dizi: " + string.Join(", ", numbers));

                int max = numbers[0];
                int min = numbers[0];

                foreach (int number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                    if (number < min)
                    {
                        min = number;
                    }
                }
                Console.WriteLine($"\nDizideki en büyük sayi: {max}");
                Console.WriteLine($"Dizideki en küçük sayi: {min}"); */
        #endregion

        #region Que7
        /*         Random rnd = new Random();
                int[] numbers = new int[50];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(1, 50);
                }

                Console.WriteLine("Dizi: " + string.Join(", ", numbers));

                int sumOfEvens = 0;

                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        sumOfEvens += number;
                    }
                }

                Console.WriteLine($"\nDizideki tüm çift sayıların toplamı: {sumOfEvens}"); */
        #endregion

        #region Que8
        /*         Random rnd = new Random();
                int[] numbers = new int[10];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] =rnd.Next(1,100);

                }

                Console.WriteLine("Başlangıç Dizisi: " + string.Join(", ", numbers));

                System.Console.Write("Aranacak sayiyi girin: ");
                int inputNumber = int.Parse(Console.ReadLine());

                bool isFound =Array.Exists(numbers,element =>element==inputNumber);

                if (isFound)
                {
                    System.Console.WriteLine($"Sayi {inputNumber} dizide zaten mevcut.");
                }
                else
                {
                    System.Console.WriteLine($"Sayı {inputNumber} dizide bulunamadı. Sayı eklenecek.");
                    List<int> numberList = new List<int>(numbers);

                    numberList.Add(inputNumber);
                    numberList.Sort();

                    System.Console.WriteLine("Güncellenmiş Dizi: " + string.Join(", ", numberList));
                } */
        #endregion

        #region Que9
        /*         int[] numbers = { 3, -1, 5, 7, -2, 0, 8, -4, 2, -3 };

                System.Console.WriteLine("Orijinal Dizi: " + string.Join(", ", numbers));

                List<int> positiveNumbers = new List<int>();
                foreach (var number in numbers)
                {
                    if (number > 0)
                    {
                        positiveNumbers.Add(number);
                    }
                }

                positiveNumbers.Reverse();

                int index = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0)
                    {
                        numbers[i] = positiveNumbers[index];
                        index++;
                    }
                }

                Console.WriteLine("Pozitif Sayılar Ters Çevrildikten Sonra Dizi: " + string.Join(", ", numbers)); */
        #endregion

        #region Que10
        /*         int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                System.Console.WriteLine("Orijinal Dizi: " + string.Join(", ", originalArray));

                int[] reversedArray = new int[originalArray.Length];

                for (int i = 0; i < originalArray.Length; i++)
                {
                    reversedArray[i] = originalArray[originalArray.Length - 1 - i];
                }

                Console.WriteLine("Ters Dizi: " + string.Join(", ", reversedArray));
         */
        #endregion

        #region Que11

        /*         Console.Write("Bir cümle girin: ");
                string inputSentence = Console.ReadLine();

                string[] words = inputSentence.Split(' ');

                int index = words.Length - 1;

                System.Console.WriteLine("Kelime Dizisi Tersten:");

                while (index >= 0)
                {
                    Console.Write(words[index] + " ");
                    index--;
                }

                System.Console.WriteLine();
         */
        #endregion

        #region Que12
        /* Random rnd = new Random();
        int[] numbers = new int[100];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 20);
        }

        System.Console.WriteLine("Dizi: " + string.Join(", ", numbers));

        Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

        foreach (var number in numbers)
        {
            if (frequencyDict.ContainsKey(number))
            {
                frequencyDict[number]++;
            }
            else
            {
                frequencyDict[number] = 1;
            }
        }
        int mostFrequentElement = frequencyDict.First().Key; //Ilk elemani getirir en sik tekrar eden elemani Başlangıç degeri olarak atar.
        int highestFrequency = frequencyDict.First().Value;

        foreach (var pair in frequencyDict)
        {
            if (pair.Value > highestFrequency)
            {
                mostFrequentElement = pair.Key;
                highestFrequency = pair.Value;
            }
        }

        Console.WriteLine($"\nEn sık tekrar eden eleman: {mostFrequentElement}");
        Console.WriteLine($"Tekrar sayısı: {highestFrequency}"); */
        #endregion

        #region Que14

        /*         int[] numbers = new int[20];
                Random rnd = new Random();

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(1, 101);
                }
                System.Console.WriteLine("Dizi: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                    if ((i + 1) % 5 == 0)
                    {
                        System.Console.WriteLine();
                    }
                }
                int sumDivThree = 0;

                foreach (int number in numbers)
                {
                    if (number % 3 == 0)
                    {
                        sumDivThree += number;
                    }
                }

                System.Console.WriteLine("\n3'e bölünebilen elemanların toplamı: " + sumDivThree); */
        #endregion

        #region Que15


        /*         int[] numbers = { 7, 2, 5, 8, 3, 4, 1, 6, 9, 10 };


                Console.WriteLine("Orijinal Dizi: " + string.Join(", ", numbers));


                List<int> oddNumbers = new List<int>();


                foreach (int number in numbers)
                {
                    if (number % 2 != 0) // Eğer sayı tek ise
                    {
                        oddNumbers.Add(number);
                    }
                }

                // Tek sayıları küçükten büyüğe sıralıyoruz
                oddNumbers.Sort();

                // Sıralanmış tek sayıları orijinal diziye yerleştirmek için bir indeks tutuyoruz
                int oddIndex = 0;


                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0) // Sadece tek sayılar için yer değiştirme yapıyoruz
                    {
                        numbers[i] = oddNumbers[oddIndex]; // Sıralı tek sayıyı diziye yerleştir
                        oddIndex++;
                    }
                }


                Console.WriteLine("Tek Sayılar Sıralanmış Dizi: " + string.Join(", ", numbers)); */
        #endregion

        #region Que16

        // Girilen sayıları saklamak için bir liste tanımlıyoruz.

        /* List<int> numbers = new List<int>();
        int input;
        int sum = 0;

        do
        {
            System.Console.WriteLine("Bir sayı girin (çıkmak için 0): ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
                sum = sum + input;
            }
        } while (input != 0);

        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;

        Console.WriteLine("\nGirilen Sayılar: " + string.Join(", ", numbers));
        Console.WriteLine("Ortalama: " + average); */

        #endregion

        #region Que17

        int[] numbers = { 5, 3, 9, 12, 7, 12, 6, 4, 8 };

        int largest = int.MinValue;

        int secondLargest = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                // `largest` yeni en büyük değer olduğu için `secondLargest` eski `largest` değeri olur
                secondLargest = largest;
                largest = numbers[i];
            }
            else if (numbers[i] > secondLargest && numbers[i] != largest)
            {
                // Eğer sayı `secondLargest`'ten büyük ve `largest`'a eşit değilse `secondLargest` olur
                secondLargest = numbers[i];
            }
        }

        Console.WriteLine("En büyük sayı: " + largest);
        Console.WriteLine("İkinci en büyük sayı: " + secondLargest);


        #endregion










    }
}

