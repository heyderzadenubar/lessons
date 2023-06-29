using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add add = new Add();
            Subtraction subtraction = new Subtraction();
            Multiplication multiplication = new Multiplication();
            Division division = new Division();

            add.Calculate(23, 34);
            division.Calculate(43, 0);
            subtraction.Calculate(23, 34);
            multiplication.Calculate(43, 10);

        }
    }
}
