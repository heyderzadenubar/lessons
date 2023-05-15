
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları  alınıb hamısı bir method'a ötürüləcək.
             Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. CalcAverage,RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
             Bunun üçün Method Overloading mövzusu araşdırılmalıdır. CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə, tələbənin ortalamasının 45-dən
             yuxarı/aşağı olub-olmamasını check edəcək. Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq. 
             */
            decimal resultAverage;
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine();

            Student student = new Student();
        // CalcAverage
        BeginAgainNumber1:                                      // NUMBER1
            Console.Write("Number1: ");
            string num1String = Console.ReadLine();              //istifadeci string tipde deyisen daxil edir
            decimal num1Decimal;                                     // string tipin convertden sonra eded olub olmadigini yoxlamaq ucun decimal tipinde eded teyin olunur 
            if (Decimal.TryParse(num1String, out num1Decimal))       //string tip decimala convert edilir,decimal tiple muqayise edilir
            {
                goto BeginAgainNumber2;                          // decimal-dirse ikinci reqeme kechid olur
            }
            else
            {
                Console.WriteLine("The value must be a number");   //eks halda
                goto BeginAgainNumber1;                           //birinci reqemin yeniden daxil edilmesi
            }

        BeginAgainNumber2:                                          // NUMBER2
            Console.Write("Number2: ");
            string num2String = Console.ReadLine();
            decimal num2Decimal;
            if (Decimal.TryParse(num2String, out num2Decimal))
            {
                goto BeginAgainNumber3;
            }
            else
            {
                Console.WriteLine("The value must be a number");
                goto BeginAgainNumber2;
            }

        BeginAgainNumber3:                                           // NUMBER 3
            Console.Write("Number3: ");
            string num3String = Console.ReadLine();
            decimal num3Decimal;
            if (Decimal.TryParse(num3String, out num3Decimal))
            {
                resultAverage = student.CalcAverage(num1Decimal, num2Decimal, num3Decimal);          //AVERAGE
                resultAverage = student.CalcAverage(resultAverage);
                Console.WriteLine("Average of numbers: (" + num1Decimal + " + " + num2Decimal + " + " + num3Decimal + ")/3" + " = " + resultAverage);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The value must be a number");
                goto BeginAgainNumber3;
            }
            
            Console.WriteLine("Rate of average price:");            // RATE OF AVERAGE
            student.RateAverage(resultAverage);


        }
    }
}
