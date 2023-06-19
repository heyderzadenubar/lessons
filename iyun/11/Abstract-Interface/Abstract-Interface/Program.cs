using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Homework 1:
            /*
                Bu gün ev tapşırığınız abstract, interface, virtual method'ları araşdırmaqdır.
                Araşdırandan sonra da, gələn dərsə qədər bir nümunə hazırlamağa çalışın. Bu bir kiçik kitabxana app'ı,
                calculator və ya hər hansısa kiçik bir task ola bilər. Generic collection'ları falan keçəndən sonra
                kiçik app'lar yazanda bunları praktika edəndə daha rahat başa düşəcəksiz çünkü hal-hazırda bunları
                real tədbiq etməyə çalışsaz hələ bilmədiyiniz nə qədər mövzu əksiyi var.
             */
            #endregion

            #region Absrtract class
            /*
             1.  Abstract class yaratmaq üçün "abstract" keywordundən istifadə edilir.
             2.  Abstract classlar ən azı bir abstract metod yazılmasını tələb edir.
             3.  Biz miras alarkən (inheritance) ümumiyyətlə abstract classlardan istifadə edirik.
             4.  NEW keywordu ilə abstract obyektlər YARADILA BİLMƏZ.
             5.  O, dəyişənləri və metodları ehtiva edə bilər.
             6.  Abstract classlardan əldə edilən classlar abstract metodları TƏTBİQ ETMƏLİDİR. O, digər metodları override etmədən də istifadə edə bilər.
             7.  Onların tərkibində Constructors  (konstruktor metodları) və destructors  (dağıdıcı üsullar) ola bilər.
             8.  Statik müəyyən edilə BİLMƏZ. (Əgər onu müəyyən etməyə çalışarsanız, kompilyator "an abstract class cannot be sealed or static" xətası verir)
             9.  bir class yalnız miras yolu ilə abstract class-ı implement edə bilər. Çoxsaylı inheritance DƏSTƏKLƏNMİR.
             10. O, həmçinin abstract olmayan metodları ehtiva edə bilər.
             11. Onlardan miras alacaq classlarla "is-a" əlaqəsi var. (Bu, əvvəlcə çox vacib sayılmayan bir detaldır,
                 lakin hansı ssenaridə Abstract və İnterfeysdən hansı ssenaridə istifadə edəcəyimizi aydınlaşdırmaqda bizə çox kömək edir, 
                 izahatını aşağıda tapa bilərsiniz)

                'is-a' relationship. Bu halda bir class digər classin alt növüdür. Başqa sözlə, bir class digər classin imkanlarını genişləndirir.
                Bu tip, inheritance mexanizminin istifadəsinə əsaslanır.

            class BumperCar : Car   (BumperCar is a Car)
             */

            BumperCar bumperCar = new BumperCar();
            bumperCar.Mark = "T";
            bumperCar.Marks();
            bumperCar.StartCar();
            #endregion
        }
    }
}
