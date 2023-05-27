using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    /*
              Homework 3:
                Local function'lar yaradaraq bir kalkulyator yaradın.
                Ümumi bir calculate methodu olmalıdır və o method'un içində də Toplama, Çıxma, Vurma və Bölmə local function'ları olacaq.
                Ümumi Calculate method'unun overload'ları olmalıdır və iki decimal, iki int, iki string, string-decimal, decimal-int və
                int-string parametrləri ilə işləməlidir.
                Nümunə: İki int, iki decimal dedikdə onu nəzərdə tuturam ki, Calculate(15, 15), Calculate(15.2M, 20.5M) qaydada istifadə ediləcək.
                Ancaq string-decimal dedikdə yəni parametrin biri string digəri decimal olacaq("15", 20.2M) yada int-string üçün(20, "15") belə.
                Bölmə zamanı divide zero exeption'dan qaçının.
                Birdə Calculator'un 2 variant faiz hesablama funksiyası da olacaq. Birinci variant A parametrinin B parametr faizi neçədir?
                Yəni 100 - ün 5 faizi neçədir? hesablayacaq.İkinci variant isə A parametri B parametrinin neçə faizidir? Yəni 10(a parametri),
                100 - ün(b parametrinin) neçə faizidir?*/
    class Program
    {
        static void Main(string[] args)
        {
            string _dataType1;
            string _dataType2;
            string operationINT;

        BeginAgainForCalculate:
            Console.WriteLine("Enter data types (int,decimal,string): ");
            _dataType1 = Console.ReadLine();
            Console.Write("Data type2: ");
            _dataType2 = Console.ReadLine();
            #region int int calculator
            if (_dataType1.ToUpper() == "INT" && _dataType2.ToUpper() == "INT")  //------int int-------
            {
            BeginAgainForOperation:
                Console.WriteLine("Select operation: (+;-;*;/)");          //------Select operation---------
                operationINT = Console.ReadLine();
                if (operationINT != "+" && operationINT != "-" && operationINT != "*" && operationINT != "/" && operationINT != ":")
                {
                    Console.WriteLine("The operator was not entered correctly!");
                    goto BeginAgainForOperation;
                }
                else
                {
                BeginAgainForFirstNumber:
                    int _FirstNumberCheck;              //------_FirstNumberCheck---------
                    int _SecondNumberCheck;             //------_SecondNumberCheck---------

                    Console.Write("First number: ");
                    string _aString = Console.ReadLine();                //------enter _aString---------        
                    if (!int.TryParse(_aString, out _FirstNumberCheck))
                    {
                        Console.WriteLine("Number must be entered!");
                        goto BeginAgainForFirstNumber;
                    }
                    else
                    {
                        goto BeginAgainForSecondNumber;
                    }
                BeginAgainForSecondNumber:
                    Console.WriteLine("Second number: ");
                    string _bString = Console.ReadLine();               //------enter _bString---------

                    if (!int.TryParse(_bString, out _SecondNumberCheck))
                    {
                        Console.WriteLine("Number must be entered!");
                        goto BeginAgainForSecondNumber;
                    }
                    if (operationINT == "/" && int.Parse(_bString) == 0)
                    {
                        Console.WriteLine("Divide zero exception");
                        goto BeginAgainForSecondNumber;
                    }
                    else
                    {
                        Calculate(_FirstNumberCheck, _SecondNumberCheck, operationINT); //--------calculate-------
                        Percentage(_FirstNumberCheck, _SecondNumberCheck);
                    }
                    Console.WriteLine("Do you want to calculate again? (Y/N)  ");
                    string answer = Console.ReadLine();
                    if (answer.ToUpper() == "Y")
                    {
                        goto BeginAgainForCalculate;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
            #endregion

            #region decimal decimal calculator

            else if (_dataType1.ToUpper() == "DECIMAL" && _dataType2.ToUpper() == "DECIMAL") //------decimal decimal-------
            {
            BeginAgainForOperation2:
                Console.WriteLine("Select operation: (+;-;*;/)");  //------Select operation---------
                string operation2 = Console.ReadLine();
                if (operation2 != "+" && operation2 != "-" && operation2 != "*" && operation2 != "/" && operation2 != ":")
                {
                    Console.WriteLine("The operator was not entered correctly!");
                    goto BeginAgainForOperation2;
                }
                else
                {
                    decimal _FirstNumberCheckDecimal;        //------_FirstNumberCheckDecimal---------
                    decimal _SecondNumberCheckDecimal;      //------_SecondNumberCheckDecimal---------

                BeginAgainForFirstNumber2:
                    Console.Write("First number: ");
                    string _aDecimal = Console.ReadLine();   //------enter aDecimal---------

                    if (!decimal.TryParse(_aDecimal, out _FirstNumberCheckDecimal))
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
                    string _bDecimal = Console.ReadLine();       //------enter bDecimal---------
                    if (!decimal.TryParse(_bDecimal, out _SecondNumberCheckDecimal))
                    {
                        Console.WriteLine("Number must be entered!");
                        goto BeginAgainForSecondNumber2;
                    }
                    if (operation2 == "/" && decimal.Parse(_bDecimal) == 0)
                    {
                        Console.WriteLine("Divide zero exception");
                        goto BeginAgainForSecondNumber2;
                    }
                    else
                    {
                        Calculate(_FirstNumberCheckDecimal,_SecondNumberCheckDecimal, operation2); //--------calculate decimal-------
                        Percentage(_FirstNumberCheckDecimal, _SecondNumberCheckDecimal);
                    }
                    Console.WriteLine("Do you want to calculate again? (Y/N)  ");
                    string answer = Console.ReadLine();
                    if (answer.ToUpper() == "Y")
                    {
                        goto BeginAgainForCalculate;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                #endregion
            }
        }
        // ------------OVERLOADING---------
        #region overloading
        public static void Calculate(int a, int b, string operation)
        {
            switch (operation)
            {
                case "+":
                    int sum = a + b;
                    Console.WriteLine(a + "+" + b + "=" + sum);
                    break;
                case "-":
                    int Subtraction = a - b;
                    Console.WriteLine(a + "-" + b + "=" + Subtraction);
                    break;
                case "*":
                    int Multiplication = a * b;
                    Console.WriteLine(a + "*" + b + "=" + Multiplication);
                    break;
                case "/":
                    int Division = a / b;
                    Console.WriteLine(a + "/" + b + "=" + Division);
                    break;

            }
        }
        public static void Calculate(decimal a, decimal b, string operation)
        {
            if (operation == "+")
            {
                    decimal sum = a + b;
                    Console.WriteLine(a + "+" + b + "=" + sum);
            }
            else if (operation == "-")
            {
                decimal subt = a - b;
                Console.WriteLine(a + "-" + b + "=" + subt);
            }
            else if (operation == "*")
            {
                decimal mult = a * b;
                Console.WriteLine(a + "*" + b + "=" + mult);
            }
            else if (operation == "/")
            {
                decimal div = a / b;
                Console.WriteLine(a + "/" + b + "=" + div);
            }
        }
        public static void Percentage(int a, int b)
        {
            decimal ab = (a * 100) / b;
            Console.WriteLine(a+ " is "+ ab+ "% of "+ b);
            decimal ba = (b* 100) / a ;
            Console.WriteLine(b + " is " + ba + "% of " + a); 
        }
        public static void Percentage(decimal a, decimal b)
        {
            decimal ab = (a * 100) / b;
            Console.WriteLine(a + " is " + ab + "% of " + b);
            decimal ba = (b * 100) / a;
            Console.WriteLine(b + " is " + ba + "% of " + a);
        }
        #endregion
    }
}

