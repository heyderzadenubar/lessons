using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
   abstract class Car
    {
        public string Mark { get; set; }
        public string Speed { get; set; }

        public void Marks()
        {
            Console.WriteLine("Mark: "+ Mark);
        }

        public abstract void StartCar();
    }
}
