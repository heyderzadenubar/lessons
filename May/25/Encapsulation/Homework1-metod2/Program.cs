using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_metod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student2 student = new Student2();
            student.Soyad = "Heyderzade";
            student.Ad = "Nubar";
           
            Console.WriteLine(student.Email);
            Console.Read();
        }
    }
}
