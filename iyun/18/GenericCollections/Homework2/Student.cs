using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework2
{
    public class Student : GenericRepository<Student>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        readonly private int _id;
        public static int GlobalId;

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
            }
        }
        public Student()
        {
            _id = Interlocked.Increment(ref GlobalId);
        }
        static int i = 1;

        public override void Read()
        {
            Console.WriteLine($"_Student-{i}_\r\nName: {Name}\r\nSurname: {Surname}\r\nEmail: {Email}");
            i++;
        }

        public override void Update(int id)
        {
            Student foundStudent = VirtualDatabase<Student>.virtualDatabase.Find(i => i.Id == id);
            if(foundStudent != null)
            {
                foundStudent.Email = "Update email";
            }
            else
            {
                Console.WriteLine("Telebe tapilmadi!");
            }
        }

        public override void Delete(int id)
        {
            Student foundStudent = VirtualDatabase<Student>.virtualDatabase.Find(i => i.Id == id);
            if (foundStudent != null)
            {
                VirtualDatabase<Student>.virtualDatabase.Remove(foundStudent);
            }
        }
    }
}
