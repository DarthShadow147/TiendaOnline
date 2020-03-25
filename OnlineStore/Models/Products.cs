using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Products
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public int IdCategory { get; set; }
        public int IdSubCategory { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
