using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            #region Task in Lesson 1

            //Console.WriteLine("İndiki tarix: "+ DateTime.Now);   //indiki tarix
            //DateTime _dt = new DateTime(2020,12,20);  //20 dekabr 2020
            ////  _dt.ToString("dd MMMM yyyy");
            //Console.WriteLine(_dt);
            ////3 dənə dəyişən təyin edəcəksiniz. Bunlar double, decimal və float tiplərində olacaq.
            //// dəyərləri də 10.5, 20.5, 30.5 olsun.
            //float _aFloat = 10.5f;
            //double _aDouble = 20.5;
            //decimal _aDecimal = 30.5m;

            //Console.Read();
            #endregion

            #region Task in Lesson 2

            Console.WriteLine("Salam, Xoş gəlmisiniz!");
            Console.Write("Adınızı daxil edin: ");
            string _ad = Console.ReadLine();
            Console.Write("Sizə necə müraciət edilməsini istərdiniz?(bəy/xanım)");
            string _muraciet = Console.ReadLine();
            Console.WriteLine(_ad + " " + _muraciet + ", neçə yaşınız var?");
            int _yash = int.Parse(Console.ReadLine());

            #endregion


        }
    }
}
