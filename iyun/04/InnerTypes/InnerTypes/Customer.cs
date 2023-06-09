using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypes
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreateDateCustomer { get; set; }
        public DateTime? EditDateCustomer { get; set; }

        
        public Contacts[] Contacts;
        public Order[] Orders;
        public Address[] Address;

        public Customer()
        {
            Contacts = new Contacts[100];
            Orders = new Order[100];
            Address = new Address[100];
        }

        public void ShowCustomer()
        {
            Console.WriteLine("Customer id: " + CustomerId);
            Console.WriteLine("Customer name: " + Name);
            Console.WriteLine("Customer surname: " + Surname);
            Console.WriteLine("Customer data creation date: " + CreateDateCustomer);
            if (EditDateCustomer == null)
            {
                Console.WriteLine("Customer data edit date: Customer data has not been edited");
            }
            else
            {
                Console.WriteLine("Customer data edit date: " + EditDateCustomer);
            }
        }
        
        public void ShowContacts()
        {
            for (int i = 0; i < Contacts.Length; i++)
            {
                if (Contacts[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Id: " + Contacts[i].Id);
                    Console.WriteLine("Phone number: " + Contacts[i].PhoneNumber);
                    Console.WriteLine("Email: " + Contacts[i].Email);
                    Console.WriteLine("Create date: " + Contacts[i].CreateDate);
                    if (Contacts[i].EditDate == null)
                    {
                        Console.WriteLine("Customer data edit date: Customer data has not been edited");
                    }
                    else
                    {
                        Console.WriteLine("Customer data edit date: " + Contacts[i].EditDate);
                    }
                    Console.WriteLine();
                }
               
            }
        }

        public void ShowAddress()
        {
            for (int i = 0; i < Address.Length; i++)
            {
                if (Address[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Id: " + Address[i].Id);
                    Console.WriteLine("No: " + Address[i].No);
                    Console.WriteLine("Building: " + Address[i].Building);
                    Console.WriteLine("Street: " + Address[i].Street);
                    Console.WriteLine("District: " + Address[i].District);
                    Console.WriteLine("Create date: " + Address[i].CreateDate);
                    if (Address[i].EditDate == null)
                    {
                        Console.WriteLine("Customer data edit date: Customer data has not been edited");
                    }
                    else
                    {
                        Console.WriteLine("Customer data edit date: " + Address[i].EditDate);
                    }

                    Console.WriteLine();
                }

            }
        }

        public void ShowOrders()
        {
            for (int i = 0; i < Orders.Length; i++)
            {
                if (Orders[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Id: " + Orders[i].Id);
                    Console.WriteLine("OrderDetails: " + Orders[i].OrderDetails);
                    Console.WriteLine("ShippingAddress: " + Orders[i].ShippingAddress.Street);
                    Console.WriteLine("Street: " + Orders[i].CreateDate);
                    if (Orders[i].EditDate == null)
                    {
                        Console.WriteLine("Customer data edit date: Customer data has not been edited");
                    }
                    else
                    {
                        Console.WriteLine("Customer data edit date: " + Orders[i].EditDate);
                    }

                    Console.WriteLine();
                }

            }
        }

        public void ShowAllInfo()
        {
            Console.WriteLine("_____________________ Customer data __________________");
            ShowCustomer();
            Console.WriteLine("__________________ Customer contact data ______________");
            ShowContacts();
            Console.WriteLine("__________________ Customer address data ______________");
            ShowAddress();
            Console.WriteLine("__________________ Customer orders data ______________");
            ShowOrders();

        }
    }
}
