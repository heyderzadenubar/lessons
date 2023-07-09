using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework-2
            /*
             Homework 2:
             Generic class yaradaraq (Repository) Add, Update, Get, Delete method'larını yazın. Həmin repository'nin instance'ını
             Student, Customer, Teacher və Book class'ları ilə yaradıb hər bir method'u istifadə edə bilməlisiz. GenericRepository
             class'ı üçün İnterface'də istifadə edin.
            */
            #endregion

            #region Student

            GenericRepository<Student> studentRepository = new GenericRepository<Student>();
            Student student1 = new Student()
            {
                Name = "Nubar",
                Surname = "Heyderzade"
            };
            Student student2 = new Student()
            {
                Name = "Nubar2",
                Surname = "Heyderzade2"
            };
            Student student3= new Student()
            {
                Name = "Nubar3",
                Surname = "Heyderzade3"
            };
            
            studentRepository.Create(student1,student2,student3);
            studentRepository.Read();



            #endregion

            #region Book

            GenericRepository<Book> bookRepository = new GenericRepository<Book>();
            Book book1 = new Book()
            {
                Name = "book1",
                Author = "Author1",
                CreateDate = DateTime.Now
            };
            Book book2 = new Book()
            {
                Name = "book2",
                Author = "Author2",
                CreateDate = new DateTime(2023,06,15)
            };
            bookRepository.Create(book1);

            #endregion

            #region Customer
            GenericRepository<Customer> customerRepository = new GenericRepository<Customer>();
            Customer customer1 = new Customer()
            {
                Name = "CustomerName1",
                Surname = "CustomerSurname1"
            };
            Customer customer2 = new Customer()
            {
                Name = "CustomerName2",
                Surname = "CustomerSurname2"
            };
            customerRepository.Create(customer1, customer1);
            #endregion

            #region Teacher
            GenericRepository<Teacher> teacherRepository = new GenericRepository<Teacher>();
            Teacher teacher1 = new Teacher()
            {
                Name = "CustomerName1",
                Surname = "CustomerSurname1"
            };
            Teacher teacher2 = new Teacher()
            {
                Name = "CustomerName2",
                Surname = "CustomerSurname2"
            };
            teacherRepository.Create(teacher1, teacher2);
            #endregion


        }



    }
}
