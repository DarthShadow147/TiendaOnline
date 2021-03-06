﻿using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Products> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
