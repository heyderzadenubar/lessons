using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region   Homework 4:
            /*Aşağıdakı dəyərləri düzgün tiplərdə dəyişənlər yaradıb saxlayın:
            1: "Hava gozeldir."
             2: '%'
             3: 9999999999999999
             4: true
             5: false
             6: '0'
             7: 0
             8: 150
             9: -111111111115615
             10: 15.2M
             11: 15.2
             12: 15.2F
             13: new DateTime(2020, 12, 12)
             */
            #endregion
            string aString = "Hava gozeldir.";
            char aChar = '%';
            long aLong = 9999999999999999;
            bool aBool = true;
            bool aBoolFalse = false;
            char bchar = '0';
            byte aByte = 0;
            byte bByte = 150;
            long bLong = -111111111115615;
            decimal aDecimal = 15.2M;
            double aDouble = 15.2;
            float aFloat = 15.2f;
            DateTime aDatetime = new DateTime(2020, 12, 12);
           
        }
    }
}
