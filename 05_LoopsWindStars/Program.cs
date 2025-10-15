using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWindStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma

            //for(int i = 1;i<=10;i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 Tane Yıldız Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}


            #endregion

            #region Alt Alta 10 Tane Yıldız Oluşturma Her Satırda 10 Tane Yıldız Olsun

            //for(int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Dik Üçgen

            //for (int i = 0; i < 5; i++)
            //{
            //    for(int J = 0; J<= i; J++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters Dik Üçgen

            //for(int i = 0; i < 5; i++)
            //{
            //    for(int j  = 5; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik Üçgen Ve ters Dik Üçgen Beraber

            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 0; j<i; j++)
            //    {
            //        Console.Write("*");
            //        if (j == 4)
            //        {
            //            Console.WriteLine();
            //            for (int k = 0; k < 5; k++)
            //            {
            //                for (int n = 5; n > k; n--)
            //                {
            //                    Console.Write("*");
            //                }
            //                Console.WriteLine();
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi 

            //for(int i = 1; i<=5; i++)
            //{
            //    for(int j = 4; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 1; k<=2*i-1 ; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////Alt Kısım
            //for(int i = 1; i <= 5; i++)
            //{

            //    for (int j = 4; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 5; j >= 2*i-1; j--) //  2n-1(Tek Sayı Formatı 1,3 ,5, 7 ...)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit 

            //int n = 8;

            //for(int i = 1; i<=n; i++)
            //{
            //    //Boşluklar
            //    for(int j = n-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //Yıldızlar
            //    for(int k = 1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit 

            //int n = 5;

            //for(int i = n; i>=1; i--)
            //{
            //    //Boşluklar
            //    for(int j=n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //Yıldızlar

            //    for(int k =1; k<= 2*i-1;k++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion


            Console.Read();
        }
    }
}

