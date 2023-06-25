using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Item : BaseClass
    {
        private string _barcode { get; set; }
        public static bool isDubicateBarcode = false;
        public decimal buyPrice;
        public static bool isValidBuyPrice = true;
        public decimal sellPrice;
        public static bool isValidsellPrice = true;
        public decimal offerPrice;
        public static bool isValidOfferPrice = true;

        public decimal BuyPrice
        {
            get
            {
                return this.buyPrice;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine($"__ Item - {globalId} __");
                    Console.WriteLine("Alis qiymeti 1-den kicik ola bilmez!");
                    isValidBuyPrice = false;
                }
                else
                {
                    this.buyPrice = value;
                    isValidBuyPrice = true;
                }
            }
        }
        public decimal SellPrice
        {
            get
            {
                return this.sellPrice;
            }
            set
            {
                if (value < this.buyPrice)
                {
                    Console.WriteLine($"__ Item - {globalId} __");
                    Console.WriteLine("Satis qiymeti alis qiymetinden az ola bilmez!");
                    isValidsellPrice = false;
                }
                else
                {
                    sellPrice = value;
                    isValidsellPrice = true;
                }
            }
        }
        public decimal OfferPrice
        {
            get
            {
                return this.offerPrice;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine($"__ Item - {globalId} __");
                    Console.WriteLine("Kompaniya qiymeti 1-den kicik ola bilmez!");
                    isValidOfferPrice = false;
                }
                else
                {
                    this.offerPrice = value;
                    isValidOfferPrice = true;
                }
            }
        }
        
        
        public string Barcode
        {
            get
            {
                return this._barcode;
            }
            set
            {
                if (Database.CheckDublicateBarcode(value))
                {
                    Console.WriteLine($"__ Item - {globalId} __");
                    Console.WriteLine("Bu barkod daha once basqa mehsul ucun sisteme elave olunub!");
                }
                else
                {
                    this._barcode = value;
                }
            }
        }
        

    }
}
