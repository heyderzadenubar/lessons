using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Brand = "Brand-1",
                CreateDate = DateTime.Now,
                Id = 1,
            };

            Product product2 = new Product()
            {
                Brand = "Brand-2",
                CreateDate = DateTime.Now,
                Id = 2
            };

            Product product3 = new Product()
            {
                Brand = "Brand-3",
                CreateDate = DateTime.Now,
                Id = 3
            };

            Database db = new Database();
            db.AddProducts(product1, product2, product3);

            db.Update(product2);

            db.Delete(product3);

            db.ShowProduct();
        }
    }
}
