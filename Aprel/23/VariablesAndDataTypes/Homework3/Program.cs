using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Homework 3:
            /* İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız.
             * Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert edəcəksiniz.
             * Daha sonra int dəyişənini byte tipinə cast edəcəksiniz(explicit conversion).
             Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa 
             heç bir xəta çıxmasın. Maaşını və ya yaşını byte tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa 
             elə edin ki, proqramda xəta çıxsın. */
            #endregion
            
            Console.Write("Yasiniz: ");
            string yasString = Console.ReadLine();
            Console.Write("Maas: ");
            string maasString = Console.ReadLine();
            Console.Write("Boy: ");
            string boyString = Console.ReadLine();
            Console.Write("Ceki: ");
            string cekiString = Console.ReadLine();
            Console.Write("Dost sayi: ");
            string sayString = Console.ReadLine();


            int yasInt = Convert.ToInt32(yasString);
            int maasInt = Convert.ToInt32(maasString);
            int boyInt = Convert.ToInt32(boyString);
            int cekiInt = Convert.ToInt32(cekiString);
            int sayInt = Convert.ToInt32(sayString);
            //-------Expilicit convension----------

            checked
            {
                byte yasByte= (byte)yasInt;
                Console.WriteLine("Yasin deyeri 255-den boyukdur");
            }
            checked
            {
                byte maasByte = (byte)maasInt;
                Console.WriteLine("Maasin deyeri 255-den boyukdur");
            }

            byte boyByte = (byte)boyInt;
            byte cekiByte = (byte)cekiInt;
            byte sayByte = (byte)sayInt;
            Console.Read();

            
            

        }
    }
}
