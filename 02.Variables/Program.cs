using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DoubleDegiskenler
            //double number;
            //number=4.65;
            //Console.WriteLine(number);

            //Console.WriteLine("*****Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, tomatoPrice, orangePrice, potatoPrice, strawberryPrice;
            //applePrice = 14.68;
            //tomatoPrice= 10.87;
            //orangePrice= 20.34;
            //potatoPrice= 8.43;
            //strawberryPrice = 45;

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Elma Birim Fiyati:" + applePrice+"₺");
            //Console.WriteLine("Portakal Birim Fiyati:" + orangePrice+"₺");
            //Console.WriteLine("Domates Birim Fiyati:" + tomatoPrice+"₺");
            //Console.WriteLine("Patates Birim Fiyati:" + potatoPrice+"₺");
            //Console.WriteLine("Çilek Birim Fiyati:" + strawberryPrice+"₺");
            //Console.WriteLine("----------------------------------");

            //Double appleGram, orangeGram, tomatoGram, strawberryGram, potatoGram;
            //appleGram=1.265;
            //orangeGram=3.45;
            //tomatoGram = 4.87;
            //strawberryGram = 0.967;
            //potatoGram = 6.45;

            //double appleTotalPrice = applePrice * appleGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;

            //Console.WriteLine("Alinan urun:Elma-Birim fiyat:"+applePrice+"-Gramaj:"+appleGram+"-Toplam tutar:"+appleTotalPrice);
            //Console.WriteLine("Alinan urun:Domates-Birim fiyat:" + tomatoPrice + "-Gramaj:" + appleGram + "-Toplam tutar:" + appleTotalPrice);
            //Console.WriteLine("Alinan urun:Patates-Birim fiyat:" + potatoPrice + "-Gramaj:" + potatoGram + "-Toplam tutar:" + potatoTotalPrice);
            //Console.WriteLine("Alinan urun:Portakal-Birim fiyat:" + orangePrice + "-Gramaj:" + orangeGram + "-Toplam tutar:" + orangeTotalPrice);
            //Console.WriteLine("Alinan urun:Cilek-Birim fiyat:" + strawberryPrice + "-Gramaj:" + strawberryGram + "-Toplam tutar:" + strawberryTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + potatoTotalPrice + tomatoTotalPrice + orangeTotalPrice + strawberryTotalPrice;
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Alisveris Toplam Tutar:"+shoppingTotalPrice+"₺");

            #endregion
            #region CharDegisken
            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);
            #endregion
            #region KlavyedenStringVeriGirişi
            //Console.WriteLine("****CSharp Havayolları Yolcu Bilgisi****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu adi:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadi:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi:");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu yaş:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No:"+passengerIdentityNumber+"-Yolcu Ad Soyad:" + passengerName + " " + passengerSurname+" "+passengerDistrict+"/"+passengerCity+" "+passengerAge);

            #endregion
            #region KlavyedenTamSayıGirişi
            //int shoesPrice, tvPrice, chairPrice, computerPrice;

            //shoesPrice = 1000;
            //tvPrice = 12000;
            //chairPrice = 6000;
            //computerPrice = 20000;

            //int shoesCount, tvCount, chairCount, computerCount;

            //Console.Write("Lütfen aldıgınız ayakKabı sayısını giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldıgınız televizyon sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldıgınız sandalye sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldıgınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //int totalPrice = (shoesPrice * shoesCount) + (tvPrice * tvCount) + (chairPrice * chairCount) + (computerPrice * computerCount);
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar:" + totalPrice);

            #endregion
            #region KlavyedenOndalıklıSayıİşlemleri
            //double exam1, exam2, exam3, result;

            //Console.Write("1.sınav notunuzu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2.sınav notunuzu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3.sınav notunuzu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav sonucunuzun ortalaması:" + result);

            #endregion
            #region KlavyedenKarakterGirişleri
            //char gender;
            //Console.Write("Lütfen bir cinsiyet giriniz:");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet:" + gender);

            #endregion
        }
    }
}
