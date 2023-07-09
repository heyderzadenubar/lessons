using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WindowsFormsAppPart3_Homework
{
    public class Customer
    {
        private readonly int _id; 
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public static int globalId;

        public int Id { get { return this._id; } set { } }
        public Customer()
        {
            this._id = Interlocked.Increment(ref globalId);
        }

        public override string ToString()
        {
            return "__Customer__"+Id+" Name:" + Name+"  Surname:"+ Surname+"  Email"+ Email+"  Phone:"+ Phone+"\r\n";
            
        }
    }
}
