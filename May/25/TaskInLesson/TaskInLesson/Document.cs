using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson
{
    class Document
    {
        private string DocumentSerial;
        private string DocumentNumber;
        decimal d;
        decimal dnumber;

        public string documentSerial
        {
            set
            {
                if (value.Length <= 2)
                {
                    this.DocumentSerial = value;
                }
                else
                {
                    Console.WriteLine("Vesiqenin seriyasinin uzunlugu 2 herf olmalidir!");
                }
                if (decimal.TryParse(value, out d))
                {
                    Console.WriteLine("Vesiqenin seriyasi sadece herflerden ibaret olmalidir!");
                }
            }
            get
            {
                return this.DocumentSerial;
            }
        }

        public string documentNumber
        {
            set
            {
                if (value.Length == 8)
                {
                    this.DocumentNumber = value;
                }
                if (!decimal.TryParse(value, out dnumber))
                {
                    Console.WriteLine("Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!");
                }
                else
                {
                    Console.WriteLine("Vesiqenin nomresinin uzunlugu 8 olmalidir!");
                }
            }
            get
            {
                return DocumentNumber;

            }
        }
    }
}
