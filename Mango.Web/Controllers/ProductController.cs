using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Mango.Web.Models;
using Mango.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto> list = new();

            var response = await _productService.GetAllProductsAsync<ResponseDto>();

            if (response is { IsSuccessful: true })
            {
                list = JsonSerializer.Deserialize<List<ProductDto>>(Convert.ToString(response.Result)!)!;
            }

            return View(list);
        }

        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductCreate(ProductDto model)
        {
            var response = await _productService.CreateProductAsync<ResponseDto>(model);

            if (response is { IsSuccessful: true })
            {
                return RedirectToAction(nameof(ProductIndex));
            }

            return View(model);
        }

        public async Task<IActionResult> ProductEdit(int productId)
        {
            var response = await _productService.GetProductByIdAsync<ResponseDto>(productId);

            if (response is { IsSuccessful: true })
            {
                var product = JsonSerializer.Deserialize<ProductDto>(Convert.ToString(response.Result)!)!;

                return View(product);
            }
            
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductEdit(ProductDto model)
        {
            var response = await _productService.UpdateProductAsync<ResponseDto>(model);

            if (response is { IsSuccessful: true })
            {
                return RedirectToAction(nameof(ProductIndex));
            }

            return View(model);
        }

        public async Task<IActionResult> ProductDelete(int productId)
        {
            var response = await _productService.GetProductByIdAsync<ResponseDto>(productId);

            if (response is { IsSuccessful: true })
            {
                var product = JsonSerializer.Deserialize<ProductDto>(Convert.ToString(response.Result)!)!;

                return View(product);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductDelete(ProductDto model)
        {
            var response = await _productService.DeleteProductAsync<ResponseDto>(model.ProductId);

            if (response is { IsSuccessful: true })
            {
                return RedirectToAction(nameof(ProductIndex));
            }

            return View(model);
        }
    }
}
