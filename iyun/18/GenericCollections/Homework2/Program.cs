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
            //Student student3= new Student()
            //{
            //    Name = "Nubar3",
            //    Surname = "Heyderzade3"
            //};

            studentRepository.Create(student1);
            studentRepository.Create(student2);
            student1.Read();
            student2.Read();
            student1.Update(1);
            student2.Delete(2);
            #endregion
        }
    }
}
