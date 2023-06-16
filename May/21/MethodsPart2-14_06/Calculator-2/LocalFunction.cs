using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class LocalFunction
    {
        public static void Calculator(decimal a, decimal b, string oper)
        {
            decimal result;
            decimal Addition(decimal num1, decimal num2)
            {
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
                return result;
            }
            decimal Subtraction(decimal num1, decimal num2)
            {
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
                return result;
            }
            decimal Multiplication(decimal num1, decimal num2)
            {
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
                return result;
            }
            decimal Divide(decimal num1, decimal num2)
            {
                result = num1 / num2;
                Console.WriteLine($"{num1} : {num2} = {result}");
                return result;
            }
            switch (oper)
            {
                case "+":
                    Addition(a, b);
                    break;
                case "-":
                    Subtraction(a, b);
                    break;
                case "*":
                    Multiplication(a, b);
                    break;
                case "/":
                    if (b != 0)
                    {
                        Divide(a, b);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }
        }

        public static void Calculator(int a, int b, string oper)
        {
            decimal toDecimala = (decimal)a;
            decimal toDecimalb = (decimal)b;
            Calculator(toDecimala, toDecimalb, oper);
        }
        public static void Calculator(string a, string b, string oper)
        {
            decimal toDecimala = Convert.ToDecimal(a);
            decimal toDecimalb = Convert.ToDecimal(b);
            Calculator(toDecimala, toDecimalb, oper);
        }
        public static void Calculator(string a, decimal b, string oper)
        {
            decimal toDecimala = Convert.ToDecimal(a);
            Calculator(toDecimala, b, oper);
        }
        public static void Calculator(decimal a, int b, string oper)
        {
            decimal toDecimalb = Convert.ToDecimal(b);
            Calculator(a, toDecimalb, oper);
        }
        public static void Calculator(int a, string b, string oper)
        {
            decimal toDecimala = Convert.ToDecimal(a);
            decimal toDecimalb = Convert.ToDecimal(b);
            Calculator(toDecimala, toDecimalb, oper);
        }
    }
}
