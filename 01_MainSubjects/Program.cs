using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //C#'ta Console.Write("İfade"); komutu ile yazdırabiliriz fakat bu komut imleci bir alt satıra almaz.
            //C#'ta Console.WrtiteLine("İfade"); komutu ile ekrana hem bastırma işlemi yaparız hemde imlec bir alt satıra geçer (Line = satır)

            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hi!");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar ");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            //Değişken_Türü Değişken_İsmi = Değer;

            //string name = "Ahmet Esat";
            //Console.Write(name);

            //string customerName;//Değişken isimlendirirken "Camel Case" Yöntemi kullanılır yani ilk harf küçük ikinci kelime büyük başlar
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ahmet Esat";
            //customerSurname = "Akkuş";
            //customerPhone = " +90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Yakutiye";
            //city = "Erzurum";

            //Console.WriteLine("***** Rezervasyon Bilgileri ***** ");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------");

            //Console.WriteLine();

            //customerName = "Şener";
            //customerSurname = "Akkuş";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------");

            #endregion

            #region Int Değişkenler

            ////int number = 24;
            ////Console.WriteLine(number);
            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("***** Restoran Menüsü *****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger Fiyatı : " + hamburgerPrice + " TL ");
            //Console.WriteLine("-----Kola Fiyatı : " + cokePrice + " TL ");
            //Console.WriteLine("-----Su Fiyatı : " + waterPrice + " TL ");
            //Console.WriteLine("-----Kızartmalar Fiyatı : " + friesPrice + " TL ");
            //Console.WriteLine("-----Pizza Fiyatı : " + pizzaPrice + " TL ");
            //Console.WriteLine("-----Limonata Fiyatı : " + lemonadePrice + " TL ");
            //Console.WriteLine("*****  HESAP *****");
            //Console.WriteLine();

            //int hamburgerCount = 3;
            //int cokeCount = 3;
            //int waterCount = 3;
            //int friesCount = 1;
            //int pizzaCount = 0;
            //int lemonadeCount = 0;

            //int totalHamburgerPrice = 0;
            //int totalCokePrice = 0;
            //int totalWaterPrice = 0;
            //int totalFriesPrice = 0;
            //int totalPizzaPrice = 0;
            //int totalPrice = 0;


            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokePrice * cokeCount;
            //totalWaterPrice = waterPrice * waterCount;
            //totalFriesPrice = friesPrice * friesCount;
            //totalPizzaPrice = pizzaPrice * pizzaCount;

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Hamburger Tutarı = " + totalHamburgerPrice + " TL");
            //Console.WriteLine("Kola Tutarı = " + totalCokePrice + " TL");
            //Console.WriteLine("Su Tutarı = " + totalWaterPrice + " TL");
            //Console.WriteLine("Kızartma Tutarı = " + totalFriesPrice + " TL");
            //Console.WriteLine("Pizza Tutarı = " + totalPizzaPrice + " TL");

            //totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice ;

            //Console.WriteLine("Toplam = " + totalPrice + " TL ");
            #endregion

            Console.Read();
        }
    }
}
