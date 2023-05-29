using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Student
    {
        private string _ad;
        private string _soyad;
        private string _email;

        public string Ad
        {
            set
            {
                this._ad = value;
                if(this._soyad != null)
                {
                    this._email = string.Format(_ad.ToLower() + "." + _soyad.ToLower() + "@gmail.com");
                }
            }
            get
            {
                return this._ad;   
            }
        }

        public string Soyad
        {
            set
            {
                this._soyad = value;
                if (this._ad != null)
                {
                    this._email = string.Format(_ad.ToLower() + "." + _soyad.ToLower() + "@gmail.com");
                }
            }
            get
            {
                return this._soyad;                                       
            }
        }

    }
}
