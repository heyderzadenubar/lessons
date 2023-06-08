using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 1:
            /* Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız. Bunun üçün öncə bütün elementlərin toplamını
                tapın sonra onu array'dakı element sayına bölün. Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq
                bir array yaradacaq. Arrayı yaratdıqdan sonra bütün elementlərinin dəyərlərini istifadəçidən soruşub array'ı doldurun.
                Axırda da elementlərin toplamını və ortalama dəyərini ekrana yazdırın. Bunu həm for döngüsüylə edin həm də foreach.*/
            #endregion

            Console.Write("Elementlerin sayini daxil edin:  ");
            int say = Convert.ToInt32(Console.ReadLine());
            double[] ededlerArray = new double[say];
            double cemFor = 0, cemForeach = 0, ortalamaFor, ortalamaForeach;

            Console.WriteLine("________ For dongusu ucun ________");
            for(int i = 0; i < ededlerArray.Length; i++)
            {
                Console.WriteLine($"{i}. ededi daxil edin: ");
                ededlerArray[i] = Convert.ToDouble(Console.ReadLine());
                cemFor += ededlerArray[i];
            }
            ortalamaFor = cemFor / say;
            Console.WriteLine($"Cem: {cemFor}");
            Console.WriteLine($"Ortalama: {ortalamaFor}");
            Console.WriteLine();

            Console.WriteLine("__________ Foreach ucun _________");
            foreach (var item in ededlerArray)
            {
                cemForeach += item;
            }
            ortalamaForeach = cemForeach / say;
            Console.WriteLine($"Cem: {cemForeach}");
            Console.WriteLine($"Ortalama: {ortalamaForeach}");
        }
    }
}
