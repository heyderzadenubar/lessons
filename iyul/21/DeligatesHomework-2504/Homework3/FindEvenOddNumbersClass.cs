using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class FindEvenOddNumbersClass
    {
        public static void EvenNumberIEnumerable(int[] vs)   // yoxlamaq ucun yazdim 
        {
            IEnumerable<int> resultEvenNumbers = from a in vs
                                                 where a%2==0
                                                 select a;
            foreach (int item in resultEvenNumbers)
            {
                Console.WriteLine(item + " ");
            }
        } 

        public static void EvenNumberIQueryable(int[] vs)
        {
            IQueryable<int> result = vs.AsQueryable().Where(m => m % 2 == 0);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void OddNumberIEnumerable(int[] vs) // yoxlamaq ucun yazdim 
        {
            IEnumerable<int> resultOddNumbers = from a in vs
                                                where a > 400 && a <= 550 && a % 2 == 1
                                                select a;

            foreach (int item in resultOddNumbers)
            {
                Console.WriteLine(item + " ");
            }
        }

        public static void OddNumberIQueryable(int[] vs)
        {
            IQueryable<int> result = vs.AsQueryable().Where(m =>
                                                            m % 2 == 1 &&
                                                            m > 400 &&
                                                            m < 550);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
}
