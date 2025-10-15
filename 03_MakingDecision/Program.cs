using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region İf Else

            //string password;
            //Console.Write("Lütfen Şifreyi Giriniz : ");
            //password = Console.ReadLine();

            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Şifre Doğru !");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış !");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz : ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz : ");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı!!");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler Yanlış ");
            //}

            //int number;
            //Console.Write("Sayı : ");
            //number = int.Parse(Console.ReadLine());

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}


            //int exam1, exam2 , exam3 , average = 0;
            //Console.Write("Sınav  1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalama = " + average);

            //if(average < 50)
            //{
            //    Console.WriteLine("Sınıfta Kaldınız!!");
            //}
            //else if(average >= 50 & average < 70)
            //{
            //    Console.WriteLine("Sınıfı Geçtiniz.Belge Yok");
            //}
            //else if(average >= 70 & average < 85)
            //{
            //    Console.WriteLine("Teşekkür Belgersi Almaya Hak Kazandınız!");
            //}
            //else if(average >= 85 & average <= 100)
            //{
            //    Console.WriteLine("Taktir Belgesi Almaya Hak Kazandınız!");
            //}

            //string city;
            //Console.Write("Lütfen Şehir Giriniz : ");
            //city = Console.ReadLine();

            //if(city == "adana" || city == "ankara" || city == "erzurum" || city =="bursa")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Bulunamadı");
            //}

            //string userName;
            //Console.Write("Kullanıcı Adı : ");
            //userName = Console.ReadLine();

            //if(userName  != "admin")
            //{
            //    Console.WriteLine("Kullanıcı Adı Hatalı!");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome!");
            //}
            #endregion

            #region Mod İşlemleri

            //int number = 26, result;
            //result = number % 5;
            //Console.WriteLine(result);

            //int number1, number2 , result;
            //Console.Write("Lütfen 1. Sayıyı Giriniz : ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sayıyı Giriniz : ");
            //number2 = int.Parse(Console.ReadLine());

            //result = number1 % number2;
            //Console.WriteLine("1.Sayının 2. Sayıyas bölümünden kalan = " + result);

            //Console.Write("Lütfen Bir Sayı Giriniz : ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine(number + " Sayısı Çift Bir Sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine(number + " Sayısı Tek Sayıdır!");
            //}







            #endregion

            #region Char Değişkenler

            //char letter;
            //Console.Write("Bir Harf Giriniz : ");
            //letter = char.Parse(Console.ReadLine());

            //if(letter == 'g' || letter == 'G')
            //{
            //    Console.WriteLine("Galatasaray!");
            //}
            //else if(letter == 'f' || letter == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe!");
            //}

            #endregion

            #region Switch Case 

            //Console.Write("Ay Numarasını Giriniz : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;

            //},




            #endregion

            #region Switch Case Hesap Makinesi

            //Console.Write("1.Sayı : ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("2.Sayı : ");
            //int number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçin : ");
            //Console.WriteLine("\t1-Toplama(+)");
            //Console.WriteLine("\t2-Çıkarma(-)");
            //Console.WriteLine("\t3-Çarpma(*)");
            //Console.WriteLine("\t4-Bölme(/)");
            //Console.Write("Seçim : ");
            //int choose = int.Parse(Console.ReadLine());

            //switch (choose)
            //{
            //    case 1: Console.WriteLine("Toplam = " + (number1 + number2)); break;
            //    case 2:Console.WriteLine("Çıkarma Sonucu = " + (number1 - number2)); break;
            //    case 3:Console.WriteLine("Çarpma Sonucu = " + (number1 * number2)); break;
            //    case 4:Console.WriteLine("Çıkarma Sonucu = " + (number1 / number2)); break;

            //    default: Console.WriteLine("Geçersiz Seçim!!");  break;
            //}
            #endregion
            Console.Read(); 
        }
    }
}
