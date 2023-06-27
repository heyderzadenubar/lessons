using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    public class Base
    {
        public int Id { get; set; }
        public int ReferanceNumber { get; set; }
        public int DocumentNumber { get; set; }
        public string Name { get; set; }   // basqa class-a daxil etmek meslehetlidi
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int RegUser { get; set; }
        public DateTime RegDate { get; set; }
        public int EditUser { get; set; }
        public DateTime EditDate { get; set; }
        public bool Deleted { get; set; }
    }
}
