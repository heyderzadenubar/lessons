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
            #region Homework 4
            /*Bir dənə kiçik console app yazın. Bu app sizdən sinif adı soruşacaq. Məsələn 1A, 1B və s. daxil ediləcək. Sonra sinif rəhbərinin adı
                soruşulacaq. Axırda isə, 10 tələbə adı soruşulacaq. Bu tələbələrin adlarını array'dan istifadə etmədən 10 ayrı string dəyişəndə
                saxlayın student1, student2, student3... və sonra sinif adı, müəllim adı, tələbələrin adlarını göndərə biləcəyiniz bir method yazın.
                Method cəmi 3 parametr qəbul edə bilər. 3-dən artıq parametr istifadə etmək haqqınız yoxdur. Axırda sinif haqqında məlumat yazısı
                və onun altında sinif adı, sinif rəhbərinin adı və tələbə adları alt-alta yazılsın. Tələbə adlarını da collection və ya list
                şəklində göndərmək haqqınız yoxdur. İp ucu verim dərsdə keçmişdik. */
            #endregion

            string sinif = "1B";
            string sinifRehberi = "rehber";
            string t1 = "t1";
            string t2 = "t2";
            string t3 = "t3";
            string t4 = "t4";
            string t5 = "t5";
            string t6 = "t6";
            string t7 = "t7";
            string t8 = "t8";
            string t9 = "t9";
            string t10 = "t10";

            Sinif(sinif, sinifRehberi, t1,t2,t3,t4,t5,t6,t7,t8,t9,t10);
        }

        static void Sinif(string sinif, string sinifRehberi, params string[] telebe)
        {
            Console.WriteLine($"Sinif: {sinif}");
            Console.WriteLine($"Sinif rehberi: {sinifRehberi}");
            for(int i = 0; i < telebe.Length; i++)
            {
                Console.WriteLine($"{i+1}. telebe: {telebe[i]}");
            }
        }
    }
}
