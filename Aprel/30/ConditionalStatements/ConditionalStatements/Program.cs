using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task in Lesson 1
            /*
             Task: İstifadəçidən bir dəyər alın. Əgər dəyər rəqəm deyilsə, ekrana "Xahis olunur bir reqem daxil edin" yazısı çıxsın. Deyer reqemdirse ancaq 0-dan
                   kiçik, 100-dən böyükdürsə "Düzgün bal daxil edilməyib" yazdırın. Əgər rəqəmdirsə, aralıqlara görə ekrana bir imtahan nəticəsi yazın.
                       
                   Bal 20-dən kiçik olarsa "İmtahandan kəsildiniz" yazın.
                   20-dən böyük və ya bərabər, 40-dan kiçik olarsa ekrana "Tebrikler! Siz imtahandan kecdiniz!" yazsın və bir sətir altında "Netice: qenaetbexs"
                   40-dan böyük və ya bərabər, 60-dan kiçik olarsa ekrana yenə təbriklər yazıb altında da "Netice: kafi"
                   60-dan böyük və ya bərabər, 80-dan kiçik olarsa ekrana yenə də təbriklər altında da "Netice: yaxsi"
                   80-a bərabər və ya böyük olarsa ekrana təbriklərin altında "Netice: Ela" yazsın.
             */
            double bal;
            bool parseDouble = double.TryParse(Console.ReadLine(), out bal);
            if (!parseDouble)
            {
                Console.WriteLine("Xahis olunur bir reqem daxil edin");
            } else if (bal < 0 || bal > 100)
            {
                Console.WriteLine("Düzgün bal daxil edilməyib");
            } else if (bal < 20)
            {
                Console.WriteLine("İmtahandan kəsildiniz");
            }
            else if(bal>=20 && bal < 40)
            {
                Console.WriteLine("Tebrikler! Siz imtahandan kecdiniz!");
            }else if(bal>=40 && bal < 60)
            {
                Console.WriteLine("Tebrikler!");
                Console.WriteLine("Netice: kafi");
            } else if (bal >= 60 && bal < 80)
            {
                Console.WriteLine("Tebrikler!");
                Console.WriteLine("Netice: yaxsi");
            }else if (bal >= 80)
            {
                Console.WriteLine("Netice: Ela"); 
            }
            #endregion

            #region Task in Lesson 2
            /*  Kiçik bir kalkulyator app'ı yazacaqsız. İlk öncə istifadəçiyə edə biləcəyi əməliyyatları nömrələriylə göstərin.
                "Etmek istediyiniz emeliyyati secin:"
                "1. Toplama"
                "2. Çıxma"
                "3. Vurma"
                "4. Bölmə"
                İstifadəçi əməliyyatı seçəndən sonra a və b dəyərlərini rəqəm olaraq alın və əməliyyatı icra edib nəticəni göstərin.Sadəcə bir dənə bölmə
                əməliyyatında əgər b - nin dəyəri 0 olarsa ekrana "Dəyər 0-a bölünə bilməz!" yazdırın.
               */
            Console.WriteLine("Etmek istediyiniz emeliyyati secin:");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıxma");
            Console.WriteLine("3. Vurma");
            Console.WriteLine("4. Bölmə");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1-ci eded: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci eded: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine($"{a} + {b} = {a+b}");
            }else if (choice == 2)
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }else if (choice == 3)
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }else  if (choice == 4)
            {
                if (b == 0)
                    Console.WriteLine("Dəyər 0-a bölünə bilməz!");
                else
                    Console.WriteLine($"{a} : {b} = {a / b}");
            }
            #endregion


        }
    }
}
