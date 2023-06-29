using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface_2906
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass add = new BaseClass();
            add.Operation(5, 6);

            Subtraction subtraction = new Subtraction();
            subtraction.Operation(6, 8);

            Multiplication multiplication = new Multiplication();
            multiplication.Operation(5, 6);
        }
    }
}
