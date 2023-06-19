using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson_18._06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task in lesson 2
            /*
              Bir method'unuz olsun və ad soyad parametrləri alsın. Method yoxlamalıdır ki,
              ad və soyad'ın uzunluğu 20 xarakterdən uzundursa, adın ilk hərfi, nöqtə, 
              boşluq və soyad return etsin (O. Farafov). Yox əgər 20 simvoldan qısadırsa,
              ad, boşluq, soyad formatında qaytarsın. Nəzərə alın ki, ad ilə soyad arasındakı
              boşluq da 1 simvoldur (nöqtə də). Bir şeyi də nəzərə alın ki, bu method'u
              proyektin 20-30 yerində istifadə edəcəyəm.
             */
            #endregion

            EmailClass.Name = "Nubar";
            EmailClass.Surname = "Heyderzade,dfmgkdjgkdh";
            EmailClass.CheckFullName();
        }
    }
}
