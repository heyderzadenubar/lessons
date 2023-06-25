using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework
{
    public class BaseClass
    {
        private int _id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime? EditDate { get; set; }
        public int EditUser { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int DeleteUser { get; set; }

        public static int globalId = -1;

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

        public BaseClass()
        {
            this._id = Interlocked.Increment(ref globalId);
        }

        
    }
}
