using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Users:Person
    {
        public int TableNumber { get; set; }
        public string  Address { get; set; }

        private string _username;
        private string _password;

        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                if (VirtualDatabase.IsValidUsername(value))
                {
                    if (VirtualDatabase.IsDublicateUsername(value))
                    {
                        Console.WriteLine("Teyin etdiyiniz istifadeci adi movcuddur");
                    }
                    else
                    {
                        this._username = value;
                    }
                }
                else
                {
                    Console.WriteLine("Istifadeci adi 8 simvoldan az olmamalidir!");
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        
    }
}
