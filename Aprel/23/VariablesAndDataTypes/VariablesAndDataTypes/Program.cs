using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Homework 1:
            /* 5 dənə dəyişəni Implicit Conversion,
               5 dənə dəyişəni Explicit Conversion,
               5 dənə dəyişəni Helper Class Conversion vasitəsilə convert edin. Dəyişən tiplərini və dəyərlərini özünüz seçin.*/
            #endregion

            byte aByte;
            short aShort;
            float aFloat;
            string aString ="10";
            decimal aDecimal;
            int aInt;

            //------------- Implicitly Conversion ----------------
            aByte = 10;
            aShort = aByte;
            aFloat = aByte;
            //aString = aByte;   //------- Cannot implicitly convert type byte to string
            aDecimal = aByte;
            aShort = 10;
            aDecimal = aShort;
            //aFloat = aDecimal; //------- Cannot implicitly convert type 'decimal' to 'float'. An expilicit conversion exists.
            aDecimal = aShort;
            //aShort = aDecimal; //------- Cannot implicitly convert type 'decimal' to 'short'. An expilicit conversion exists.

            //------------- Expilicit Conversion ----------------
            aFloat = (float)aDecimal;
            aDecimal = (decimal)aFloat;
            //aDecimal = (decimal)aString;
            aShort = (short)aByte;
            aByte = (byte)aFloat;

            //------------- Helper Class Conversion---------------
            //aFloat = float.Parse(aDecimal);
            //aDecimal = decimal.Parse(aFloat);
            aInt = Int32.Parse(aString);
            aInt = Convert.ToInt32(aString);
            aFloat = Convert.ToByte(aDecimal);
            //aFloat = float.Parse(aDecimal);
            //aDecimal = decimal.Parse(aFloat);  //cannot convert 'float' to 'string'
            aString = aDecimal.ToString();
            

        }
    }
}
