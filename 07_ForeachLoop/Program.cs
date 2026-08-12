using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "Milano", "Roma", "Budapeşte", "İstanbul","Ankara "};
            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] nums = { 32, 43, 65, 49, 23, 59, 7584, 154, 44, 48, 78 };
            //foreach (int num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            //int[] nums = { 32, 43, 65, 49, 23, 59, 7584, 154, 44, 48, 78 };
            //foreach (int num in nums)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //int[] nums = { 32, 43, 65, 49, 23, 59, 7584, 154,44,48,78 };
            //int total = 0;
            //foreach(int x in nums)
            //{
            //    total += x;
            //}
            //Console.WriteLine("Dizideki tüm sayıların toplamı:"+total);

            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion
            #region Liste

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach(int num in numbers)
            //{
            //    Console.Write(num+" ");
            //}

            #endregion
            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("----------------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var:");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            double[] studentExamAvg = new double[studentCount];
            string[] studentsName = new string[studentCount];


            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.Öğrencinin ismi:");
                studentsName[i] = Console.ReadLine();

                double TotalexamResult = 0;

                //Her Öğrenci İçin 3 Sınav Notu Girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentsName[i]} adlı öğrencinin {j + 1}.sınav notunu giriniz:");
                    double value = double.Parse(Console.ReadLine());
                    TotalexamResult += value;
                }
                Console.WriteLine();
                studentExamAvg[i] = TotalexamResult / 3;


            }
            Console.WriteLine("----------------------------------------");

            //Öğrencilerin sınav ortaş
            for(int i=0;i<studentCount;i++)
            {
                Console.WriteLine($"{studentsName[i]} adlı öğrencinin not ortalaması:{studentExamAvg[i]:F2}");

                //Öğrencilein geçip kalma durumları
                if (studentExamAvg[i]>=50)
                {
                    Console.WriteLine($"{studentsName[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentsName[i]} adlı öğrenci dersten kaldı.");
                }
                Console.WriteLine("------------------------------------------");
            }
           

            #endregion
        }
    }
}