using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson_18._06
{
    public class EmailClass
    {
        public static string Name { get; set; }
        public static string Surname { get; set; }

        public static string CheckFullName()
        {
            string nameSurname = Name + " " + Surname;
            if (nameSurname.Length > 20)
            {
                nameSurname = Name[0] + ". " + Surname;
            }
            return nameSurname;
        }
    }
}
