using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace other
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Senior dev interview task:
            
            var test = new char[] { 'r', 'e', 'd', ' ', 'b', 'l', 'u', 'e', ' ', 'y', 'o', 'u', ' ', 'm', 'e', ' ', 'c', 'a', 'l', 'l' };

            char[] testTemp = new char[test.Length];
            char[] newTest = new char[test.Length];

            int a, j = 0, b = 0, counterLetter = 0;
            
            for (int i = test.Length-1; i >= 0; i--)
            {
                //if(test[i] != ' ')
                //{
                    testTemp[j] = test[i];
                    j++;
                    counterLetter++;
                //}
                //else
                //{
                //    testTemp[j] = test[i];
                //    int j1 = j;
                //    //j++;
                //    counterLetter++;
                //    for( a = b; a < b+counterLetter; a++)
                //    {
                //        newTest[a] = testTemp[j];
                //        j--;
                //    }
                //    b = a;
                //    counterLetter = 0;
                //}
                
            }
            for(int i = 0; i < newTest.Length; i++)
            {
                Console.Write(newTest[i]+" ");
            }
            #endregion
        }
    }
}
