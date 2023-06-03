using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task in Lesson 3
            /*
             1. İstifadəçidən ay'ı rəqəm olaraq alıb switch-case'dən istifadə edərək həmin ayın adını ekrana yazdırın. Məsələn 1 olsa yanvar, 5 olsa may.
             2. İstifadəçi ölkənin adını daxil edəndə paytaxtının adını ekrana yazdırın. 10 dənə ölkə olsa kifayətdir.*/

             //------------- 1 -----------------
            int ay = Convert.ToInt32(Console.ReadLine());
            switch (ay)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case 2:
                    Console.WriteLine("Fevral");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("İyun");
                    break;
                case 7:
                    Console.WriteLine("İyul");
                    break;
                case 8:
                    Console.WriteLine("Avqust");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr");
                    break;
                case 11:
                    Console.WriteLine("Noyabr");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;
                default:
                    Console.WriteLine("İlde 12 ay var");
                    break;
            }

            string olke = "";
            switch (olke)
            {
                case "Azerbaycan":
                    Console.WriteLine("Paytaxt: Baki");
                    break;
                case "Turkiye":
                    Console.WriteLine("Paytaxt: Ankara");
                    break;
                case "Gurcustan":
                    Console.WriteLine("Paytaxt: Tbilisi");
                    break;
                case "Fransa":
                    Console.WriteLine("Paytaxt: Paris");
                    break;
                case "Italiya":
                    Console.WriteLine("Paytaxt: Roma");
                    break;
                case "Danimarka":
                    Console.WriteLine("Paytaxt: Kopenhagen");
                    break;
                case "Hindistan":
                    Console.WriteLine("Paytaxt: Yeni Dehli");
                    break;
                case "Almaniya":
                    Console.WriteLine("Paytaxt: Berlin");
                    break;
                case "İsvec":
                    Console.WriteLine("Paytaxt: Stokholm");
                    break;
                default:
                    Console.WriteLine("Olke tapilmadi!");
                    break;
            }
            #endregion

        }
    }
}
