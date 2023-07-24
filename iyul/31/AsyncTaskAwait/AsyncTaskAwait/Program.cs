using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskAwait
{

    public class Coffee { }
    public class Tea { }
    public class Stake { }
    public class CheeseBurger { }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            MakeOrder();
            stopwatch.Stop();
            Console.WriteLine($"Vaxt: {stopwatch.Elapsed}");
            stopwatch.Reset();
            Console.WriteLine("-------------------------");
            stopwatch.Start();
            MakeOrderAsync().Wait();
            stopwatch.Stop();
            Console.WriteLine($"Vaxt: {stopwatch.Elapsed}");
        }
        public static void MakeOrder()
        {
            NonAsync order = new NonAsync();
            order.GetCoffee();
            order.GetTea();
            order.GetStake();
            order.GetCheeseBurger();
        }

        public static async Task MakeOrderAsync()
        {
            Async order = new Async();
            await Task.WhenAll(
                order.GetCoffeeAsync(),
                order.GetTeaAsync(),
                order.GetStakeAsync(),
                order.GetCheeseBurgerAsync());
        }

    }
}
