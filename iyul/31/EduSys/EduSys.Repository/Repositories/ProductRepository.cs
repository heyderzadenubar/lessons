using EduSys.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduSys.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EduSys.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
                
        }
        public async Task<List<Product>> GetProductWithCategory()
        {
            //Eager loading
            return await _context.Products.Include(x=>x.Category).ToListAsync();

            //Eager loading
            //Lazy loading
        }
    }
}
