using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesHomework_2504
{
    public class Methods
    {
    public delegate void RunAnyMethod();

        public static void Add()
        {
            Console.WriteLine("Add method");
        }

        public static void Edit()
        {
            Console.WriteLine("Edit method");
        }

        public static void Delete()
        {
            Console.WriteLine("Delete method");
        }

        public static void MyDelegate()
        {
            RunAnyMethod runAnyMethod = new RunAnyMethod(Add);
            runAnyMethod += Edit;
            runAnyMethod += Delete;
            runAnyMethod.Invoke();
        }

    }
}
