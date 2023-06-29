using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface_2906
{
    public class BaseClass
    {
        public virtual void Operation(decimal a, decimal b)
        {
            Console.WriteLine("_______ Add _______");
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        
    }

}
