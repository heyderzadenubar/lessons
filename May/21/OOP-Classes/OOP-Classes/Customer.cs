using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    class Customer
    {
        #region Methods in Classes
        protected bool CheckCustomerFromDb()
        {
            return true;
        }

        public bool CheckCustomer()
        {
            bool result = CheckCustomerFromDb();
            return result;
        }
        #endregion
    }
}
