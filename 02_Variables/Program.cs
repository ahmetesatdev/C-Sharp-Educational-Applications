using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            #region Double Değişkenler 
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, tomatoPrice, patatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //tomatoPrice = 9.74;
            //patatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı = " + applePrice + " ₺ ");
            //Console.WriteLine("---- Portakal Birim Fiyatı = " + orangePrice + " ₺ ");
            //Console.WriteLine("---- ÇilerkBirim Fiyatı = " + strawberryPrice + " ₺ ");
            //Console.WriteLine("---- Patates Birim Fiyatı = " + patatoPrice + " ₺ ");
            //Console.WriteLine("---- Domates Birim Fiyatı = " + tomatoPrice + "  ₺  ");

            //double appleGram , orangeGram , strawberryGram , tomatoGram , patatoGram ;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //tomatoGram = 3.745;
            //patatoGram = 4.859;

            //double appleTotalPrice , orangeTotalPrice , strawberryTotalPrice , tomatoTotalPrice , patatoTotalPrice , total = 0 ;


            //appleTotalPrice = applePrice * appleGram;
            //orangeTotalPrice = orangePrice * orangeGram;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //tomatoTotalPrice = tomatoPrice * tomatoGram;
            //patatoTotalPrice = patatoPrice * patatoGram;

            //total = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + patatoTotalPrice;

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("***** BİLL *****");
            //Console.WriteLine();
            //Console.WriteLine("Elma Fiyatı = " + appleTotalPrice + " ₺ ");
            //Console.WriteLine("Portakal Fiyatı = " + orangeTotalPrice + " ₺ ");
            //Console.WriteLine("Çilek Fiyatı = " + strawberryTotalPrice + " ₺ ");
            //Console.WriteLine("Patates Fiyatı = " + patatoTotalPrice + " ₺ ");
            //Console.WriteLine("Domates Fiyatı = " + tomatoTotalPrice + " ₺ ");
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Toplam = " + total + " ₺ ");


            #endregion

            #region Char Değişkenler 

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistricts, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adını Giriniz: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı Giriniz: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi : ");
            //passengerDistricts = Console.ReadLine();

            //Console.Write("Şehir Bilhgisi : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("**** Yolcu Bilgileri ****");
            //Console.WriteLine("Yolcu Tc Kimlik : " + passengerIdentityNumber);
            //Console.WriteLine("Yolcu Ad - Soyad : " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Şehir : " + passengerCity);
            //Console.WriteLine("İlçe : " + passengerDistricts);
            //Console.WriteLine("Yaş : " + passengerAge);



            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler


            //C# girilen her karakteri bnaşlangıçta string olarak kabul eder biz int veya double veya float gireceksek bunu 'Parse' metoduyla dönüşüm yaparak gerçekleştiririz.


            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz : ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoePrice * shoeCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Toplam Fiyat : " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri 

            //double exam1 , exam2 , exam3 , result ;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("\nOrtalama : " + result);
            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);

            #endregion

            Console.Read();
        }
    }
}
