using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1: İstifadəçidən 2 dənə ayrı dəyər alın(rəqəm). Məsələn birincidə istifadəçi 20 daxil etdi onu a dəyişənində saxlayın. İkincidə 50 daxil etdi onu da
                         b dəyişənində saxlayın. Elə edin ki, bu iki dəyişənin dəyərlərinin yerlərini dəyişdirin. Yəni a 20, b 50-dirsə elə edin ki, a olsun 50, b olsun 20.*/
                         
            int a = 20;
            int b = 50;
            //int c = a;
            //a = b;
            //b = c;

            //----ikinci usul-----
            b += a;    // b=70;
            a = b - a;   //a=50;
            b -= a;  //b=20;


           

            Console.WriteLine($"a: {a}", a); //50
            Console.WriteLine($"b: {b}", b); //20
        }
    }
}
