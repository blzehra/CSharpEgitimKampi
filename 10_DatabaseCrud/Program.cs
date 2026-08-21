using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek  istediğiniz kategori adı:");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=EğitimKampıDB;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi.");

            #endregion
            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı:");
            //productName=Console.ReadLine();

            //Console.Write("Ürün Fiyatı:");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=.\\SQLEXPRESS;initial catalog=EğitimKampıDB;integrated security=true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (productName,productPrice,productStatus)values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı.");

            #endregion
            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=EğitimKampıDB;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion
            #region Ürün Silme İşlemi

            //Console.Write("Silinecek ürün Id:");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=EğitimKampıDB;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme işlemi tamamlandı.");

            #endregion
            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id:");
            //int productId=int.Parse(Console.ReadLine());

            //Console.Write("Ürün Adı:");
            //string productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı:");
            //decimal productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;initial catalog=EğitimKampıDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı.");

            #endregion
        }
    }
}
