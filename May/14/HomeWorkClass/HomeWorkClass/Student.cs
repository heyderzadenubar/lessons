using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMethods
{
    class Student
    {
      

        public decimal CalcAverage(decimal a, decimal b, decimal c)
        {
            decimal resultAverage = (a + b + c) / 3;
            return resultAverage;
        }

        public decimal CalcAverage(decimal a)
        {
            decimal resultAverage = Math.Round(a,2);
            return resultAverage;
        }


        public void RateAverage(decimal a)
        {
            if (a > 45)
                Console.WriteLine("You passed the exam successfully.");
            else
                Console.WriteLine("Failed an exam.");
            Console.ReadLine();
            Console.ReadLine();
        }

    }
}
