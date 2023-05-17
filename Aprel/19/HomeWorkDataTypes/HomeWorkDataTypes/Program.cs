﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataTypesExamples:

            /*   Ev tapşırığı olaraq ilk növbədə ən az 2-3 saat internetdə "C# data types" (C# veri tipleri) mövzusunu geniş bir şəkildə araşdırırsınız.
             Araşdıra-araşdıra da bir Console App açıb araşdırdığınız data tiplərindən nümunələr yazırsınız. Hər data type üçün ən az 5 fərqli nümunə yazın.*/
           
            //byte -- 1byte
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("byte ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Range --- 1 byte");
            Console.WriteLine("Default value: " + default(byte));
            Console.WriteLine("Min. value: " + byte.MinValue);
            Console.WriteLine("Max. value: " + byte.MaxValue);
            Console.WriteLine();

            //sbyte -- 1byte
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("sbyte ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Range --- 1 byte");
            Console.WriteLine("Default value: " + default(sbyte));
            Console.WriteLine("Min. value: " + sbyte.MinValue);
            Console.WriteLine("Max. value: " + sbyte.MaxValue);
            Console.WriteLine();

            //short -- 1byte
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("short ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Range --- 2 byte");
            Console.WriteLine("Default value: " + default(short));
            Console.WriteLine("Min. value: " + short.MinValue);
            Console.WriteLine("Max. value: " + short.MaxValue);
            Console.WriteLine();

            //int -- 4byte
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Int ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Range --- 4 byte");
            Console.WriteLine("Default value: " + default(int));
            Console.WriteLine("Min. value: " + int.MinValue);
            Console.WriteLine("Max. value: " + int.MaxValue);
            Console.WriteLine();
            
            //uint -- 4byte
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("uint ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Suffix: u");
            Console.WriteLine("Range --- 4 byte");
            Console.WriteLine("Default value: " + default(uint));
            Console.WriteLine("Min. value: " + uint.MinValue);
            Console.WriteLine("Max. value: " + uint.MaxValue);
            Console.WriteLine();

            //long -- 8byte
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("long ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Range --- 8 byte");
            Console.WriteLine("Default value: " + default(long));
            Console.WriteLine("Min. value: " + long.MinValue);
            Console.WriteLine("Max. value: " + long.MaxValue);
            Console.WriteLine();

            //ulong -- 8byte
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ulong ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Suffix: ul");
            Console.WriteLine("Range --- 8 byte");
            Console.WriteLine("Default value: " + default(ulong));
            Console.WriteLine("Min. value: " + ulong.MinValue);
            Console.WriteLine("Max. value: " + ulong.MaxValue);
            Console.WriteLine();

            //float -- 4byte
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("float ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Suffix: f");
            Console.WriteLine("Range --- 4 byte");
            Console.WriteLine("Default value: " + default(float));
            Console.WriteLine("Min. value: " + float.MinValue);
            Console.WriteLine("Max. value: " + float.MaxValue);
            Console.WriteLine();
            
            //double -- 8byte
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("double ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Suffix: d");
            double adouble = 10.578;
            Console.WriteLine("Range --- 8 byte");
            Console.WriteLine("Default value: " + default(double));
            Console.WriteLine("Min. value: " + double.MinValue);
            Console.WriteLine("Max. value: " + double.MaxValue);
            Console.WriteLine();

            //decimal -- 16byte
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("decimal ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Suffix: m");
            decimal aDecimal = 10.5m;
            Console.WriteLine("Range --- 16 byte");
            Console.WriteLine("Default value: " + default(decimal));
            Console.WriteLine("Min. value: " + decimal.MinValue);
            Console.WriteLine("Max. value: " + decimal.MaxValue);
            Console.WriteLine();

            //char -- 2byte; required '', only one character
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("char ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Range --- 2 byte");
            Console.WriteLine("Default value: " + default(char));
            Console.WriteLine();

            //bool -- 1bit
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("bool ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            Console.WriteLine("Range --- 1 byte");
            Console.WriteLine("Default value: " + default(bool));
            bool aBool = 10 < 5;
            Console.WriteLine("10<5 is " + aBool);
            Console.WriteLine();

            //string -- "" Unicode character
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("string ");
            Console.ResetColor();
            Console.WriteLine("data type:");
            string Metar = "UBBB 170700Z 35020KT 9999 FEW060CB 17/11 Q1015 NOSIG";
            Console.WriteLine(Metar);
            Console.WriteLine("Decoder:");
            Console.WriteLine("ICAO code: "+ Metar.Substring(0,4));           //substring
            Console.WriteLine("Date&Time: " + Metar.Substring(5, 7));
            Console.WriteLine("Wind: " + Metar.Substring(13, 7));
            Console.WriteLine("ToLower: "+Metar.ToLower());
            Console.WriteLine("Length: "+Metar.Length);


            #endregion

            #region Homework 2:
            /* "C# variable naming convention"(C# değişken isimlendirme kuralları) mövzusunu araşdırırsınız. Araşdırmanızın nəticəsi olaraq, araşdırdığınız
             adlandırma qaydalarından yola çıxaraq dəyişən adları yazın.*/

            #endregion

            #region Homework 3:



            string s = "Decimal values";
            decimal sdecimal = decimal.Parse( Console.ReadLine());
            decimal sDecimal = decimal.Parse(Console.ReadLine());
            char sChar = 's';
            Console.Write(s+" "+sChar+" "+ sdecimal/sDecimal);
            Console.Read();
            /* int, bool, char, string və long tipində dəyişənlər yaradıb onlara dəyər verirsiniz.Sonra elə bir dəyişən yaratmalısınız ki, bütün bu dəyişənləri
              ona dəyər olaraq mənimsədə biləsiniz.  */
            #endregion

            #region  Homework 4:
            /* Araşdırdığınız dəyişən tipləri barədə bir yazı hazırlayacaqsız.Hər bir data type'ın nə kimi bir dəyər aldığını, neçə bit olduğunu və s. araşdırın.
                 Qeyd: mövzuları araşdırarkən bir saytdan və ya qaynaqdan araşdırmayın.Fərqli - fərqli qaynaqlara baxın. */
            #endregion

        }
    }
}
