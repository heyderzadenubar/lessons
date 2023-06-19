using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
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

            decimal num1Decimal = 15.6M;
            decimal num2Decimal = 15;
            Console.WriteLine($"Number1 (decimal): {num1Decimal}");
            Console.WriteLine($"Number2 (decimal): {num2Decimal}");
            Console.WriteLine("Operator: ");
            string operation = Console.ReadLine();

            int num1Int = 15;
            int num2Int = 55;
            Console.WriteLine($"Number1 (int): {num1Int}");
            Console.WriteLine($"Number2 (int): {num2Int}");
            Console.WriteLine("Operator: ");
            string operation2 = Console.ReadLine();

            string num1String = "15";
            string num2String = "55";
            Console.WriteLine($"Number1 (string): {num1String}");
            Console.WriteLine($"Number2 (string): {num2String}");
            Console.WriteLine("Operator: ");
            string operation3 = Console.ReadLine();

            string num1Str = "15";
            decimal num2Dec = 55.7M;
            Console.WriteLine($"Number1 (string): {num1Str}");
            Console.WriteLine($"Number2 (decimal): {num2Dec}");
            Console.WriteLine("Operator: ");
            string operation4 = Console.ReadLine();

            decimal num1Dec = 15.7M;
            int num2Int2 = 0;
            Console.WriteLine($"Number1 (decimal): {num1Dec}");
            Console.WriteLine($"Number2 (int): {num2Int2}");
            Console.WriteLine("Operator: ");
            string operation5 = Console.ReadLine();

            int num1Int2 = 15;
            string num2String2 = "34";
            Console.WriteLine($"Number1 (int): {num1Int2}");
            Console.WriteLine($"Number2 (string): {num2String2}");
            Console.WriteLine("Operator: ");
            string operation6 = Console.ReadLine();

            #region checkZero

            if (num2Decimal == 0 && operation=="/")
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            else
            {
                Calculate(num1Decimal, num2Decimal, operation);
            }
            if (num2Int == 0 && operation2 == "/")
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            else
            {
                Calculate(num1Int, num2Int, operation2);
            }
            if (num2String == "0" && operation3 == "/")
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            else
            {
                Calculate(num1String, num2String, operation3);
            }
            if (num2Dec == 0 && operation4 == "/")
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            else
            {
                Calculate(num1Str, num2Dec, operation4);
            }
            if(num2Int2 == 0 && operation5 == "/")
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            else
            {
                Calculate(num1Dec, num2Int2, operation5);
            }
            if (num2String2 == "0" && operation6 == "/")
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            else
            {
                Calculate(num1Int2, num2String2, operation6);
            }
            #endregion


        }

        static void Calculate (decimal num1, decimal num2, string operation)
        {
            decimal result;
            switch (operation)
            {
                case "+":
                    {
                        decimal Addition(decimal number1, decimal number2)
                        {
                            return number1+number2;
                        }
                        result = Addition(num1, num2);
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "-":
                    {
                        decimal Subtraction(decimal number1, decimal number2)
                        {
                            return number1 - number2;
                        }
                        result = Subtraction(num1, num2);
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "*":
                    {
                        decimal Multiplication(decimal number1, decimal number2)
                        {
                            return number1 * number2; ;
                        }
                        result = Multiplication(num1, num2);
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "/":
                    {
                        decimal Division(decimal number1, decimal number2)
                        {
                            return number1 / number2;
                        }
                        result = Division(num1, num2);
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");

                        break;
                    }
                default:
                    Console.WriteLine("Wrong operation!");
                    break;
            }
         }

        static void Calculate(int num1, int num2, string operation)
        {
            decimal result;
            switch (operation)
            {
                case "+":
                    {
                        decimal Addition(decimal number1, decimal number2)
                        {
                            return number1 + number2;
                        }
                        result = Addition(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "-":
                    {
                        decimal Subtraction(decimal number1, decimal number2)
                        {
                            return number1 - number2;
                        }
                        result = Subtraction(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "*":
                    {
                        decimal Multiplication(decimal number1, decimal number2)
                        {
                            return number1 * number2; 
                        }
                        result = Multiplication(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "/":
                    {
                        decimal Division(decimal number1, decimal number2)
                        {
                            return number1 / number2;
                        }
                        result = Division(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                default:
                    Console.WriteLine("Wrong operation!");
                    break;
            }
        }

        static void Calculate(string num1, string num2, string operation)
        {
            decimal result;
            switch (operation)
            {
                case "+":
                    {
                        decimal Addition(decimal number1, decimal number2)
                        {
                            return number1 + number2;
                        }
                        result = Addition(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "-":
                    {
                        decimal Subtraction(decimal number1, decimal number2)
                        {
                            return number1 - number2;
                        }
                        result = Subtraction(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "*":
                    {
                        decimal Multiplication(decimal number1, decimal number2)
                        {
                            return number1 * number2;
                        }
                        result = Multiplication(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "/":
                    {
                        decimal Division(decimal number1, decimal number2)
                        {
                            return number1 / number2;
                        }
                        result = Division(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                default:
                    Console.WriteLine("Wrong operation!");
                    break;
            }
        }

        static void Calculate(string num1, decimal num2, string operation)
        {
            decimal result;
            switch (operation)
            {
                case "+":
                    {
                        decimal Addition(decimal number1, decimal number2)
                        {
                            return number1 + number2;
                        }
                        result = Addition(Convert.ToDecimal(num1), num2);
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "-":
                    {
                        decimal Subtraction(decimal number1, decimal number2)
                        {
                            return number1 - number2;
                        }
                        result = Subtraction(Convert.ToDecimal(num1), num2);
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "*":
                    {
                        decimal Multiplication(decimal number1, decimal number2)
                        {
                            return number1 * number2;
                        }
                        result = Multiplication(Convert.ToDecimal(num1), num2);
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "/":
                    {
                        decimal Division(decimal number1, decimal number2)
                        {
                            return number1 / number2;
                        }
                        result = Division(Convert.ToDecimal(num1), num2);
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                default:
                    Console.WriteLine("Wrong operation!");
                    break;
            }
        }

        static void Calculate(decimal num1, int num2, string operation)
        {
            decimal result;
            switch (operation)
            {
                case "+":
                    {
                        decimal Addition(decimal number1, decimal number2)
                        {
                            return number1 + number2;
                        }
                        result = Addition(num1, Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "-":
                    {
                        decimal Subtraction(decimal number1, decimal number2)
                        {
                            return number1 - number2;
                        }
                        result = Subtraction(num1, Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "*":
                    {
                        decimal Multiplication(decimal number1, decimal number2)
                        {
                            return number1 * number2;
                        }
                        result = Multiplication(num1, Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "/":
                    {
                        decimal Division(decimal number1, decimal number2)
                        {
                            return number1 / number2;
                        }
                        result = Division(num1, Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                default:
                    Console.WriteLine("Wrong operation!");
                    break;
            }
        }

        static void Calculate(int num1, string num2, string operation)
        {
            decimal result;
            switch (operation)
            {
                case "+":
                    {
                        decimal Addition(decimal number1, decimal number2)
                        {
                            return number1 + number2;
                        }
                        result = Addition(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "-":
                    {
                        decimal Subtraction(decimal number1, decimal number2)
                        {
                            return number1 - number2;
                        }
                        result = Subtraction(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "*":
                    {
                        decimal Multiplication(decimal number1, decimal number2)
                        {
                            return number1 * number2;
                        }
                        result = Multiplication(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                case "/":
                    {
                        decimal Division(decimal number1, decimal number2)
                        {
                            return number1 / number2;
                        }
                        result = Division(Convert.ToDecimal(num1), Convert.ToDecimal(num2));
                        Console.WriteLine($"{num1} {operation} {num2} = {result}");
                        break;
                    }
                default:
                    Console.WriteLine("Wrong operation!");
                    break;
            }
        }
        

    }
}
