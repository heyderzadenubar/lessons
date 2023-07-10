using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework2
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
                Surname = "Heyderzade",
                Email="Email1",
                Phone=123
            };
            Student student2 = new Student()
            {
                Name = "Nubar2",
                Surname = "Heyderzade2",
                Email = "Email2",
                Phone = 123
            };

            studentRepository.Create(student1);
            studentRepository.Create(student2);
            student1.Read();
            student2.Read();
            student1.Update(1);
            student2.Delete(2);
            #endregion

            #region Books
            GenericRepository<Book> bookRepository = new GenericRepository<Book>();
            Book book1 = new Book()
            {
                Name = "book1",
                Author = "Author1"
            };
            Book book2 = new Book()
            {
                Name = "book2",
                Author = "Author2"
            };
            Book book3 = new Book()
            {
                Name = "book3",
                Author = "Author3"
            };
            bookRepository.Create(book1);
            bookRepository.Create(book2);
            bookRepository.Create(book3);
            book1.Read();
            book2.Read();
            book1.Update(1);
            book2.Delete(2);

            #endregion
        }

    }
}
