using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Yeşil";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 546;
            //numbers[1] = 32;
            //numbers[7] = 42;
            //numbers[8] = 20;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            //int[] nums = { 43, 54, 3, 2, 5, 9 };
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}
            //Console.WriteLine("Dizideki sayıların toplamı:" + sum);

            //int[] nums = { 51, 24, 36, 43, 53, 69, 75, 80, 92, 20 };
            //Console.Write("Çift Sayılar:");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        Console.Write(nums[i] + " ");
            //    }
            //}
            //Console.WriteLine();
            //Console.Write("Tek Sayılar:");
            //for (int j = 0; j < nums.Length; j++)
            //{
            //    if (nums[j] % 2 != 0)
            //    {
            //        Console.Write(nums[j] + " ");
            //    }
            //}

            #endregion
            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Mavi", "Kırmızı", "Sarı", "Beyaz", "Turuncu" , "Pembe"};
            //for(int i=0;i<colors.Length;i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 590, 96,45, 74, 488, 674, 932,30};
            //for(int i=0;i<numbers.Length;i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbol = { 'a', 'c', 'd', '+', '?' };
            //for(int i=0;i<symbol.Length;i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            //int[] myArray = { 4, 54, 532, 654, 32, 53, 986, 953, 998 };
            //int maxValue = myArray[0];
            //for(int i=1;i<myArray.Length;i++)
            //{
            //    if (myArray[i]>maxValue)
            //    {
            //        maxValue = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxValue);

            #endregion
            #region Dizi Metotları

            //string[] persons = { "Ali", "Ayşe", "Ahmet", "Zehra" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 40, 55, 42, 32, 23, 52, 96 };
            //Array.Sort(numbers);
            //for(int i=0;i<numbers.Length;i++)
            //{
            //    Console.Write(numbers[i]+" ");
            //}
            //Console.WriteLine();

            //int[] nums= { 3, 43, 89, 76, 65, 48 };
            //Array.Reverse(nums);
            //for(int j=0;j<nums.Length;j++)
            //{
            //    Console.Write(nums[j]+" ");
            //}

            //string[] customers = { "Ali", "Ahmet", "Ayşe", "Zehra", "Mehmet" };
            //int index = Array.IndexOf(customers, "Ayşe");
            //Console.WriteLine(index);

            //int[] nums = { 50, 43, 53, 32, 24, 98 };
            //Console.WriteLine("Dizinin en büyük elemanı:"+nums.Max()+" Dizinin en küçük elemanı:"+nums.Min());

            #endregion
            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[4];
            //for(int i=0;i<cities.Length;i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz:");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("-------------------------");
            //for(int j=0;j<cities.Length;j++)
            //{
            //    Console.WriteLine(cities[j]);
            //}


            #endregion
        }
    }
}
