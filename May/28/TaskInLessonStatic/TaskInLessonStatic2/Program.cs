﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLessonStatic2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir dənə işçi class'ınız olsun və ad, soyad, email, cins və s. kimi property'ləriniz olsun.Ancaq email property'sini set
       
             
             */

            Staff st = new Staff();
            st.ad = "Nubar";
            st.soyad = "Heyderzade";
            st.email = "nubarheyderzade";
            Staff.Info(st.ad, st.soyad,st.email);
            Console.Read();
        }
    }
}