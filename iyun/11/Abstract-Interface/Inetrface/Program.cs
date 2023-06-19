using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inetrface
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Interface Info
            /*
             * İnterfeys yalnız ondan əldə ediləcək classlarin dolduracağı və bizə abstraksiyaya imkan verəcək metod təriflərini ehtiva edən bir quruluşdur.
             * İnterfeysləri təyin edərkən interface açar sözündən istifadə edirik.
             * Müəyyən etdiyimiz strukturun interfeys olduğunu göstərmək üçün adının qarşısına I hərfini qoymaq ən yaxşı təcrübə olardı.
             * interfeysdən miras alan bütün classlar onun daxilindeki butun metodlari implement etməlidir
             * İnterfeys haqqında veb axtarışı etdiyiniz zaman tez-tez özlərindən miras alan classlar üçün müqavilənin olduğu qeyd olunur. 
               Müqavilə sözü ilə məhz bu nəzərdə tutulur. Törəmə classları interfeysdə olan bütün metodları implement edəcəyinə dair söz verir və müqavilə bağlayır. 
               Əks halda kompilyator xəta verəcək və kodunuz işləməyəcək.
             * new açar sözü ilə obyektlər yaradıla BİLMƏZ.
             * Bu, classın necə etməli olduğunu deyil, nə etməli olduğunu göstərir.
             * Default olaraq bütün İnterface üzvləri abstract və public olaraq müəyyən edilir. Bunu xüsusi qeyd etməyə ehtiyac yoxdur.
             * Bir sinif birdən çox interfeysi miras ala bilər, multiple-inheritance dəstəklənir.
             * O, yalnız metodların overloadını ehtiva edir, onlar doldurulmuş metodu ehtiva edə bilməz.  _______ ?????? _____
             * Onlardan miras alacaq classlar arasında "can-do" əlaqəsi var.

            The bumper car can-do speed up.

            Bu, bamper avtomobilin edə biləcəyi qabiliyyəti nümayiş etdirir. can-do əlaqəsi davranışları, qabiliyyətləri ifadə edir. 
            Bu qabiliyyəti interfeysdə müəyyən etmək daha doğru olardı.
             
             */
            #endregion

            #region Difference abstract & interface
            /*
             ABSTRACT CLASS                                                                             INTERFACE CLASS

           Constructor  var                                                                              Constructor  yoxdur  
           Static members var                                                                             Static members yoxdur
   Access modifiers tetbiq edile biler: (public, private, protected)              Access modifiers tetbiq EDİLMİR. Metodları default olaraq public qəbul edilir.
   Classın aid olduğu şəxsiyyəti göstərmək üçün istifadə olunur (is-a)            Classın edə biləcəyi davranışı göstərmək üçün istifadə olunur (can-do) 
   Bir class sadəcə bir abstract classdan miras ala bilər.                          Bir class  bir neçə interface classdan miras ala bilər.

  Bir class eyni tip və ümumi davranışları nümayiş etdirirsə abstract classı        Əgər bir çox class ortaq metodlar istifadə edirsə, interface classdan miras
         base class olaraq istifadə etmək məqsədəuyğundur                                    almaqları daha məqsədəuyğundur

   Miras alan classlar qismən yaxud tamamilə implement edə bilər.                       Miras alan classlar tamamilə implement edir.
    Metod overloadını və ya implementasyonlarını ehtiva edir                               Yalnız metod overloadını ehtiva edir
             */
            #endregion
        }
    }
}
