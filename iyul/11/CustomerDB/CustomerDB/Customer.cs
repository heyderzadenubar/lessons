using CustomerDB.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDB
{
    public class Customer
    {
        public string gender;

        public string Name { get; set; }
        public string Surname { get; set; }
        public GenderEnum Gender
        {
            set
            {
                if (value == GenderEnum.Male)
                {
                    this.gender = "Kişi";
                }
                else if(value==GenderEnum.Female)
                {
                    this.gender = "Qadın";
                }
            }
        }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool isDeleted { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
