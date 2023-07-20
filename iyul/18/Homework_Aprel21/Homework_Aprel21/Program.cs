using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_Aprel21
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homeworks
            /*
             Homework 1:
             Exception handling nədir? Nə işə yarayır mövzusunu araşdırıb nümunələr yazın.

             Homework 2:
             Exception handling mövzusunu araşdırdıqdan sonra custom exceptionlar yazmağa çalışın. Hər hansısa bir kiçik app düşünüb ona uyğun
             custom exception'lar yaza bilərsiniz.

             Homework 3:
             Tuple mövzusunu araşdırıb nümunələr hazırlayın. Hansı halda istifadə edilə bilər, hansı halda yox onu da mövzu olaraq izah etməyə
             çalışmalısınız.

             Homework 4:
             .NET'in 1 və 2-ci versiyasından etibarən bu günə qədər olan dəyişiklikləri nəzərdən keçirin. Kod tərəfdə nəsə yazmağınıza ehtiyyac
             yoxdur. Ancaq yazmaq istəyən yazıb növbəti dərsdə nümunə kimi göstərə bilər.
             
             */
            #endregion

            #region What is Exception 
            /* Exception proqramın icrası zamanı yaranan problemdir. C# exception-i proqram işləyərkən yaranan müstəsna vəziyyətə 
             * cavabdır, məsələn, sıfıra bölmək cəhdi (divide by zero exception).
                Exceptionlar proqramın bir hissəsindən digərinə nəzarəti ötürmək üçün bir yol təqdim edir.
                C# exceptionın idarə edilməsi dörd açar sözə əsaslanır: try, catch, finally və throw.
            */
            try
            {
                int b = 10;
                int c = 10 / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exeption divide by zero!\n"+ ex.Message );
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Custom exception
            try
            {
                Console.WriteLine("Deyer: ");
                int a = Convert.ToInt16(Console.ReadLine());
                ValueClass value = new ValueClass();
                value.ShowValue(a);
            }
            catch (ValueIsSmallerThanZero ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Versiyalar
            //kohne versiyada List-in elani:
            List<string> myList = new List<string>();
            // ---.Net 7 versiyasinda List tipini bele elan etmek mumkundur:--
            // List<string> myList = new ();  // kohne versiya oldugu ucun xeta verir

            //kohne versiyada (6-ci versiyaya kimi) Console.WriteLine, String.Format kimi işləyirdi,
            //            $ işarəsi xəta verirdi (String interpolation)
            string name = "Nubar";
            Console.WriteLine("Ad: "+name);
            Console.WriteLine("Ad: {0}", name);  //string.Format

            Console.WriteLine("");   // 

            //yeni  versiyada (6-ci versiyadan sonra) String interpolation
            Console.WriteLine($"AD: {name}");
            #endregion

            #region Tuple
            /*Tuple  yüngül data strukturunda müxtəlif məlumat elementlərini qruplaşdırmaq üçün qısa sintaksis təmin edir.*/
            Tuple<int, int, string> tuple;
            tuple = new Tuple<int, int, string>(5, 5, "d");
            Console.Clear();
            Console.WriteLine(tuple);
            
            #endregion
        }
    }
}
