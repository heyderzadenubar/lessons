using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _aBool = true;
            int _aInt = 1;
            int.TryParse(_aBool.ToString(), out _aInt);

          //_aInt=  Convert.ToInt32(_aBool);
            Console.WriteLine(_aInt);


        }
    }
}
