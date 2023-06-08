using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 3:
            /*Bir array'a Random() ilə 1-100000 arası 100 ədəd rəqəm yığın. Sonra həmin array'dakı ən kiçik və ən böyük rəqəmləri tapın. 
              Əlavə olaraqda bütün rəqəmlərin  toplamını ekrana yazdırın.*/
            #endregion

            int[] NumArr = new int[100];
            Random randNum = new Random();
            
            for(int i = 0; i < NumArr.Length; i++)
            {
                NumArr[i] = randNum.Next(1,100000);
            }

            int min = NumArr[0];
            int max = NumArr[0];
            int sumFor = 0;
            
            for (int i = 1; i < NumArr.Length; i++)
            {
                if (NumArr[i] < min)
                {
                    min = NumArr[i];
                }
            }
            for (int i = 1; i < NumArr.Length; i++)
            {
                if (NumArr[i] > max)
                {
                    max = NumArr[i];
                }
            }
            for (int i = 0; i < NumArr.Length; i++)
            {
                sumFor += NumArr[i];
            }

            Console.WriteLine($"Min. number: {min}");
            Console.WriteLine($"Max. number: {max}");
            Console.WriteLine($"Sum numbers: {sumFor}");
        }
    }
}
