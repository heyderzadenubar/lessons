using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_TasksInLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sinifde nece telebe var?");
            short studentCount = Convert.ToInt16(Console.ReadLine());

            string[] students = new string[studentCount];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(i + ". Telebenin adini daxil edin: ");
                string studentName = Console.ReadLine();
                students[i] = studentName;
            }
            Console.WriteLine();
            Console.WriteLine("_________ Task in lesson - 1 ______________");
            Console.WriteLine();

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{i}. {students[i]}");
            }

            #region Task in Lesson 2
            /*
             2 array yaradin. Istifadeciden telebenin ad ve yas melumatlarini alib bu arraylarda saxlayin.
             Arrayin olculerini istifadeciden sorusun.
             Sonra dongu daxilinde, ad ve yas melumatlarini ayri-ayriliqda sorusub arraylara
             doldurun. Sonra da basqa bir for dongusunde telebenin ad ve yas melumatlarini index deyerlerile
             birlikde ekrana yazdirin.
             Meselen:
             0. Orkhan 27 yasindadir.
             1. Vahid 27 yasindadir.
             */
            Console.WriteLine();
            Console.WriteLine("_________ Task in lesson - 2 ______________");
            Console.WriteLine();
            Console.WriteLine("Sinifde nece telebe var ? ");
            short telebeSayi = Convert.ToInt16(Console.ReadLine());

            string[] adlar = new string[telebeSayi];
            
            for(int i = 0; i < adlar.Length; i++)
            {
                Console.Write($"{i}. telebe: ");
                adlar[i] = Console.ReadLine();
            }

            byte[] yas = new byte[telebeSayi];
            for(int i = 0; i < yas.Length; i++)
            {
                Console.Write($"{i}. telebenin yasi: ");
                yas[i] = Convert.ToByte(Console.ReadLine());
            }

            Console.WriteLine();
            for(int i = 0; i < adlar.Length; i++)
            {
                Console.WriteLine($"{i}. {adlar[i]} {yas[i]} yasindadir ");
            }
            
            #endregion
        }
    }
}
