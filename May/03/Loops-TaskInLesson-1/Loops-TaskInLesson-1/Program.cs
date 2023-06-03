using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_TaskInLesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------Task in Lesson 1-----------------
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
            }

            //------------Task in Lesson 2-----------------
            for(int i = 0; i < 100; i++)
            {
                for (int j=0; j < 100; j++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                }
            }
        }
    }
}
