using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            /* Ejemplo */
            new Category{IdCategory=1,Name="Hombre", Description="Perfumes para hombre"}
        };
    }
}
