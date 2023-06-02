using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task in lesson 2
            /*
             Task 1: İki dənə int tipində dəyişəniniz olacaq. Birinin dəyəri 1, digərinin dəyəri 0 olacaq.
                     Sonra bu iki int tipindən başqa boolean tipində 2 dəyişəniniz olacaq. Bu iki int
                     tipində olan dəyişəninizi digər iki boolean tipində dəyişənə çevirəcəksiz.
             */

            int _aInt =1;
            int _bInt =0;
            bool _aBool;
            bool _bBool;

            _aBool = Convert.ToBoolean(_aInt);
            _bBool = Convert.ToBoolean(_bInt);
            /*
             Task 2: Bir dənə DateTime tipində dəyişəniniz olsun və indiki zamanı götürün. Sonra o dəyişəni
                     bir başqa object tipindəki dəyişənə mənimsədin. Yəni Boxing. Sonra DateTime tipində
                     3-cü bir dəyişən yaradın və 2-ci yaratdığınız object'in dəyərini 3-cü yaratdığınız 
                     DateTime tipində olan dəyişənə verin.
             */
            DateTime _aDateTime = DateTime.Now;
            object _aObject = _aDateTime;
            DateTime _bDateTime = (DateTime)_aObject;
            /*
            Task 3: İki string tipində dəyişəndə True və False sözlərini saxlayın. Sonra bu string'ləri bool
                    tipində bir dəyişənə çevirin. Convert'dən istifadə etmək olmaz.
            */
            string _aString = "True";
            string _bString = "False";
            bool _aBool2 = bool.Parse(_aString);
            bool bBool2 = bool.Parse(_bString);

            #endregion
        }
    }
}
