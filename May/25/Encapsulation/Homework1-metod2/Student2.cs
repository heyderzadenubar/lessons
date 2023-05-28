using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_metod2
{
    class Student2
    {
        private string ad;
        private string soyad;
        private string email;



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

        public string Email
        {
            set
            {
                if (this.ad != null && this.soyad != null)
                {
                    this.email = this.ad + "."+this.soyad+"@gmail.com";
                }
            }
            get
            {
                return this.email;
            }
        }
    }
}
