using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 4: İstifadəçidən qeyd etdiyim tiplərdə dəyər alıb onları uyğun tipdə dəyişənlərə 
             * çevirəcəksiz. bool, string, short, long, int, char, datetime. */

            bool _aBool = true;
            string _aBoolToString = _aBool.ToString();
            int _aBoolToInt = Convert.ToInt32(_aBool);

            string _aString = "A";
            string _aStringNum = "1";
            //int _aStringToInt = Convert.ToInt32(_aString);  // error
            int _aStringNumToInt = Convert.ToInt32(_aStringNum);
            //char _aStringToChar = (char)_aString;      //error
            char _aStringToChar = Convert.ToChar(_aString);

            short _aShort = 305;
            byte _aByteShort = (byte)_aShort;  //49
            //byte _aByteParse = byte.Parse(_aShort);    error
            double _aDouble = _aShort;
            string _aStringShort = _aShort.ToString();

            long _aLong = 10;
            // short _aShortLong = _aLong;   //error
            double _aDoubleLong = _aLong;
            //int _aIntLong = _aLong;   //error
            int _aIntLong = (int)_aLong;

            int _aInt = 10;
            double _aDoubleInt = _aInt;

            char _aChar = '5';
            int _aCharInt = _aChar;  //53

            DateTime _aDateTime = DateTime.Now ;
            string _adateTimeString = _aDateTime.ToString("MM/dd/yyyy h:mm tt");



        }
    }
}
