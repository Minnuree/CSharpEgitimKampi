using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.Write("**** C# Veritabanlı Ürün-Kategori Bilgi Sistemi ****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;


            Console.WriteLine("---------------------------");

            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");

            Console.Write("Lütfen Getirmek İstediğiniz Tablon Numarasını Giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------");

            //Sql bağlantısı için

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QC4C51K;initial Catalog=EgitimKampiDb;integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable(); // verileri ram belleğe almamı sağlar
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach ( var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
