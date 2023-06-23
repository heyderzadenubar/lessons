using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomework_23._06
{
    public class Address
    {

        public int Id { get; set; }
        public int No { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        //---- Inner tTpes ---
        City city = new City();
    }
}
