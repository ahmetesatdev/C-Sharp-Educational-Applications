using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // Değişken Türü [] Dizi Adı = new DeğişkenTürü[Eleman Sayısı]
            //Dizi elemanları 0 index'ten itibaren tutulmaya başlarlar.bu neden son elemanın index'i eleman sayısının bir eksiğidir.

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Erzurum" }; 

            //Console.WriteLine(cities[4]);





            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for(int i = 0; i<colors.Length; i++ ) //DiziAdı.Length metotu bize dizi boyutunu verir burada boyut = 7 yani son elemanın indisi 6
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 2365, 1120 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 3 == 0){
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] numbers = { 47, 85, 95, 41, 25, 635, 50, 789, 86, 100 };

            //int max = numbers[0];
            //int min = numbers[0];

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if(max < numbers[i])
            //    {
            //        max = numbers[i];
            //    }
            //    else if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }
            //}
            //Console.WriteLine("En Büyük Eleman = " + max);
            //Console.WriteLine("En Küçük Sayı = " + min);


            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
            //Console.WriteLine(persons.Length);//Dizinin Boyutunu DiziAdı.Length metoduyla buluruz .

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);//Bu metot Diziyi bellekte küçükten büyüğe doğru sıralar.
            //for(int i = 0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers); //Bu metot Dizi terstenm sıralar.
            //for(int i = 0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotları

            //string[] customes = { "Ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customes, "merve");//Bu metot dizi içerisindeki aranan elemanın index numarasını döndürür.
            //Console.WriteLine(index);

            //int[] numbers = { 45, 56, 43, 78, 65, 34, 90, 87 };
            //Console.WriteLine("Dizinin en Büyük Elemanı : " + numbers.Max());//Bu Metot Dizinin en büyük elemanını döndürür
            //Console.WriteLine("Dizinin en Küçük Elemanı : " + numbers.Min());//Bu Metot Dizinin en küçük elemanını döndürür




            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i = 0; i<cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz : "); //$ İşareti Çift Tırnak bütünlüğünü bozmadan Metin dışındaki ifadeleri eklememizi sağlar
            //    cities[i] = Console.ReadLine();
            //}

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.Şehir = {cities[i] }  ");
            //}

            //Console.Write("Lütfen Dizi Boyutunu Giriniz : ");
            //int size = int.Parse(Console.ReadLine());

            //int toplam = 0;
            //int[] numbers = new int[size];

            //for(int i = 0; i < size; i++)
            //{
            //    Console.Write($"{i + 1}. Elemanı Giriniz : ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("Dizi = ");
            //for(int i = 0; i < size; i++)
            //{
            //    Console.Write(numbers[i] + " , ");
            //    toplam += numbers[i];
                
            //}
            //Console.WriteLine($"Dizinizin En Küçük Elemanı = {numbers.Min()}");
            //Console.WriteLine($"Dizinizin En Büyük Elemanı = {numbers.Max()}");
            //Console.WriteLine($"Dizi Elemanları Toplamı  = {toplam}");
            #endregion

            Console.Read();
        }
    }
}
