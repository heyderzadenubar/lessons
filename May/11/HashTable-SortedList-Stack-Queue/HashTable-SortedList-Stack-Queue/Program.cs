using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable_SortedList_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task in Lesson 2
            /*
                Hashtable içinə ENG - AZ olaraq data əlavə ediləcək.

                Soruşulacaq:
                Yeni element əlavə etmək istəyirsiniz? H/Y
                H : Yeni element əlavə etsin
                Y : Bütün elementləri göstərsin

                Qeyd: Əgər user mövcud olan Key əlavə edirsə, bu məlumat sistemdə mövcuddur xətası versin.
             */
            #endregion

            Hashtable ht = new Hashtable();
            ht.Add("name", "ad");
            ht.Add("surname", "soyad");
            ht.Add("phone", "telefon");

            beginagain:
            Console.WriteLine("Yeni element əlavə etmək istəyirsiniz? H/Y");
            string ans = Console.ReadLine();
            if(ans.ToUpper() == "H")
            {
                Console.Write("ENG: ");
                string eng = Console.ReadLine();
                Console.Write("AZ: ");
                string az = Console.ReadLine();
                if (ht.Contains(eng))
                {
                    Console.WriteLine("Bu məlumat sistemdə mövcuddur");
                    goto beginagain;
                }
                else
                {
                    ht.Add(eng, az);
                    goto beginagain;
                }
            }
            else if (ans.ToUpper() == "Y")
            {
                foreach (var item in ht.Keys)
                {
                    Console.WriteLine($"ENG: {item},\t  AZ: {ht[item]}");
                }
            }
        }
    }
}
