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
        /*Homework 2:
         Switch-case ilə sadə kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. Toplama, çıxma, vurma
         və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana nəticəni çıxardacaqsız. Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. İstifadəçi
         istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək. */

        BeginAgain:
            Console.WriteLine("");
            Console.WriteLine("Emeliyyati secin:");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Cixma");
            Console.WriteLine("3. Vurma");
            Console.WriteLine("4. Bolme");
            int a = 555;
            int b = 6;

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{a} + {b} = {a+b}");
                    goto BeginAgain;
                case 2:
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    goto BeginAgain;
                case 3:
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    goto BeginAgain;
                case 4:
                    Console.WriteLine($"{a} : {b} = {a / b}");
                    goto BeginAgain;
                default:
                    Console.WriteLine("Emeliyyat movcud deyil!");
                    goto BeginAgain;
            }


        }
    }
}
