using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomework_23._06
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }


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
            Console.WriteLine();
            Console.WriteLine($"_______ Customer - {CustomerId} data _______");
            Console.WriteLine($"ID: {CustomerId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Create date: {CreateDate}");
            if (EditDate == null)
            {
                Console.WriteLine($"Edit date: Data is not edited");
            }
            Console.WriteLine($"Edit date: {EditDate}");
        }

        public void ShowContacts()
        {
            Console.WriteLine();
            Console.WriteLine($"_______Customer {CustomerId} contacts____________");
            for(int i = 0; i < 100; i++)
            {
                if(Contacts[i] != null)
                {
                    Console.WriteLine($"_____ Contacts[{i}] ____");
                    Console.WriteLine($"ID: {Contacts[i].Id}");
                    Console.WriteLine($"Email: {Contacts[i].Email}");
                    Console.WriteLine($"Phone number: {Contacts[i].PhoneNumber}");
                    Console.WriteLine($"Create date: {Contacts[i].CreateDate}");
                    if (Contacts[i].EditDate == null)
                    {
                        Console.WriteLine($"Edit date: Data is not edited");
                    }
                    else
                    {
                        Console.WriteLine($"Edit date: {Contacts[i].EditDate}");
                    }
                }
                else
                {
                    break;
                }
            }

        }

        public void ShowAddresses()
        {
            Console.WriteLine();
            Console.WriteLine($"_______Customer {CustomerId} addresses ____________");
            for (int i = 0; i < 100; i++)
            {
                if (Address[i] != null)
                {
                    Console.WriteLine($"ID: {Address[i].Id}");
                    Console.WriteLine($"District: {Address[i].District}");
                    Console.WriteLine($"Building: {Address[i].Building}");
                    Console.WriteLine($"No: {Address[i].No}");
                    Console.WriteLine($"Street: {Address[i].Street}");
                    Console.WriteLine($"Create date: {Address[i].CreateDate}");
                    if (Address[i].EditDate == null)
                    {
                        Console.WriteLine($"Edit date: Data is not edited");
                    }
                    else
                    {
                        Console.WriteLine($"Edit date: {Address[i].EditDate}");
                    }
                }
            }
        }

        public void ShowOrders()
        {
            Console.WriteLine();
            Console.WriteLine($"_______Customer {CustomerId} orders ____________");
            for (int i = 0; i < 100; i++)
            {
                if (Orders[i] != null)
                {
                    Console.WriteLine($"ID: {Orders[i].Id}");
                    Console.WriteLine($"District: {Orders[i].OrderDetails}");
                    Console.WriteLine($"Address: {Orders[i].ShippingAddress.Street}");
                    Console.WriteLine($"Create date: {Orders[i].CreateDate}");
                    if (Orders[i].EditDate == null)
                    {
                        Console.WriteLine($"Edit date: Data is not edited");
                    }
                    else
                    {
                        Console.WriteLine($"Edit date: {Orders[i].EditDate}");
                    }
                }
            }
        }

        public void ShowAllInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"____ Customer - {CustomerId} all info _____");
            ShowCustomer();
            ShowContacts();
            ShowAddresses();
            ShowOrders();
        }

    }
}
