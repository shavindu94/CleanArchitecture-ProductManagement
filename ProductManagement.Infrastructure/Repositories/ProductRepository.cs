using Microsoft.EntityFrameworkCore;
using ProductManagement.Domain.Interfaces;
using ProductManagement.Domain.Models;
using ProductManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductDbContext context) : base(context)
        {
        }

        public List<Product> GetFiletedList(string searchString = "", int pageNumber = 1, int pageSize = 10)
        {
            var list = _context.Products.Where(a => a.Name.Contains((searchString == "" || searchString == null) ? a.Name : searchString))
                          .OrderBy(x => x.ReOrderLevel).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            return list;
        }

        public async Task<IEnumerable<Product>> GetFiletedListAsync(string searchString = "", int pageNumber = 1, int pageSize = 10)
        {
            return await Find(a => a.Name.Contains((searchString == "" || searchString == null) ? a.Name : searchString))
                  .OrderBy(x => x.ReOrderLevel).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }
    }
}
