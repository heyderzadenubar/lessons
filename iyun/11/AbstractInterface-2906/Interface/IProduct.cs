using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IProduct
    {
        void Add(Product product);
        void AddProducts(params Product[] product);
        void Delete(Product product);
        void Update(Product product);
        void ShowProduct();

    }
}
