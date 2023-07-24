using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskAwait
{
    public class NonAsync
    {
        public Coffee GetCoffee() 
        {
            Console.WriteLine("Kofe hazirlanir...");
            Task.Delay(8000).Wait();
            Console.WriteLine("Kofe hazirdir");
            return new Coffee(); 
        }
        public Tea GetTea()
        {
            Console.WriteLine("Cay hazirlanir...");
            Task.Delay(4000).Wait();
            Console.WriteLine("Cay hazirdir");
            return new Tea();
        }
        public Stake GetStake()
        {
            Console.WriteLine("Stake hazirlanir...");
            Task.Delay(2000).Wait();
            Console.WriteLine("Stake hazirdir");
            return new Stake();
        }

        public CheeseBurger GetCheeseBurger()
        {
            Console.WriteLine("CheeseBurger hazirlanir...");
            Task.Delay(2000).Wait();
            Console.WriteLine("CheeseBurger hazirdir");
            return new CheeseBurger();
        }
    }
}
