using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework_2
{
    public class Student : GenericRepository<Student>
    {
        private readonly int _id;
        public static int globalId;

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
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public Student()
        {
            _id = Interlocked.Increment(ref globalId);
        }

        public override void Read()
        {
            ItemList.ForEach(i => Console.WriteLine($"____Student - {i.Id}\r\n_____," +
                                                      $"ID: {i.Id}\r\n" +
                                                      $"Name: {i.Name}\r\n" +
                                                      $"Surname: {i.Surname}\r\n"));
        }
    }
}
