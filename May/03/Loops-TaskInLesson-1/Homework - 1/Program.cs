using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1: İstifadəçi mənfi dəyər daxil edənə qədər, daxil etdiyi bütün müsbət rəqəmləri toplayıb axırda 
            //            nəticəni ekrana yazın.

            double a, cem=0;
            a = Convert.ToDouble(Console.ReadLine());

            while (a >= 0)
            {
                cem += Convert.ToDouble(a);
                a = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"{a} menfi ededdir!");
            Console.WriteLine($"Cem: {cem}");
        }
    }
}
