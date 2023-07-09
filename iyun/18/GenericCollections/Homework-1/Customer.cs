using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework_1
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public static int globalId;
        private int _id;

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

        public Customer()
        {
            _id = Interlocked.Increment(ref globalId);
            Address = new Address();
        }
    }
}
