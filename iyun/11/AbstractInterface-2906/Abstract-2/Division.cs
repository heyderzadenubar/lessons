using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_2
{
    public class Division : BaseClass
    {
        public override void Calculate(decimal a, decimal b)
        {
            Console.WriteLine("___________ Division ____________");
            if (b != 0)
            { 
            Console.WriteLine($"{a} / {b} = {a / b}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
    }
}
