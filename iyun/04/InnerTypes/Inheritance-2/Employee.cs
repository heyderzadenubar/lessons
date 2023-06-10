using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    public class Employee : Base
    {
        //Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, DateOfStartWorking, DateOfEndWorking, RestDays, RegUser, RegDate, EditUser, EditDate, Deleted
       
        public DateTime DateOfStartWorking { get; set; }
        public DateTime DateOfEndWorking { get; set; }
        public int RestDays { get; set; }
    }
}
