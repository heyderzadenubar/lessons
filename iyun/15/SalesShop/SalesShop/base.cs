using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesShop
{
    public class Base
    {
        public int Id { get; private set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public decimal BuyPrice  { get; set; }
        public decimal SellPrice { get; set; }
        public decimal OfferPrice { get; set; }
        public decimal Barcode { get; set; }

        public static int GlobalId;

        

    }
}
