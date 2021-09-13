using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FPT.ApiIntegration;
using FPT.ViewModels.Catalog.Products;
using FPT.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FPT.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Detail(int id, string culture)
        {
            var product = await _productApiClient.GetById(id, culture);
            return View(new ProductDetailViewModel()
            {
                Product = product
            });
        }

    }
}