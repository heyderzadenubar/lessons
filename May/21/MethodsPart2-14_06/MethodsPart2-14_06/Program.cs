using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart2_14_06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Flexible (deyisken) sayda parametrler
            #region Task in lesson 1

            Addition(5, 10, 15, 45);
            Addition(5, 18, 15, 65, 4, 5);
            Addition(5, 18, 15, 65, 8);
            Addition(4, 5, 18, 15, 65, 7, 8, 64, 15, 4, 4, 5, 95, 74, 45, 41, 50);
            #endregion
            #endregion
        }

        static decimal Addition (params decimal[] numbers)
        {
            decimal sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }

    
}