using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework_1
{
    public class Address
    {
        //Id, No, Building, Street,  City, Country
        public int No { get; set; }
        public string  Building { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        private int _id;
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

        public Address()
        {
            _id = Interlocked.Increment(ref globalId);
        }
    }
}
