using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework_2
{
    public class Customer : GenericRepository<Customer>
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

        public Customer()
        {
            _id = Interlocked.Increment(ref globalId);
        }


       /* public override void Read()
        {
            VirtualDatabase<Customer>.ItemList.ForEach(i => Console.WriteLine($"____ Customer - {i.Id}\r\n_____," +
                                                      $"ID: {i.Id}\r\n" +
                                                      $"Name: {i.Name}\r\n" +
                                                      $"Surname: {i.Surname}\r\n"));
        }*/
    }
}
