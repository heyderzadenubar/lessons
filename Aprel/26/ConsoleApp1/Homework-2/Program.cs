using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 2: İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın. İstifadəçi 3-cü rəqəmi daxil etdikdən 
             sonra ekrana belə bir yazı yazdırın Nəticə: 5 + 5 + 10 = 20. Bunu çıxma, vurma və bölmə üçün də edin.*/
             
            int _a, _b, _c;
            Console.WriteLine("1-ci reqem: ");
            _a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci reqem: ");
            _b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3-cu reqem: ");
            _c = Convert.ToInt32(Console.ReadLine());

            //------toplama--------
            Console.WriteLine($"Netice (toplama): {_a} + {_b} + {_c} = {_a+_b+_c}");
            //------cixma--------
            Console.WriteLine($"Netice (cixma): {_a} - {_b} - {_c} = {_a - _b - _c}");
            //------vurma--------
            Console.WriteLine($"Netice (vurma): {_a} * {_b} * {_c} = {_a * _b * _c}");
            //------bolme--------
            Console.WriteLine($"Netice (bolme): {_a} : {_b} : {_c} = {(double)_a / (double)_b / (double)_c}");

        }
    }
}
