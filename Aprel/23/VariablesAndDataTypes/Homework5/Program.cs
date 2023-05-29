using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region  Homework 5
            // Global və Local dəyişən fərqlərini skoplarla izah edə biləcəyiniz bir kod nümunəsi hazırlayın.
            #endregion

            int aGloal=5;

            int Addition(int a, int b)
            {
                int aLocal=a;
                aGloal = b;
                return a + b;
            }
            
            Console.WriteLine(Addition(5,10));
            Console.Read();

        }

    }
}
