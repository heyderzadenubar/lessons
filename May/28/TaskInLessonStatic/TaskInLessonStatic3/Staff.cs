using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLessonStatic3
{
    class Staff
    {
        public string ad { set; get; }
        public string soyad { set; get; }
        public string email;

        public string Email
        {
            set
            {
               this.email = value +"@gmail.com";
            }
            get
            {
                return this.email;
            }
        }

        public static void Info(string Ad, string Soyad, string EmailStatic)
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Soyad);
            Console.WriteLine( EmailStatic);
        }
    }
}
