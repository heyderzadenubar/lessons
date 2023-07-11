using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Person:Item
    {
        public string Surname { get; set; }
        public GenderEnum Gender { get; set; }
        public DateTime Birthday { get; set; }
    }
}
