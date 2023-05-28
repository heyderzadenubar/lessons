using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLessonStatic3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad="Nubar";
            string soyad="Heyderzade";
            string email = ad + soyad;

            Staff st = new Staff();
            st.ad = ad;
            st.soyad = soyad;
            st.Email = email;

            Staff.Info(st.ad,st.soyad,st.Email);

            Console.Read();
        }
    }
}
