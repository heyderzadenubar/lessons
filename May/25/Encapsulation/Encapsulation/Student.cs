using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Student
    {
        private string ad;
        private string soyad;
        private string email;

        public string Ad
        {
            set
            {
                this.ad = value;
            }
            get
            {
                return this.ad;   
            }
        }

        public string Soyad
        {
            set
            {
                this.soyad = value;
            }
            get
            {
                return this.soyad;                                       
            }
        }

       public void Email(string adEmail,string soyadEmail)
        {
            adEmail = ad;
            soyadEmail = soyad;
            email = adEmail + "." + soyadEmail + "@gmail.com";
            Console.WriteLine(email);
        }

    }
}
