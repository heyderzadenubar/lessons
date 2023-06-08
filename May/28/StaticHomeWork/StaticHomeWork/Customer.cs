using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StaticHomeWork
{
    class Customer
    {
        public int _idProperty { get; set; }
        public string _adProperty { get; set; }
        public string _soyadProperty { get; set; }
        public string _emailProperty { get; set; }
        public string _usernameField;
        public string _passwordField;

        public string UsernameProperty
        {
            set
            {
                if (value != "d")
                {
                    _usernameField = value;
                }
                else
                {
                    Console.WriteLine("Elave etmek istediyiniz username artiq sistemde movcuddur!");
                    Console.Write("Yeni username daxil edin: ");
                    value = Console.ReadLine();
                    _usernameField = value;
                }
            }
            get
            {
                return _usernameField;
            }
        }

        public string PasswordProperty
        {
            set
            {
                _passwordField = value;
            }
            get
            {
                return _passwordField;
            }
        }
        
        private static void  ArrayListBaza(int idBaza, string adBaza, string soyadBaza, string emailBaza, string usernameBaza, string passwordBaza)
        {

            ArrayList customersArrayList = new ArrayList();
            customersArrayList.Add(idBaza);
            customersArrayList.Add(adBaza);
            customersArrayList.Add(soyadBaza);
            customersArrayList.Add(emailBaza);
            customersArrayList.Add(usernameBaza);
            customersArrayList.Add(passwordBaza);

            foreach (var item in customersArrayList)
            {
                Console.WriteLine(item+" ");
            }

        }

        public Customer(int id, string ad, string soyad, string email, string username, string password)
        {
            _idProperty=id;
            _adProperty=ad;
             _soyadProperty=soyad;
            _emailProperty= email;
            UsernameProperty=username;
            ArrayListBaza(id,ad,soyad,email,username,password);
        }
    }
}
