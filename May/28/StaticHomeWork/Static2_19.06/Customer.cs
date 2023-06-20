using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Static2_19._06
{
    public class Customer
    {
        private static ArrayList database;

        private  int _id;
        public string name;
        public string surname;
        public string email;
        public string username;
        private string _password;

        public static int GlobalId;

        bool validEmailBool = true, validUsernameBool = true, validPasswordBool = true;
        
        public string Username {
            get
            {
                return this.username;
            }
            set
            {
                if (CheckDuplicateUsername(value))
                {
                    Console.WriteLine("Elave etmek istediyiniz username artiq sistemde movcuddur!");
                    validUsernameBool = false;
                }
                else
                {
                    this.username = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (validPassword(value))
                {
                    this._password = value;
                }
            }
        }

        public bool validPassword(string password)
        {
            int counterUpperLetter = 0;
            int counterNumber = 0;
            if (password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                   if(char.IsUpper(password[i]))
                   {
                        counterUpperLetter++;
                   }
                   if (char.IsNumber(password[i]))
                   {
                        counterNumber++;
                   }
                }
                if(counterNumber>0 && counterUpperLetter > 0)
                {
                    validPasswordBool = true;
                }
                else
                {
                    Console.WriteLine("Sifrede en az 1 boyuk herf ve 1 reqem olmalidir.");
                    validPasswordBool = false;
                }
            }
            else
            {
                Console.WriteLine("Sifre en az 8 simvoldan ibaret olmalidir!");
                validPasswordBool = false;
            }
            return true;
        }

       
        static Customer()
        {
            database = new ArrayList();
        }

        public Customer()
        {
            this._id = Interlocked.Increment(ref GlobalId);
        }

        public bool CheckDuplicateUsername(string usernameCheck)
        {
            for(int i = 0; i < database.Count; i++)
            {
                Customer tempCustomer = (Customer)database[i];
                if (tempCustomer.username==usernameCheck)
                {
                    return true;
                }
            }
            return false ;
        }

        public bool CheckDuplicateEmail(string emailCheck)
        {
            for (int i = 0; i < database.Count; i++)
            {
                Customer customerTemp = (Customer)database[i];
                if (customerTemp.email==emailCheck)
                {
                    Console.WriteLine("Elave etmek istediyiniz email artiq sistemde movcuddur!");
                    validEmailBool = false;
                }
            }
            return false;
        }

        public void AddCustomer(Customer customer)
        {
            if (customer != null && !string.IsNullOrEmpty(customer.email) && !string.IsNullOrEmpty(customer.username))
            {
                if(validEmailBool==true && validPasswordBool==true && validUsernameBool==true)
                {
                    database.Add(customer);
                    Console.WriteLine($"Yeni musteri sisteme elave olundu!");
                }
                
            }
        }
    }
}
