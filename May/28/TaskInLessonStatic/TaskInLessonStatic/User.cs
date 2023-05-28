using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLessonStatic
{
    class User
    {

        public static string AdSoyad (string adStatic, string soyadStatic)
        {
            string adSoyad;
            if ((adStatic + soyadStatic).Length > 20)
            {
                adSoyad = adStatic[0] + ". " + soyadStatic;
                return adSoyad;
                
            }
            return adStatic +" "+ soyadStatic;
            
            
        }
    }
}
