using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 4: İstifadəçidən bir rəqəm alın. While döngüsüylə istifadəçinin daxil etdiyi rəqəmdən 
                          0-a doğru geriyə sayın.  */

            int aUser = Convert.ToInt32(Console.ReadLine());
            bool NotZeroBool = true;

            while (NotZeroBool)
            {
                if (aUser != 0)
                {
                    aUser--;
                    Console.WriteLine(aUser);
                }
                else
                {
                    NotZeroBool = false;
                }
            }
        }
    }
}
