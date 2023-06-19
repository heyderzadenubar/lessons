using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
     class BumperCar:Car
     {
        public override void StartCar()
        {
            Console.WriteLine("Car start");
        }
     }
}
