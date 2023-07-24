using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskAwait
{
    public class Async
    {
        public async Task<Coffee> GetCoffeeAsync()
        {
            Console.WriteLine("Kofe hazirlanir....");
            await Task.Delay(8000);
            Console.WriteLine("Kofe hazirdir");
            return new Coffee();    
        }

        public async Task<Tea> GetTeaAsync()
        {
            Console.WriteLine("Cay hazirlanir...");
            await Task.Delay(4000);
            Console.WriteLine("Cay hazirdir");
            return new Tea();
        }
        public async Task<Stake> GetStakeAsync()
        {
            Console.WriteLine("Stake hazirlanir...");
            await Task.Delay(2000);
            Console.WriteLine("Stake hazirdir");
            return new Stake();
        }

        public async Task<CheeseBurger> GetCheeseBurgerAsync()
        {
            Console.WriteLine("CheeseBurger hazirlanir...");
            await Task.Delay(2000);
            Console.WriteLine("CheeseBurger hazirdir");
            return new CheeseBurger();
        }
    }
}
