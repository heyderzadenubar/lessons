using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            /*Name, Surname, Fullname property'ləri olan Person adlı bir class'ınız olsun. FakeData ilə Person tipində bir listə 1000 nəfər əlavə edin.
             Əlavə edəndə Name və Surname property'lərini set edin amma fullname boş qalsın. Artıq əlinizdə 1000 nəfərin Ad və Soyadı olan bir list hazır olduqdan
             sonra Linq istifadə edərək Ad və Soyad'dan Fullname'i set edin.*/
            
            for (int i = 0; i < 1000; i++)
            {
                Person person = new Person();
                person.Name = FakeData.NameData.GetFirstName();
                person.Surname = FakeData.NameData.GetSurname();
                VirtualDatabase.personList.Add(person);
            }
            VirtualDatabase.personList.ForEach(m => m.Fullname = $"{m.Name} {m.Surname}");
            
            #endregion
        }
        
    }
}
