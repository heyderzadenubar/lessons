using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Part3_homework1
{
    public class Base
    {
        public int id=1;
        public int Barcode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }
        public double OfferPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? EditDate { get; set; }
        public string EditUser { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string DeleteUser { get; set; }

        


    }
}
