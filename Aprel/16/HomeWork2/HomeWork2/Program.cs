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
            Console.WriteLine();
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
