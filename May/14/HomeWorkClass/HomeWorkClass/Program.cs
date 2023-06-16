
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

        // __________ CalcAverage __________
        BeginAgainPrice1:                                      // Price - 1
            Console.Write("1. Price: ");
            string price1String = Console.ReadLine();              //istifadeci string tipde deyisen daxil edir
            decimal price1Decimal=0;                                     // string tipin convertden sonra eded olub olmadigini yoxlamaq ucun decimal tipinde eded teyin olunur 
            if (Decimal.TryParse(price1String, out price1Decimal))       //string tip decimala convert edilir,decimal tiple muqayise edilir
            {
                goto BeginAgainPrice2;                          // decimal-dirse ikinci reqeme kecid olur
            }
            else
            {
                Console.WriteLine("The value must be a number");   //eks halda
                goto BeginAgainPrice1;                           //birinci reqemin yeniden daxil edilmesi
            }

        BeginAgainPrice2:                                          // Price-2
            Console.Write("2. Price: ");
            string price2String = Console.ReadLine();
            decimal price2Decimal =0;
            if (Decimal.TryParse(price2String, out price2Decimal))
            {
                goto BeginAgainPrice3;
            }
            else 
            {
                Console.WriteLine("The value must be a number");
                goto BeginAgainPrice2;
            }

        BeginAgainPrice3:                                           // Price-3
            Console.Write("3. Price: ");
            string price3String = Console.ReadLine();
            decimal price3Decimal = 0;
            if (Decimal.TryParse(price3String, out price3Decimal) ||  (price3String == ""))
            {
                if (price3String == "")
                {
                    price3Decimal = 0;
                }
                resultAverage = student.CalcAverage(price1Decimal, price2Decimal, price3Decimal);          //AVERAGE
                resultAverage = student.CalcAverage(name, surname, price1Decimal, price2Decimal, price3Decimal);
                Console.WriteLine();

                Console.WriteLine("Rate of average price:");            // RATE OF AVERAGE
                student.RateAverage(resultAverage);
            }
            else if (price3String != "" && !Decimal.TryParse(price3String, out price3Decimal))
            {
                Console.WriteLine("The value must be a number");
                goto BeginAgainPrice3;
            }
           


        }
    }
}
