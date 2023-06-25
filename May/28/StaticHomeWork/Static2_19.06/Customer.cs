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

        public static int globalId;

        bool validEmailBool = true, validUsernameBool = true, validPasswordBool = true;
        
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (CheckDuplicateEmail(value))
                {
                    Console.WriteLine("Elave etmek istediyiniz email artiq sistemde movcuddur!");
                    Console.WriteLine();
                }
                else
                {
                    this.email = value;
                }
            }
        }

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
                    Console.WriteLine();
                    validUsernameBool = false;
                }
                else
                {
                    validUsernameBool = true;
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
                    Console.WriteLine();
                    validPasswordBool = false;
                }
            }
            else
            {
                Console.WriteLine("Sifre en az 8 simvoldan ibaret olmalidir!");
                Console.WriteLine();
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
            //this._id = Interlocked.Increment(ref globalId);
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
                    validEmailBool = false;
                    return true;
                }
                else
                {
                    validEmailBool = true;
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
                    this._id = Interlocked.Increment(ref globalId);
                    database.Add(customer);
                    Console.WriteLine($"Yeni musteri sisteme elave olundu!");
                    Console.WriteLine();
                    ShowCustomer();
                }
                
            }
        }

        public void ShowCustomer()    
        {
            //foreach (var item in database)     // Static2_19.06.Customer qaytarir
            //{
            //    Console.WriteLine(item);
            //}

            for(int i = 0; i < database.Count; i++)
            {
                Customer customerTemp = (Customer)database[i];
                Console.WriteLine($"ID: {customerTemp._id}");
                Console.WriteLine($"Name: {customerTemp.name}");
                Console.WriteLine($"Surname: {customerTemp.surname}");
                Console.WriteLine($"Email: {customerTemp.email}");
                Console.WriteLine($"Username: {customerTemp.username}");
                Console.WriteLine($"Password: {customerTemp._password}");
                Console.WriteLine();
            }
        }
    }
}
