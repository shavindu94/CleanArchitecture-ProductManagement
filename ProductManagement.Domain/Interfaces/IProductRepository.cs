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
        List<Product> GetFiletedList(string searchString = "", int pageNumber = 1, int pageSize = 10);
    }
}
