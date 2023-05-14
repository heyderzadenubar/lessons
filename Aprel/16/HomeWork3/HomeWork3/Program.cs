using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Homework 3:
             Eyni qaydada istifadəçidən 10 ədəd şəhər adı soruşun. 10 - cu şəhərin adını daxil edəndən sonra
             bu dəfə alt-alta yox vergüllə ayırıb yazın.
             Məsələn: Baki, Gence, Sumqayit
             */
             
            Console.WriteLine(" Enter 10 city names:");
            Console.WriteLine();
            var city1 = Console.ReadLine();
            var city2 = Console.ReadLine();
            var city3 = Console.ReadLine();
            var city4 = Console.ReadLine();
            var city5 = Console.ReadLine();
            var city6 = Console.ReadLine();
            var city7 = Console.ReadLine();
            var city8 = Console.ReadLine();
            var city9 = Console.ReadLine();
            var city10 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(city1+", "+ city2 + ", " + city3 + ", " + city4 + ", " + city5 +
                ", " + city6 + ", " + city7 + ", " + city8 + ", " + city9 + ", " + city10);
            Console.Read();

        }
    }
}
