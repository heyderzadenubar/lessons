using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 2:
            /* int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 }; bu arrayın içindəki elementləri kiçikdən böyüyə sıralayın.
              Ancaq bunu edərkən sort və reverse method'larından istifadə etmək olmaz :). Alqoritmasını özünüz düşünün.*/
            #endregion
            int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 };
            foreach (var item in numArr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            int a;
            for (int i = 0; i < numArr.Length; i++)
            {
                for (int j = 0; j < numArr.Length-1; j++)
                {
                    if (numArr[j] > numArr[j + 1])
                    {
                        a = numArr[j];
                        numArr[j] = numArr[j + 1];
                        numArr[j + 1] = a;
                    }
                }
            }
            Console.WriteLine("_________Kicikden boyuye siralama_____________");
            foreach (var item in numArr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
