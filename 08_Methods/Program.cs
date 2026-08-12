using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metot

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ahmet Bozkurt");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 3;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion
            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Mehmet Yıldız");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri:" + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşe", "Yıldırım");
            //CustomerCard("Begüm", "Kaya");

            #endregion
            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int num1,int num2,int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 8, 7);

            #endregion
            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion
            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke:" + countryName + "- Başkent:" + capital + "- Bayrak Rengi:" + flagColor;
            //    return cardInfo;
            //}

            //string x,y,z;
            //Console.Write("Ülke adı giriniz:");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz:");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengi giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine(CountryCard("İtalya","Roma","Kırmızı-Beyaz-Yeşil"));

            #endregion
            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int num1,int num2,int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    return result;
            //}

            //Console.WriteLine(Sum(8,7,9));
            //Console.WriteLine(Sum(48,71,26));
            //Console.WriteLine(Sum(78,47,54));

            #endregion
            #region Örnek Uygulama

            //string ExamResult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result>=50)
            //    {
            //        return student + " isimli öğrenci dersten geçti.Ortalaması:" + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğenci dersten kaldı.Ortalaması:" + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali",48,75,98));
            //Console.WriteLine(ExamResult("Ayşe",45,20,34));

            #endregion
        }
    }
}
