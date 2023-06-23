using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypes
{
    internal class Contacts
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

       
    }
}
