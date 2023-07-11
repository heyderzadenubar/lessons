using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Books:Item
    {
        public int Barcode { get; set; }
        public DateTime  CreateDate { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal OfferPrice { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? EditDate { get; set; }
        public int? EditUser { get; set; }
        public Authors author;

        public int authorId;
        public int AuthorId
        {
            get
            {
                return this.authorId;
            }
            set
            {
                if (VirtualDatabase.IsContatinAuthorId(value))
                {
                    this.authorId = value;
                }
                else
                {
                    Console.WriteLine("Qeyd etdiyiniz muellif bazada movcud deyil");
                }
            }
        }

        public Books()
        {
            author = new Authors();
        }
    }
}
