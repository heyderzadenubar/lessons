using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {

        
        static void Main(string[] args)
        {

            #region Homework
            /*Homework 3:
             Bir dənə int array'ında 1-1000 arası rəqəmləriniz olsun (for ilə edin).
             1. Array'dan cüt rəqəmləri sorğu ilə götürün.
             2. Arrayda 400-dən böyük, 550-yə bərabər və ya kiçik olan, tək rəqəmləri götürün.*/
            #endregion
            int[] vs = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                vs[i] = i+1;
            }


            Console.WriteLine("------Even numbers--------");
            FindEvenOddNumbersClass.EvenNumberIQueryable(vs);
            Console.WriteLine("------Odd numbers--------");
            FindEvenOddNumbersClass.OddNumberIQueryable(vs);
        }
       

    }
}
