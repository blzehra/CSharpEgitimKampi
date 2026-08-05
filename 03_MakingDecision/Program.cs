using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifre giriniz:");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if (capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int num;
            //Console.Write("Sayı giriniz:");
            //num = int.Parse(Console.ReadLine());

            //if(num==5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result;

            //Console.Write("Sınav1:");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2:");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması:"+average);

            //if(average>0 & average<=50)
            //{
            //    result=("Sonuç kötü");
            //}
            //else if (average>50 & average<=70)
            //{
            //    result=("Sonuç orta");
            //}
            //else if (average>70 & average<=84)
            //{
            //    result=("Sonuç iyi");
            //}
            //else if (average>84 & average <= 100)
            //{
            //    result=("Sonuç çok iyi");
            //}
            //else
            //{
            //    result=("Hata");
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir giriniz:");
            //city = Console.ReadLine();

            //if (city=="adana" | city=="ankara" | city=="adıyaman")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //string username;
            //Console.Write("Lütfen kullanıcı adı giriniz:");
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz.");
            //}

            #endregion
            #region Modİşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("1.sayıyı giriniz:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz:");
            //int num2 = int.Parse(Console.ReadLine());

            //int result = num1 % num2;
            //Console.WriteLine("1.sayının 2.sayıya bölümünden kalan:"+result);

            //int number;
            //Console.Write("Sayıyı giriniz:");
            //number = int.Parse(Console.ReadLine());

            //if (number%2==0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}
            #endregion
            #region CharVeKararYapıları
            //char team;
            //Console.Write("Lütfen takım sembolunu giriniz:");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş"); 
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}

            #endregion
            #region ÖrnekProjeUygulaması
            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi:");
            //menuItem = Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler-----------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------------------------------");
            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Çorbalar-----------");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Sebze Çorbası");
            //    Console.WriteLine("-------------------------------");
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar-----------");
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Tavuklu Pizza");
            //    Console.WriteLine("3-Margaritha");
            //    Console.WriteLine("------------------------------");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------İçecekler-----------");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Soda");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-Su");
            //    Console.WriteLine("-------------------------------");
            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar-----------");
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Triliçe");
            //    Console.WriteLine("------------------------------");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Seçim");
            //}
            #endregion
            #region SwitchCase
            //int monthNumber;
            //Console.Write("Lütfen Ay Girişi Yapınız:");
            //monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi");break;
            //}

            #endregion
            #region  SwitchCaseHesapMakinesi
            //int num1 , num2 ,result;
            //char symbol;
            //Console.Write("1.Sayıyı Giriniz:");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz:");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi giriniz:");
            //symbol = char.Parse(Console.ReadLine());

            //switch(symbol)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine("Toplam:"+result);
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("Fark:" + result);
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("Çarpım:" + result);
            //        break;
            //    case '/':
            //        result = num1 + num2;
            //        Console.WriteLine("Bölüm:" + result);
            //        break;

            //}

            #endregion
        }
    }
}
