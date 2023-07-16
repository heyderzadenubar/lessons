using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDB.Enums;

namespace CustomerDB
{
    public class VirtualDatabase 
    {
        public static List<Customer> customersList = new List<Customer>()
        {
            new Customer()
            {
                Name="Name1",
                Surname="Surname1",
                Gender=GenderEnum.Female,
                Country="Country1",
                City="City1",
                Address="Address1",
                Phone="Phone1",
                Email="Email1"
            },
            new Customer()
            {
                Name="Name2",
                Surname="Surname2",
                Gender=GenderEnum.Male,
                Country="Country2",
                City="City2",
                Address="Address2",
                Phone="Phone2",
                Email="Email2"
            },
            new Customer()
            {
                Name="Name3",
                Surname="Surname3",
                Gender=GenderEnum.Male,
                Country="Country3",
                City="City3",
                Address="Address3",
                Phone="Phone3",
                Email="Email3"
            },
            new Customer()
            {
                Name="Name4",
                Surname="Surname4",
                Gender=GenderEnum.Female,
                Country="Country4",
                City="City4",
                Address="Address4",
                Phone="Phone4",
                Email="Email4"
            },
            new Customer()
            {
                Name="Name5",
                Surname="Surname5",
                Gender=GenderEnum.Female,
                Country="Country5",
                City="City5",
                Address="Address5",
                Phone="Phone5",
                Email="Email5"
            },
            new Customer()
            {
                Name="Name6",
                Surname="Surname6",
                Gender=GenderEnum.Female,
                Country="Country6",
                City="City6",
                Address="Address6",
                Phone="Phone6",
                Email="Email6"
            }
        };
    }
}
