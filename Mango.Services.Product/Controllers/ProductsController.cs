using Mango.Services.Product.Models.Dto;
using Mango.Services.Product.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.Product.Controllers
{
    /// <summary>
    /// API controller for Products
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// API to get all products
        /// </summary>
        /// <returns>A <see cref="ResponseDto"/> object with a list of <see cref="ProductDto"/>s</returns>
        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            try
            {
                return new ResponseDto { IsSuccessful = true, Message = "Success", Result = await _repository.GetProducts() };
            }
            catch (Exception e)
            {
                return new ResponseDto { IsSuccessful = false, Message = e.Message, Errors = new List<string>{ e.ToString() }};
            }
        }

        /// <summary>
        /// API to get a product by id
        /// </summary>
        /// <returns>A <see cref="ResponseDto"/> object with a <see cref="ProductDto"/> object</returns>
        [HttpGet("{id}")]
        public async Task<ResponseDto> Get(int id)
        {
            try
            {
                return new ResponseDto { IsSuccessful = true, Message = "Success", Result = await _repository.GetProductById(id) };
            }
            catch (Exception e)
            {
                return new ResponseDto { IsSuccessful = false, Message = e.Message, Errors = new List<string> { e.ToString() } };
            }
        }

        /// <summary>
        /// API to create a new product
        /// </summary>
        /// <param name="productDto">Product to be created</param>
        /// <returns>A <see cref="ResponseDto"/> object with the created product</returns>
        [HttpPost]
        public async Task<ResponseDto> Post([FromBody] ProductDto productDto)
        {
            try
            {
                return new ResponseDto
                    { IsSuccessful = true, Message = "Success", Result = await _repository.SaveProduct(productDto) };
            }
            catch (Exception e)
            {
                return new ResponseDto { IsSuccessful = false, Message = e.Message, Errors = new List<string> { e.ToString() } };
            }
        }

        /// <summary>
        /// API to update a <see cref="Models.Product"/>
        /// </summary>
        /// <param name="productDto">Product to be updated</param>
        /// <returns>A <see cref="ResponseDto"/> object with the updated product</returns>
        [HttpPut]
        public async Task<ResponseDto> Put([FromBody] ProductDto productDto)
        {
            try
            {
                return new ResponseDto
                    { IsSuccessful = true, Message = "Success", Result = await _repository.SaveProduct(productDto) };
            }
            catch (Exception e)
            {
                return new ResponseDto { IsSuccessful = false, Message = e.Message, Errors = new List<string> { e.ToString() } };
            }
        }

        /// <summary>
        /// API to delete a product
        /// </summary>
        /// <param name="id">Id of the product to be deleted</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ResponseDto> Delete(int id)
        {
            try
            {
                var result = await _repository.DeleteProduct(id);

                return new ResponseDto { IsSuccessful = result, Message = result ? "Success" : "Error"};
            }
            catch (Exception e)
            {
                return new ResponseDto { IsSuccessful = false, Message = e.Message, Errors = new List<string> { e.ToString() } };
            }
        }
    }
}
