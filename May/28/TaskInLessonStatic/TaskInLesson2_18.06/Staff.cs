using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInLesson2_18._06
{
    public class Staff
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }
        private string _email;

        public string Email {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value.ToLower() + "@gmail.com";
            }
        }



        public  void ShowStaffInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Name: {Surname}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Email: {Email}");

        }

    }
}
