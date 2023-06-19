using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SalesShop
{
    public class Database
    {
        private ArrayList database = new ArrayList();

        public Database()
        {
            Base baseClass = new Base();
            Phone phone = new Phone();
            Laptop laptop = new Laptop();
        }
        public static void AddItem()
        {
            
        }
    }
}
