using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForDöngüsü

            //int i;
            //for(i=1;i<=5;i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for(int i=1;i<=20;i++)
            //{
            //    Console.Write(i+" ");
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //int finishValue;
            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz:");
            //finishValue = int.Parse(Console.ReadLine());

            //for (int i=1;i<=finishValue;i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            #endregion
            #region ForDöngüsüİleKararYapıları

            //for (int i=1;i<=100;i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.Write(i+" ");
            //    }
            //}

            //int totalValue = 0;
            //for(int i=1;i<=10;i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue=0;
            //for(int i=1;i<20;i++)
            //{
            //    if(i%2==0)
            //    {
            //        totalValue += i;
            //        Console.Write(i+" ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Toplam:"+totalValue);

            //int count=0;
            //for(int i=1;i<=60;i++)
            //{
            //    if(i%7==0)
            //    {
            //        count += 1;
            //        Console.Write(i+" ");
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("1'den 60'ye kadar 7'ye tam bölünen sayı miktarı:"+count);

            //int totalBacteria=1;
            //for(int i=1;i<=24;i++)
            //{
            //    totalBacteria *= 2;
            //    Console.WriteLine(i+". saat sonunda oluşan toplam bakteri:"+totalBacteria);
            //}

            #endregion
            #region WhileDöngüsü

            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while(i<=40)
            //{
            //    if(i%3==0)
            //    {
            //        Console.Write(i+" ");
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while(i<=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Toplam:"+sum)

            #endregion
            #region ÖrnekSınavSorusu

            //int num;
            //Console.Write("3 basamaklı bir sayı giriniz:");
            //num = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = num % 10;
            //tens = (num%100)/10;
            //hundreds = num / 100;

            //sum = ones + tens + hundreds;
            //Console.WriteLine("Basamakları toplamı:"+sum);

            #endregion
        }
    }
}
