using ProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Interfaces
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        List<Product> GetFilteredList(string searchString = "", int pageNumber = 1, int pageSize = 10);

        Task<IEnumerable<Product>> GetFilteredListAsync(string searchString = "", int pageNumber = 1, int pageSize = 10);

        Task<Product> GetByIdAsync(Guid id);
    }
}
