using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Interface 
{
    public class Database : IProduct
    {
        private static ArrayList database = new ArrayList();
        

       public void Add(Product product)
       {
            database.Add(product);
       }

        public void AddProducts(params Product[] product)
        {
            for (int i = 0; i < product.Length; i++)
            {
                database.Add(product[i]);
            }
        }

        public void Delete(Product product)
        {
            for (int i = 0; i < database.Count; i++)
            {
                Product productTemp = (Product)database[i];
                if (product.Id == productTemp.Id)
                {
                    productTemp.IsDeleted = true;
                    productTemp.DeleteDate = DateTime.Now;
                }
            }
        }

        public void Update(Product product)
        {
            Product productTemp;
            for (int i = 0; i < database.Count; i++)
            {
                productTemp = (Product)database[i];
                if (product.Id == productTemp.Id)
                {
                    productTemp.EditDate = DateTime.Now;
                    break;
                }
            }
        }

        public void ShowProduct()
        {
            for (int i = 0; i < database.Count; i++)
            {
                Product product = (Product)database[i];
                Console.WriteLine($"_______Product - {i+1}_______");
                Console.WriteLine($"ID: {product.Id}");
                Console.WriteLine($"Brand: {product.Brand}");
                Console.WriteLine($"Create: {product.CreateDate}");
                Console.WriteLine($"Delete status: {product.IsDeleted}");
                if (product.EditDate == null)
                {
                    Console.WriteLine($"Edit date: Product is not edited.");
                }
                else
                {
                    Console.WriteLine($"Edit date: {product.EditDate}");
                    Console.WriteLine("");
                }
            }
        }
    }
}
