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
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            #region Task in Lesson 2
            //------------Task in Lesson 1-----------------
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
            }

            for(int i = 0; i < 100; i++)
            {
                for (int j=0; j < 100; j++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                }
            }
            #endregion

            Console.Clear();

            #region Task in Lesson 2

            Console.WriteLine("-----Task 1: 1-dən 100-ə qədər olan rəqəmlərin toplamını ekrana yazdırın.-----");
            int cem = 0,i1;
            for (i1 = 1; i1 <= 100; i1++)
            {
                cem += i1;
                Console.WriteLine(cem);
            }
            Console.Clear();

            Console.WriteLine("---Task 2: 1-dən 100-ə qədər sadəcə cüt rəqəmlərin toplamını ekrana yazdırın---");

            int _cemCut = 0, _cut;
            for (_cut = 1; _cut <= 100; _cut++)
            {
                if (_cut % 2 == 0)
                {
                    _cemCut += _cut;
                }
            }
            Console.WriteLine(_cemCut);
            #endregion

            Console.Clear();

            #region Task in Lesson 3 (While) ???
            // User exit yazana kimi text daxil etsin, exit yazanda dongu dayansin

            string ans = "";
            while(ans.ToLower() != "exit")
            {
                ans = Console.ReadLine();
            }
            Console.Write($"User answer: {ans}");

            #endregion
        }
    }
}
