using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLessonStatic2
{
    
    class Staff
    {
        public string ad;
        public string soyad;
        public string email;

        public  string Email
        {
            set
            {
                this.email=email.Substring(0, email.LastIndexOf("@"));
            }
            get
            {
                return this.email;
            }
        }

        public static void Info(string Ad, string Soyad, string Email)
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Soyad);
            Console.WriteLine(Email);
        }
    }
}
