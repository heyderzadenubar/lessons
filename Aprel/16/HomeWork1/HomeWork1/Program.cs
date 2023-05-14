using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             İstifadəçidən adını, soyadını, yaşadığı şəhəri soruşun və bunları dəyişənlərdə saxlayın.
             */
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("User data:");
            Console.WriteLine();
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("City: " + city);
            Console.ReadLine();






        }
    }
}
