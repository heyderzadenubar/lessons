using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class LocalFunction
    {
        #region Homework 3
        /*Local function'lar yaradaraq bir kalkulyator yaradın.
            Ümumi bir calculate methodu olmalıdır və o method'un içində də Toplama, Çıxma, Vurma və Bölmə local function'ları olacaq.
            Ümumi Calculate method'unun overload'ları olmalıdır və iki decimal, iki int, iki string, string-decimal, decimal-int və 
            int-string parametrləri ilə işləməlidir.
            Nümunə: İki int, iki decimal dedikdə onu nəzərdə tuturam ki, Calculate(15, 15), Calculate(15.2M, 20.5M) qaydada istifadə ediləcək.
            Ancaq string-decimal dedikdə yəni parametrin biri string digəri decimal olacaq ("15", 20.2M) yada int-string üçün (20, "15") belə.
            Bölmə zamanı divide zero exeption'dan qaçının.
            Birdə Calculator'un 2 variant faiz hesablama funksiyası da olacaq. Birinci variant A parametrinin B parametr faizi neçədir?
            Yəni 100-ün 5 faizi neçədir? hesablayacaq. İkinci variant isə A parametri B parametrinin neçə faizidir? Yəni 10 (a parametri),
            100-ün (b parametrinin) neçə faizidir?*/
        #endregion
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
            decimal Percent(decimal num1perc, decimal num2perc)
            {
                decimal resultPercent;
                resultPercent = (num1perc * num2perc) / 100;
                Console.WriteLine($"{num2perc}% of {num1perc} = {resultPercent}");
                return resultPercent;
            }
            decimal RatePercent(decimal num1perc, decimal num2perc)
            {
                decimal resultPercent;
                resultPercent = (num1perc / num2perc) * 100;
                Console.WriteLine($"{num1perc} is {resultPercent}% of {num2perc}");
                return resultPercent;
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
                case "%":
                    Percent(a, b);
                    break;
                case "%%":
                    RatePercent(a, b);
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
