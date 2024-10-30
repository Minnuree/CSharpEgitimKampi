using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud --> Create-Read-Update-Delete 

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QC4C51K;initial Catalog=EgitimKampiDb;integrated security = true"); // bağlantımı oluşturdum
            //connection.Open(); // bağlantımı açtım
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi.");

            #endregion

            #region Ürün ekleme İşlemi

            //  string productName;
            //  decimal productPrice;
            ////  bool productSatus;

            //  Console.Write("Ürün Adı: ");
            //  productName = Console.ReadLine();

            //  Console.Write("Ürün Fiyatı: ");
            //  productPrice = decimal.Parse(Console.ReadLine());


            //  SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QC4C51K;initial Catalog=EgitimKampiDb; integrated security= true ");
            //  connection.Open();
            //  SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1, @p2, @p3)", connection);
            //  //(@productName, @productPrice, @productStatus) şeklinde yazılır
            //  command.Parameters.AddWithValue("@p1", productName);
            //  command.Parameters.AddWithValue("@p2", productPrice);
            //  command.Parameters.AddWithValue("@p3", true);
            //  command.ExecuteNonQuery(); // değişiklikleri kaydet ve veritabanına yansıt
            //  connection.Close();

            //  Console.Write("Ürün eklemesi başarılı.");



            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QC4C51K;initial Catalog=EgitimKampiDb; integrated security= true ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); //Veritabanından verileri çekerken veri listelemesi sırasında bir köprü gören komut
            //DataTable dataTable = new DataTable(); //Verileri geçici belleğe alabilmek için DataTable sınıfından bir nesne oluşturuyoruz
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-QC4C51K;initial Catalog=EgitimKampiDb;integrated security= true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı!");

            #endregion

            #region Ürün Güncelleme İşlemi


            Console.Write("Güncellenecek Ürün Id : ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı : ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-QC4C51K; initial Catalog= EgitimKampiDb; integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName= @productName,ProductPrice=@productPrice where ProductId = @productId", connection); //1. sqlden
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId",productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Güncelleme başarılı!");

            #endregion

            Console.Read();
        }
    }
}
