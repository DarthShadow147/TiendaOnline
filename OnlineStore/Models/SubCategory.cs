using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class SubCategory
    {
        public int IdSubCategory { get; set; }
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public List<Products> Products { get; set; }
    }
}
