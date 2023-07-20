using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Aprel21
{
    public class ValueIsSmallerThanZero : Exception
    {
         public ValueIsSmallerThanZero (string message) : base(message) { }
    }

    public class ValueClass
    {
        public void ShowValue(int a)
        {
            if (a < 0)
            {
                throw (new ValueIsSmallerThanZero("Eded sifirdan kicikdir!"));
            }
            else
            {
                Console.WriteLine($"Deyer: {a}");
            }
        }
    }
}
