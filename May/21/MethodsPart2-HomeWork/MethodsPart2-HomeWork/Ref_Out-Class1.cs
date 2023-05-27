using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart2_HomeWork
{
    class Ref_Out_Class1
    {
        public static int nextNumberREF(ref int a)
        {
            a = a + 1;
            return a;
        }

        public static void nextNumberVoid(int a)
        {
            a += 1;
        }


        //public static int nextNumberOUT(out int b)
        //{
        //  //  b = b + 1;
        //    return b;
        //}

        public static int nextNumberOUT(out int b)
        {
            b = 0;  // bu olmasa xeta verir
            b += 1;
            return b;
        }
    }
}
