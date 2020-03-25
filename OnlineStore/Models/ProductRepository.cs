using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Products> GetAllProduct => new List<Products>
        {
            new Products {IdProduct = 1, ProductName = "Locion Adidas", Description ="Lorem"}
        };

        public IEnumerable<Products> GetProductOnSale => throw new NotImplementedException();

        public Products GetProductById(int IdProduct)
        {
            throw new NotImplementedException();
        }
    }
}
