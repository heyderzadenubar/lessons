using System;
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
            /*Bir dənə işçi class'ınız olsun və ad, soyad, email, cins və s. kimi property'ləriniz olsun.Ancaq email property'sini set            edən zaman sadəcə @ işarəsinə qədər hissəsini set ediləcək.Yəni məsələn orkhan.farajov            @ işarəsi və domain set olunmayacaq.Ancaq mən o class'dan istifadə edib bir işçi yaradandan sonra email ünvanını set edib            alt sətirdə email'i get edəndə email'də @ işarəsi və domain də olacaq.Bunu edəndə encapsulation'a da uyğun edin.
                   Staff st = new Staff();            st.Name = "Orkhan";            st.Surname = "Farajov";            st.Email = "orkhan.farajov"; //(email domaini set olmuş olacaq)            st.Gender = 1;
             
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
