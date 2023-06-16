using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMethods
{
    class Student
    {
      

        public decimal CalcAverage(decimal a, decimal b, decimal c=0)
        {
            decimal resultAverage =  (a + b + c) / 3;
            resultAverage = Math.Round(resultAverage, 2);
            return resultAverage;
        }

        public decimal CalcAverage(string name, string surname,decimal a, decimal b, decimal c = 0)
        {
            decimal resultAverage = (a + b + c) / 3;
            resultAverage = Math.Round(resultAverage, 2);
            Console.WriteLine($"{name} {surname}: Average price is {resultAverage}");
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
