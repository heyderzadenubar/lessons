using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_2
{
   public class Add : BaseClass
    {
        public override void Calculate(decimal a, decimal b)
        {
            Console.WriteLine("___________ Add ____________");
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
    }
}
