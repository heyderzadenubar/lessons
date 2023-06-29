using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface_2906
{
    public class Multiplication : BaseClass
    {
        public override void Operation(decimal a, decimal b)
        {
            Console.WriteLine("_______ Multiplication _______");
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
    }
}
