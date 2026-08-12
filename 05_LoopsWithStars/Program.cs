using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Yıldız

            //for(int i=1;i<=10;i++)
            //{
            //    Console.WriteLine("*");
            //}

            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("*");
            //    i++;
            //}

            #endregion
            #region Yan Yana 10 Yıldız

            //for (int i=1;i<=10;i++)
            //{
            //    Console.Write("*");
            //}

            #endregion
            #region Al Alta 10 Her Satırda 10 Yıldız

            //for(int i=1;i<=10;i++)
            //{
            //    Console.WriteLine("**********");
            //}

            //for(int i=1;i<=10;i++)
            //{
            //    for(int j=1;j<=10;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Dik Üçgen

            //for(int i=1;i<=7;i++)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Ters Dik Üçgen

            //for(int i=1;i<=7;i++)
            //{
            //   for(int j=i;j<=7;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i=7;i>=1;i--)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Dik Ve Ters Üçgen Birleşimi

            //for(int i=1;i<=5;i++)
            //{
            //    for(int j=1;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int i=1;i<=4;i++)
            //{
            //    for(int j=i;j<=4;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Baklava Dilimi

            // int n = 5;

            //// Üst Kısım
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Alt Kısım
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Piramit

            //int n = 5;
            //for(int i=1;i<=n;i++)
            //{
            //    // boşluklar
            //    for(int j=n-i;j>0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // yıldızlar
            //    for(int k=1;k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Ters Piramit

            //int n = 5;
            //for(int i=n;i>=1;i--)
            //{
            //    // boşluklar
            //    for(int j=n-i;j>0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // yıldızlar
            //    for(int k=1;k<=2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
        }
    }
}
