using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    public class Teacher : Employee
    {
        //Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, DateOfStartWorking, DateOfEndWorking, RestDays, Branch, Level, RegUser, RegDate, EditUser, EditDate, Deleted
       
        public string  Branch { get; set; }
        public string Level { get; set; }
    }
}
