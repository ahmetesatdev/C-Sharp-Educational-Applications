using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _09_DatebasePrroject
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string tableNumber;
            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış");
            Console.Write("Lütfen Getirmek İstediğiniz Tabloyu Seçiniz : ");
            tableNumber = Console.ReadLine();

            Console.WriteLine("----------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-Q0V4B0D\\SQLEXPRESS; initial Catalog = EgitimkampiDb;integrated security = true;");
            //Burda SqlConnection adında sınıf ve ona ait nesne oluşturduk.Daha sonrasında sunucu adını , veritabanı adını ve veri tabanının güvenilir olduğunu belirten ifadeyi yazdık
            connection.Open();//

            SqlCommand command = new SqlCommand("Select * From TblCategory" , connection);//Sorgu yapmamızı sağlıyor en son hangi bağlantıda sorgu yapacağımızı söylüyoruz
            SqlDataAdapter adapter = new SqlDataAdapter(command);//C# ile SQL arasında köprü oluşturuyoruz.
            DataTable dataTable = new DataTable(); //Sql üzerinden yazdığım verileri belleğe almamı sağlarr
            adapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow row in dataTable.Rows)                                  
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
    
}
