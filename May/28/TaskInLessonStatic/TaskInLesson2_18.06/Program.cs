using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson2_18._06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task in Lesson
            /* Bir dənə işçi class'ınız olsun və ad, soyad, email, cins və s. kimi property'ləriniz olsun. Ancaq email property'sini set
            edən zaman sadəcə @ işarəsinə qədər hissəsini set ediləcək. Yəni məsələn orkhan.farajov
            @ işarəsi və domain set olunmayacaq. Ancaq mən o class'dan istifadə edib bir işçi yaradandan sonra email ünvanını set edib
            alt sətirdə email'i get edəndə email'də @ işarəsi və domain də olacaq. Bunu edəndə encapsulation'a da uyğun edin. */
            #endregion

            Staff staff = new Staff();
            staff.Name = "Nubar";
            staff.Surname = "Heyderzade";
            staff.Gender = 1;
            staff.Email = "nubar.heyderzade";

            staff.ShowStaffInfo();
        }
    }
}
