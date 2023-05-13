using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 2:
             İstifadəçidən 10 ədəd şəhər adı daxil etməsini istəyin. İstifadəçi 10-cu şəhər adını 
             daxil etdikdən sonra sıra ilə şəhər adlarını alt-alta ekrana yazdırın.
             Məsələn:
             Bakı
             Gəncə
             Sumqayıt
             */
            Console.WriteLine(" 10 seher adı daxil edin:");
            Console.WriteLine();
            var city1 = "Baki";
            var city2 ="Gence";
            var city3 = "Lenkeran";
            var city4 = "Sumqayit";
            var city5 = "Ismayilli";
            var city6 = "Agdas";
            var city7 = "Kurdemir";
            var city8 = "Fuzuli";
            var city9 = "Zengilan";
            var city10 = "Xocali";
            Console.WriteLine(" 1. " + city1);
            Console.WriteLine(" 2. " + city2);
            Console.WriteLine(" 3. " + city3);
            Console.WriteLine(" 4. " + city4);
            Console.WriteLine(" 5. " + city5);
            Console.WriteLine(" 6. " + city6);
            Console.WriteLine(" 7. " + city7);
            Console.WriteLine(" 8. " + city8);
            Console.WriteLine(" 9. " + city9);
            Console.WriteLine("10. " + city10);
            Console.Read();

        }
    }
}
