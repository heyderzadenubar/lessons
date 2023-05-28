using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    class Program : Customer
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             İnternetdə Access Modifiers mövzusunu araşdırın və elə edin ki, CheckCustomerFromDb methodunu nə public nədə private istifadə etmədən,
             Program class'ında istifadə edə bilim. Inherit almaq şansınız yoxdur, yanlız aşağıdakı kimi yazanda işləməlidir və dəyişikliyi Customer
             class'ı tərəfdə etməlisiniz.

             Nümunə:
             Customer customer = new Customer();
             customer.CheckCustomerFromDb();
             */

            Program customerProgram = new Program();
           bool x= customerProgram.CheckCustomerFromDb();
            Console.WriteLine(x) ;
            Console.Read();
        }
    }
}
