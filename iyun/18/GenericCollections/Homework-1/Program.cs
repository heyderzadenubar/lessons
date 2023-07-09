using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homeworks
            /*
             Homework 1:
             Customer class'ının Id, Name, Surname, Age property'ləri olsun. Birdə əlavə olaraq Address Class'ı yaradıb onu da
             inner type olaraq Customer'ə property kimi əlavə edin. Address'in bu property'ləri olacaq: Id, No, Building, Street,
             City, Country. City və Country'ni Address'in içində string olaraq verin əlavə Class'a çıxarmağa ehtiyyac yoxdur.
             2-3 dənə Customer və onların Address'lərini əlavə edib sonra Customer tipində bir listə yığın. Sizdən istədiyim odur
             ki, Foreach ilə (customers.Foreach()) aşağıdakı kimi dataları yazdırasınız:
                ID: 1
                Name: Cavid
                Surname: Cavidov
                Age: 20
                Address Info:
                ID: 100
                No: 10
                Building: Some Building
                Street: Some Street
                City: Some City
                Country: Some Country

                ID: 2
                Name: Hasan
                Surname: Hasanov
                Age: 32
                Address Info:
                ID: 100
                No: 10
                Building: Some Building
                Street: Some Street
                City: Some City
                Country: Some Country
             */
            
            #endregion

            List<Customer> customers = new List<Customer>()
            { 
                new Customer() { Id = 1, Name = "CustomerName", Surname = "CustomerSurname", Age = 30,
                                 Address = { Id = 1, No = 2, City = "Baku", Country = "Azerbaijan", Building = "Building", Street = "Street" }
                               },
                new Customer() { Id = 2, Name = "CustomerName2", Surname = "CustomerSurname2", Age = 32,
                                  Address = { Id = 2, No = 2, City = "Baku", Country = "Azerbaijan", Building = "Building", Street = "Street" }
                               }
            };
            customers.Add(new Customer() { Name = "CustomerName3", Surname = "CustomerSurname3", Age = 33,
                                           Address = { Id = 3, No = 2, City = "Baku", Country = "Azerbaijan", Building = "Building", Street = "Street" } });
            customers.Add(new Customer() { Name = "CustomerName4", Surname = "CustomerSurname4", Age = 34,
                                           Address = { Id = 4, No = 2, City = "Baku", Country = "Azerbaijan", Building = "Building", Street = "Street2" } });

            customers.ForEach(i => Console.WriteLine($"_______Customer-{i.Id}_______\r\nID: {i.Id}\r\nName: {i.Name}\r\nSurname: {i.Surname}\r\nAge: {i.Age}\r\n" +
                                                   $"--Address Info:--\r\nID: {i.Address.Id}\r\nNo: {i.Address.No}\r\nCity: {i.Address.City}\r\nCountry: {i.Address.Country}\r\nBuilding: {i.Address.Building}\r\nStreet: {i.Address.Street}"));
        }
    }
}
