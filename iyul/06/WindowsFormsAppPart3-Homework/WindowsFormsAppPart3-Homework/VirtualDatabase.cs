using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPart3_Homework
{
    public static class VirtualDatabase
    {
       public static List<Customer> CustomerList { get; set; }

        static VirtualDatabase()
        {
            CustomerList = new List<Customer>();
        }


    }
}
