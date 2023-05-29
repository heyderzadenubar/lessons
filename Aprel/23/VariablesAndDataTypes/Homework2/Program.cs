using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 2
            /*Bir dənə anket proqramı yığacaqsınız. İstifadəçidən onun haqqında məlumatları toplayacaqsınız. Bu məlumatlar ad, soyad, cins, doğum tarixi,
             yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq. Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.

             İstifadəçinin daxil edəcəyi məlumatlar belə olacaq:
             Ad: Mark
             Soyad: Henry
             Cins: K və ya Q
             Doğum tarixi: 1990-10-10
             Yaşadığı ölkə: Azərbaycan
             Yaşadığı şəhər: Bakı
             Boy: 1.75
             Çəki: 26.50
             Maaş: 2500.00*/
            #endregion

            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();
            Console.Write("Cinsi (K/Q): ");
            char cins = char.Parse( Console.ReadLine());
            Console.Write("Dogum tarixi (il-ay-gun): ");
            DateTime tevellud = DateTime.Parse(Console.ReadLine());
            Console.Write("Yasadigi olke: ");
            string olke = Console.ReadLine();
            Console.Write("Yasadigi seher: ");
            string seher = Console.ReadLine();
            Console.Write("Boy: ");
            float boy = float.Parse(Console.ReadLine());
            Console.Write("Ceki: ");
            float ceki = float.Parse(Console.ReadLine());
            Console.Write("Maas: ");
            float maas = float.Parse(Console.ReadLine());
            

            Console.Read();


        }
    }
}
