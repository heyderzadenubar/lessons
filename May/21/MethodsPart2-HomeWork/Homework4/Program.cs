    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 4:
            /* 
                 Bir dənə kiçik console app yazın. Bu app sizdən sinif adı soruşacaq. Məsələn 1A, 1B və s.daxil ediləcək. Sonra sinif rəhbərinin adı
                 soruşulacaq.Axırda isə, 10 tələbə adı soruşulacaq.Bu tələbələrin adlarını array'dan istifadə etmədən 10 ayrı string dəyişəndə
                 saxlayın student1, student2, student3... və sonra sinif adı, müəllim adı, tələbələrin adlarını göndərə biləcəyiniz bir method yazın.
                 Method cəmi 3 parametr qəbul edə bilər. 3 - dən artıq parametr istifadə etmək haqqınız yoxdur. Axırda sinif haqqında məlumat yazısı
                   və onun altında sinif adı, sinif rəhbərinin adı və tələbə adları alt-alta yazılsın.Tələbə adlarını da collection və ya list
                  şəklində göndərmək haqqınız yoxdur.İp ucu verim dərsdə keçmişdik.*/
            #endregion

            Console.Write("Sinif: ");
            string _sinif = Console.ReadLine();
            Console.Write("Sinif rehberi: ");
            string _sinifRehberi = Console.ReadLine();
            string s1 = "T1";
            string s2 = "T2";
            string s3 = "T3";
            string s4 = "T4";
            string s5 = "T5";
            string s6 = "T6";
            string s7 = "T7";
            string s8 = "T8";
            string s9 = "T9";
            string s10 = "T1";
            Sinif(_sinif, _sinifRehberi, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
            Console.ReadLine() ;
        }
       public static void Sinif(string a,string b, params string[] list )
        {
            Console.WriteLine("Sinif: " + a);
            Console.WriteLine("Sinif rehberi: "+b);

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
