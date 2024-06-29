﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoShowroom_Api.Repositories.CategoryRepository;
using AutoShowroom_Api.Repositories.ProductRepository;

namespace AutoShowroom_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoriesAsync();
            return Ok(values);
        }

    }
}
