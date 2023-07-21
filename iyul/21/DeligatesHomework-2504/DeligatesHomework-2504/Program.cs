using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesHomework_2504
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Deligate
            /*
             Homework 1:
             public delegate void RunAnyMethod();

             public static void Add(){
                 Console.WriteLine("Add method");
             }

             public static void Edit(){
                 Console.WriteLine("Edit method");
             }

             public static void Delete(){
                 Console.WriteLine("Delete method");
             }

             Yuxarıda 1 delegate'iniz var və 3 dənə də standart adi method. Elə etməlisiniz ki, məsələn myDelegate adında bir dəyişəniniz olsun və myDelegate dəyişənini
             method kimi istifadə edə biləsiniz. Yəni myDelegate() yazanda bir method işləmiş olsun. Bu qayda da sadəcə 1 dəyişən sayəsində Add, Edit, Delete methodlarını
             işlətməlisiz. Bunu etmək üçün biraz araşdırmalı olacaqsız.*/
            #endregion

            Methods.MyDelegate();

            

        }
    }
}
