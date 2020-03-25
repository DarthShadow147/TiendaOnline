using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using OnlineStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.GetAllProduct;
            productListViewModel.CurrentCategory = "";
            //ViewBag.CurrentCategory = "";
            return View(productListViewModel);
        }
    }
}
