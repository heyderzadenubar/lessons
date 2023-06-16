using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOP_Inheritance_Part3_homework1
{
    public class Database
    {
        /*Bir class daha yaranmalıdır. Hansı ki, içində bir arrayList olacaq və ona kənardan heç bir müdaxilə edilə bilməsin.
              Bu arrayList database kimi istifadə ediləcək. Eyni zamanda class'ın içində NewItem, NewItems, UpdateItem, DeleteItem methodları olacaq.
              Bu methodların heç birinin parametrinin tipi Tv, Laptop, object, dynamic və ya .NET'in hər hansısa tipində ola BİLMƏZ! Bunu biraz düşünmək lazım olacaq :)

              -NewItem methodu bir parametr almalıdır. NewItem array'a tək məhsul əlavə edəcək.
              -NewItems methodu təyin olunan zaman 1 parametr yazılacaq ancaq istifadə edilən yerdə istədiyim qədər Tv və ya Laptop tipində fərqli
               dəyişənlər ötürə biləcəm. Məsələn NewItems(Laptop, Tv, Tv, Tv, Laptop, Laptop...).
              -UpdateItem methodu isə hər hansısa məhsulun dəyərlərini update edəcək.
              -DeleteItem məhsulu silməyəcək sadəcə IsDeleted true olacaq.
              */
      private ArrayList _db = new ArrayList();

        public  TV tv;
       public  Laptop laptop;

        public Database()
        {
            tv = new TV();
            laptop = new Laptop();
        }
        
        public void NewItem(string category)
        {
            if (category.ToUpper()=="TV")
            {
                _db.Add(tv);
                tv.id++;
            }
            else if (category.ToUpper() == "LAPTOP")
            {
                _db.Add(laptop);
                laptop.id++;
            }
        }

        public void NewItemsLaptop(params string[] laptops)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                    _db.Add(laptop.id);
                    _db.Add(laptop.Barcode);
                    _db.Add(laptop.Model);
                    _db.Add(laptop.Ram);
                    laptop.id++;
            }
        }
        public void NewItemsTV(params string[] tvs)
        {
            for (int i = 0; i < tvs.Length; i++)
            {
                _db.Add(tv.id);
                _db.Add(tv.Barcode);
                _db.Add(tv.Model);
                _db.Add(tv.IsSmartTv);
                tv.id++;
            }
        }

        public void ShowItem()
        {
            foreach (var item in _db)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_________________________________");
        }

    }
}
