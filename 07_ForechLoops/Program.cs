using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForechLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Frorech Döngüsü

            //string[] cities = { "Erzurum", "İstanbul", "Bursa ", "Ankara" };

            //foreach(string x in cities) //string olan x'e sırasıyla cities içindeki değerşleri boca et.x'i cities dizisi üzerinde dolaştır.
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 13, 45, 66, 889, 00, 877, 4232, 3653, 23245 };

            //foreach(int sayi in numbers){
            //    Console.WriteLine(sayi);

            //}

            //int[] numbers = { 13, 45, 66, 889, 00, 877, 4232, 3653, 23245 };

            //foreach(int i in numbers) //Bu işlemi diziye toplu işlem , koşul yapmak istediğimizde verimli bir yöntemdir
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

            //int result = 0;
            //Console.Write("Dizi Boyutunu Giriniz : ");
            //int size = int.Parse(Console.ReadLine());

            //int[] numbers = new int[size];

            //Console.WriteLine($"{size}  Adet Dizi Elemanı Giriniz : ");
            //for(int i = 0;i < size; i++)
            //{
            //    Console.Write($"{i + 1}. Elemanı Giriniz : ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //foreach(int sum in numbers)
            //{
            //    result += sum;
            //}

            //Console.WriteLine("Dizi Elemanları Toplamı = " + result);

            //List<int> numbers = new List<int>() //Listeler koleksiyonel yapılardır.
            //{
            //    2,3,4,5,67,7 
            //};

            ////Console.WriteLine(numbers); //Listelerr Bu şekilde yazılamazlar.

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Hello";

            //foreach(char letter in word) //Burda aslında string olan dizi içerisinde char olarak dolaşır her harfi letter'a atar.
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion
            #region Örnek sınav Sistemi Uygulaması

            

            //Console.WriteLine("***** Sınav Başarı Hesaplama Sistemi *****");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıf Mevcudu Giriniz : ");
            //int studentCount = int.Parse(Console.ReadLine());


            //int taktirCount = 0, tesekkurCount = 0, emptyCount = 0 , kalanCount = 0;

            //string[] studentNames = new string[studentCount];
            //double[] notesAverage = new double[studentCount];
            //int[] exam1  = new int[studentCount];
            //int[] exam2  = new int[studentCount];
            //int[] exam3  = new int[studentCount];



            //for (int i = 0; i < studentCount; i++) 
            //{
            //    Console.WriteLine($"{i + 1}. Öğrenci Bilgileri");
            //    Console.Write("Öğrenci İsmi = ");
            //    studentNames[i] = Console.ReadLine();
            //    Console.Write("Not Girişleri İçin Enter Tuşuna Basınız.");
            //    Console.ReadLine();
            //    Console.Write("\t1.Sınav Notu = ");
            //    exam1[i] = int.Parse(Console.ReadLine()) ;
            //    Console.Write("\t2.Sınav Notu = ");
            //    exam2[i] = int.Parse(Console.ReadLine());
            //    Console.Write("\t3.Sınav Notu = ");
            //    exam3[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("------------------------------");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Öğrenci Bilgileri Güzenleniyor...");

            //for(int i = 0;i<studentCount;i++)
            //{
            //    notesAverage[i] = (exam1[i] +  exam2[i] + exam3[i]) / 3;
            //}

            //Console.Write("Not Sisteminmi Görüntülemek İçin Ente Tuşuna Basınız.");
            //Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("**** Not Sistemine Hoşgeldiniz ****");

            //for(int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine($"Öğrenci İsmi = {studentNames[i]}");
            //    Console.WriteLine($"Ortalama = {notesAverage[i]}");
            //    Console.Write("Durum : ");
            //    if (notesAverage[i] < 50)
            //    {
            //        Console.WriteLine("Sınıfta Kaldı");
            //        kalanCount++;
            //    }

            //    else if (notesAverage[i] >= 50 & notesAverage[i] < 70) 
            //    {
            //        Console.WriteLine("Geçti.Belge Yok.");
            //        emptyCount++;
            //    }
            //    else if (notesAverage[i] >= 70 & notesAverage[i] < 85)
            //    {
            //        Console.WriteLine("Geçti.Teşekkür Belgesi.");
            //        tesekkurCount++;
            //    }
            //    else if (notesAverage[i] >= 85 & notesAverage[i] < 100)
            //    {
            //        Console.WriteLine("Geçti.Taktir Belgesi.");
            //         taktirCount++;
            //    }
            //}

            //Console.Write("Sınıf İstatistiğini Görmek İçin Enter Tuşuna Basınız : ");
            //Console.ReadLine();

            //for (int i = 0; i < studentCount; i++)
            //{ 
            //    if(notesAverage[i] < 50)
            //    {
            //        Console.WriteLine($"Sınıfta Kalan Sayısı = " + kalanCount);
            //        Console.WriteLine("Öğrenciler:");
                   
            //    }

            //    if (notesAverage[i] >= 50 || notesAverage[i] < 70 )
            //    {
            //        Console.WriteLine($"Sınıfı Geçen Fakat Belge Almayan Sayısı = " + emptyCount);
            //        Console.WriteLine("Öğrenciler:");
                    
            //    }
            //    if (notesAverage[i] >=70 || notesAverage[i] < 85)
            //    {
            //        Console.WriteLine($"Sınıfta Teşekkür Belgesi Alan Sayısı = " + tesekkurCount);
                    
            //    }
            //    if (notesAverage[i] >= 70 || notesAverage[i] < 85)
            //    {
            //        Console.WriteLine($"Sınıfta Taktir Belgesi Alan Sayısı = " + taktirCount);
            //        Console.WriteLine("Öğrenciler:");
                    
            //    }

            //}

            #endregion
            Console.Read();
        }
    }
}
