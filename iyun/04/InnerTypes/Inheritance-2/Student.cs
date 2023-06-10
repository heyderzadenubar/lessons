using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    public class Student :Base
    {
        //Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, Department, Level, RegUser, RegDate, EditUser, EditDate, Deleted
       
        public string Department { get; set; }
        public string Level { get; set; }
    }
}
