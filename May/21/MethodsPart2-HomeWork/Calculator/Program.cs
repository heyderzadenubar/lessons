using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region int int calculator
            int _FirstNumberCheck;
            int _SecondNumberCheck;

        BeginAgainForOperation:
            Console.WriteLine("Select operation: (+;-;*;/)");
            string operation = Console.ReadLine();

            if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != ":")
            {
                Console.WriteLine("The operator was not entered correctly!");
                goto BeginAgainForOperation;
            }
            else
            {
            BeginAgainForFirstNumber:                   // ---------first number-----------
                Console.Write("First number: ");
                string _aInt = Console.ReadLine();
                if (!int.TryParse(_aInt, out _FirstNumberCheck))
                {
                    Console.WriteLine("Number must be entered!");
                    goto BeginAgainForFirstNumber;
                }
                else
                {
                    goto BeginAgainForSecondNumber;
                }
            BeginAgainForSecondNumber:
                Console.WriteLine("Second number: ");// ---------second number-----------
                string _bInt = Console.ReadLine();
                if (!int.TryParse(_bInt, out _SecondNumberCheck))
                {
                    Console.WriteLine("Number must be entered!");
                    goto BeginAgainForSecondNumber;
                }
                if (operation == "/" && int.Parse(_bInt) == 0)
                {
                    Console.WriteLine("Divide zero exception");
                    goto BeginAgainForSecondNumber;
                }
                else
                {
                    Calculate(_aInt,_bInt, operation); //--------calculate-------
                }
                Console.WriteLine("Do you want to calculate again? (Y/N)  ");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "Y")
                {
                    goto BeginAgainForOperation;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            #endregion
            #region decimal decimal calculator
            decimal _aDecimalCkeck;
            decimal _bDecimalCheck;
        BeginAgainForOperation2:
            Console.WriteLine("Select operation: (+;-;*;/)");
            string operation2 = Console.ReadLine();
            if (operation2 != "+" && operation2 != "-" && operation2 != "*" && operation2 != "/" && operation2 != ":")
            {
                Console.WriteLine("The operator was not entered correctly!");
                goto BeginAgainForOperation2;
            }
            else
            {
            BeginAgainForFirstNumber2:
                Console.Write("First number: ");
                string _astring = Console.ReadLine();
                if (!decimal.TryParse(_astring, out _aDecimalCkeck))
                {
                    Console.WriteLine("Number must be entered!");
                    goto BeginAgainForFirstNumber2;
                }
                else
                {
                    goto BeginAgainForSecondNumber2;
                }
            BeginAgainForSecondNumber2:
                Console.WriteLine("Second number: ");
                string _bString = Console.ReadLine();
                if (!decimal.TryParse(_bString, out _bDecimalCheck))
                {
                    Console.WriteLine("Number must be entered!");
                    goto BeginAgainForSecondNumber2;
                }
                if (operation == "/" && decimal.Parse(_bString) == 0)
                {
                    Console.WriteLine("Divide zero exception");
                    goto BeginAgainForSecondNumber2;
                }
                else
                {
                    Calculate(_astring, _bString, operation); //--------calculate decimal-------
                }
                Console.WriteLine("Do you want to calculate again? (Y/N)  ");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "Y")
                {
                    goto BeginAgainForOperation;
                }
                else
                {
                    Environment.Exit(0);
                }
                #endregion

            }
        }
        // ------------OVERLOADING---------
        #region overloading
        public static void Convert(string a, string b)
        {
            decimal aDecimal=decimal.Parse(a);
            decimal bDecimal = decimal.Parse(b);
        }
        public static void Calculate(decimal a, string b,string operation)
        {
            decimal Addition(decimal a1, string a2)
            {
                return a1 + decimal.Parse(a2);
            }
            decimal Subtraction(decimal a1, string a2)
            {
                return a1 - decimal.Parse(a2);
            }
            decimal Multiplication(decimal a1, string a2)
            {
                return a1 * decimal.Parse(a2);
            }
            decimal Division(decimal a1, string a2)
            {
                return a1 / decimal.Parse(a2);
            }

            switch (operation)
            {
                case "+":
                    decimal sum = Addition(a,b);
                    Console.WriteLine(a + "+" + b + "=" + sum);
                    break;
                case "-":
                    decimal Subt = Subtraction(a,b);
                    Console.WriteLine(a + "-" + b + "=" + Subt);
                    break;
                case "*":
                    decimal Mult=Multiplication(a,b);
                    Console.WriteLine(a + "*" + b + "=" + Mult);
                    break;
                case "/":
                    decimal Div = Division(a,b);
                    Console.WriteLine(a + "/" + b + "=" + Div);
                    break;

            }
        }
        public static void Calculate(string a, string b, string operation)
        {
            decimal Addition(decimal a1, decimal a2)
            {
                return a1 + a2;
            }
            decimal Subtraction(decimal a1, decimal a2)
            {
                return a1 - a2;
            }

            decimal Multiplication(decimal a1, decimal a2)
            {
                return a1 * a2;
            }

            decimal Division(decimal a1, decimal a2)
            {
                decimal div = a1 / a2;
                return div;
            }

            switch (operation)
            {
                case "+":
                    decimal sum = Addition(decimal.Parse(a), decimal.Parse(b));
                    Console.WriteLine(a + "+" + b + "=" + sum);
                    break;
                case "-":
                    decimal Subt = Subtraction(decimal.Parse(a), decimal.Parse(b));
                    Console.WriteLine(a + "-" + b + "=" + Subt);
                    break;
                case "*":
                    decimal Mult = Multiplication(decimal.Parse(a), decimal.Parse(b));
                    Console.WriteLine(a + "*" + b + "=" + Mult);
                    break;
                case "/":
                    decimal Div = Division(decimal.Parse(a), decimal.Parse(b));
                    Console.WriteLine(a + "/" + b + "=" + Div);
                    break;

            }
        }

        #endregion

    }
}

