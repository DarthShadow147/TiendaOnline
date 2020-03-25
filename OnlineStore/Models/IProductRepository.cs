using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProduct { get; }
        IEnumerable<Products> GetProductOnSale { get; }
        Products GetProductById(int IdProduct);
    }
}
