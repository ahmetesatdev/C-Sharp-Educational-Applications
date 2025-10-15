using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //Geriye Değer Döndürmeyen Fonksiyonlardır.

            //void akkusFamily()
            //{
            //    Console.WriteLine("Ahmet Esat Akkuş");
            //    Console.WriteLine("Şener Akkuş");
            //    Console.WriteLine("Ülkü Akkuş");
            //    Console.WriteLine("Berce Akkuş");
            //    Console.WriteLine("Caner Akkuş");
            //}//Ben burda fonksiyopnu tanımladım fakat fonksiyonun çalışması için onu çağırmam gereklidir.

            //akkusFamily();

            //void sum()
            //{
            //    int x = 33;
            //    int y = 31;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}//Void fonksiyonu ile sayısal işlemler de yapılabilir.

            //sum();


            #endregion

            #region Void Metotlara parametre Gönmderme


            //void write(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //Console.Write("Müsteri İsmi giriniz : ");
            //string name = Console.ReadLine();
            //write(name);//Kullanıcıdan parametreyi aldık.


            //void customerrCard(string name , string surname)
            //{
            //    Console.WriteLine("İsim : " + name);
            //    Console.WriteLine("Soy İsim : " + surname);
            //}
            //customerrCard("Ahmet Esat", "Akkuş");//Burada fonksiyonuma ben program içerisinde parametre gönderiyorum

            //void sum(int number1 , int number2 , int number3)
            //{
            //    int result = 0;
            //    result =  number1 + number2 + number3;
            //    Console.WriteLine($"Toplam = {result}");
            //}

            //Console.Write("3 Sayı Giriniz :");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());
            //sum(x, y, z);   

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerName(string name)
            //{
            //    return name;//Direkt Ekrana bir şey yazmaz 
            //}
            //string myName = "Ahmet Esat";
            //Console.WriteLine("İsim = " + customerName(myName));

            //string studyCard(string name , string surname)
            //{
            //    return name + " " + surname;
            //}
            //Console.Write("İsim = ");
            //string myName = Console.ReadLine();
            //Console.Write("Soy İsim = ");
            //string mySurname = Console.ReadLine();

            //Console.WriteLine("AD - SOYAD : " + studyCard(myName , mySurname));

            #endregion
            Console.Read();
        }

    }


}

