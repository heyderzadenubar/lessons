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
             
            Console.WriteLine(" 10 seher adı daxil edin:");
            Console.WriteLine();
            var city1 = "Baki";
            var city2 = "Gence";
            var city3 = "Lenkeran";
            var city4 = "Sumqayit";
            var city5 = "Ismayilli";
            var city6 = "Agdas";
            var city7 = "Kurdemir";
            var city8 = "Fuzuli";
            var city9 = "Zengilan";
            var city10 = "Xocali";
            Console.WriteLine(city1+", "+ city2 + ", " + city3 + ", " + city4 + ", " + city5 +
                ", " + city6 + ", " + city7 + ", " + city8 + ", " + city9 + ", " + city10 + ", ");
            Console.Read();

        }
    }
}
