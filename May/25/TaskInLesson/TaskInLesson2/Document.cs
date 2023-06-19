using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson2
{
   public class Document
   {
        private string _documentSerial;
        private string _documentNumber;
        public bool isLetter;
        public bool isNumber;

        public string DocumentSerial {
            get
            {
                return _documentSerial ;
            }
            set
            {
                if (value.Length == 2)
                {
                    for(int i = 0; i < value.Length; i++)
                    {
                        if (char.IsLetter(value[i]))
                          isLetter = true;
                        else
                        {
                            Console.WriteLine("Vesiqenin seriyasi sadece herflerden ibaret olmalidir!");
                           isLetter = false;
                            break;
                        }
                    }
                    if (isLetter == true)
                    {
                        _documentSerial = value;
                    }
                }
                else
                {
                    Console.WriteLine("Vesiqenin seriyasinin uzunlugu 2 herf olmalidir!");
                }
            }
        }
        public string DocumentNumber {
            get
            {
                int index = 2;
               string visibleNumbers= _documentNumber.Substring(0, index);
                string hiddenNumbers = "";

                for (int i = 0; i < _documentNumber.Length - index; i++)
                {
                    hiddenNumbers += "*";
                }

                _documentNumber=visibleNumbers + hiddenNumbers;
                return _documentNumber;
                    
            }
            set
            {
                if (value.Length == 8)
                {
                    for(int i = 0; i < value.Length; i++)
                    {
                        if (char.IsNumber(value[i]))
                            isNumber = true;
                        else
                        {
                            Console.WriteLine("Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!");
                            isNumber = false;
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Vesiqenin nomresinin uzunlugu 8 olmalidir!");  
                }
                if (isNumber == true)
                {
                    _documentNumber = value;
                }
            }
        }
    }
}
