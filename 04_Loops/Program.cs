using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //for(int i = 1; i<5; i++ )
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}                                                      

            //for(int i = 1;i<= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i < 50;  i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen Adedi Giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i  = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Döngüsü İle Karar Yapıları 

            //for (int i = 1; i<= 100; i++) 
            //{ 
            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for(int i = 1; i <= 10; i++)
            //{
            //    totalValue += i; 

            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for(int i = 1; i <= 20; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine(" ------------------");
            //Console.WriteLine("Çift Sayılar Toplamı = " + totalValue);  

            //int count = 0;

            //for(int i = 1; i < 60; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("1-50 Arasında " + count + " Sayı 7'ye tam bölünür ");

            //int bacterium = 1;

            //for(int i = 1; i <= 24; i++)
            //{
            //    bacterium  *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda Ortamdaki Bakteri Sayısı = " + bacterium);
            //}



            #endregion

            #region While Döngüsü

            //Şart sağlandığı sürece döngü çalışır.

            //int i = 1;

            //while(i <= 10)
            //{
            //    Console.WriteLine(" Hello Loops ");
            //    i++;

            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;

            //    i++;
            //}
            //Console.WriteLine(sum);




            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden Girilen 3 Basamaklı Sayının Basamakları Toplamını bulan program

            //int ones, tens, hundreds;
            //int sum = 0;

            //do
            //{

            //    Console.Write("Lütfen 3 Basamaklı Sayı Giriniz : ");
            //    int number = int.Parse(Console.ReadLine());

            //    if(number > 1000 || number < 100)
            //    {
            //        Console.WriteLine("Girdiğiniz Sayı 3 Basamaklı Değil. Tekrar Deneyin");
            //        continue;
            //    }
            //    else
            //    {
            //        ones = number % 10;
            //        tens = (number % 100) / 10;
            //        hundreds = number / 100;

            //        sum = ones + tens + hundreds;

            //        Console.WriteLine("Sayını = " + number);
            //        Console.WriteLine("-----------");
            //        Console.WriteLine("Yüzler Basamağı = " + hundreds + "\nOnlar Basamağı = " + tens + "\nBirler Basamağı = " + ones);
            //        Console.WriteLine("-----------");
            //        Console.WriteLine("Basamaklar Toplamı = " + sum);
            //        break;
            //    }



            //} while (true);


            #endregion


            Console.Read();
        }
    }
}
