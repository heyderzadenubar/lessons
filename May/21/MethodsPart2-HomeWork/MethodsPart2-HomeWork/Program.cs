using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart2_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Method overloading

            /* Homework 1:
               Method overloading araşdırın.*/

            //In C#, there might be two or more methods in a class with the same name 
            //but DIFFERENT NUMBERS, TYPES, and ORDER OF PARAMETERS, it is called method overloading. 

            #endregion

            #region Ref və Out keyword
            /* Homework 2:
               Ref və Out keyword'larını araşdırın.

            --------REF KEYWORD------
            Ref açar sözü arqumentləri istinadla ötürür. 
            İstifadə səbəbi sürətə görə deyil, metod daxilində edilən dəyişikliyi dəyər növünə tətbiq etməkdir.  */

            Console.WriteLine("--------REF KEYWORD------");
            Console.WriteLine("");
            int _iREF = 0;
            Console.WriteLine("Current number: " + _iREF);
            Ref_Out_Class1.nextNumberVoid(_iREF);
            Console.WriteLine("Next number (for i): " + _iREF+ "   (without ref)");    //without ref
            Ref_Out_Class1.nextNumberREF(ref _iREF);
            Console.WriteLine("Next number (for i): " + _iREF + "   (with ref)");
            Ref_Out_Class1.nextNumberREF(ref _iREF);
            Console.WriteLine("Next number (for i): " + _iREF + "   (with ref)");
            Console.WriteLine("");

            /* -----OUT KEYWORD------
            C#-da ref və out açar sözləri eyni əməliyyatı edir.
            Lakin ref istifadə edərkən ilkin qiymət dəyişənə verilməlidir, 
                  out açar sözündən istifadə edərkən ilkin qiymət vermək lazım deyil.
                  out o deməkdir ki, parametr returnden əvvəl funksiyada işə salınacaq (initializasiya).*/
    
            Console.WriteLine("/--------OUT KEYWORD------");
            Console.WriteLine("");
            int _iOUT;   // value-suz xeta verdi
           // Console.WriteLine("Current number: " + _iOUT);
            Ref_Out_Class1.nextNumberOUT(out _iOUT);
            Console.WriteLine("Next number: " + _iOUT);
            Ref_Out_Class1.nextNumberOUT(out _iOUT);
            Console.WriteLine("Next number: " + _iOUT);
            Console.WriteLine("");

            Console.WriteLine("/--------TryParse------");
            Console.WriteLine("");
        BeginAgain:
            Console.Write("Add phone number: ");
            string _phoneNumberString = Console.ReadLine();    //Console.Read()  xeta verdi
            decimal _phoneNumberDecimal;
            if(!decimal.TryParse(_phoneNumberString, out _phoneNumberDecimal))
            {
                Console.WriteLine("Input value must be number");
                goto BeginAgain;
            }
            Console.WriteLine();

            #endregion

            
        }

    }
        
}
