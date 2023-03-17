using Mango.Web.Models;
using Mango.Web.Services.Interfaces;

namespace Mango.Web.Services;

/// <summary>
/// Service class for Products
/// </summary>
public class ProductService : BaseService,IProductService
{
    private readonly IHttpClientFactory _httpClient;

    public ProductService(IHttpClientFactory httpClient) : base(httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T> GetAllProductsAsync<T>()
    {
        return await SendAsync<T>(new ApiRequest
        {
            ApiType = Constants.ApiType.GET,
            Url = $"{Constants.ProductApiBase}/api/products",
            AccessToken = ""
        });
    }

    public async Task<T> GetProductByIdAsync<T>(int id)
    {
        return await SendAsync<T>(new ApiRequest()
        {
            ApiType = Constants.ApiType.GET,
            Url = $"{Constants.ProductApiBase}/api/products/{id}",
            AccessToken = ""
        });
    }

    public async Task<T> CreateProductAsync<T>(ProductDto productDto)
    {
        return await SendAsync<T>(new ApiRequest
        {
            ApiType = Constants.ApiType.POST,
            Data = productDto,
            Url = $"{Constants.ProductApiBase}/api/products",
            AccessToken = ""
        });
    }

    public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
    {
        return await SendAsync<T>(new ApiRequest()
        {
            ApiType = Constants.ApiType.PUT,
            Data = productDto,
            Url = $"{Constants.ProductApiBase}/api/products",
            AccessToken = ""
        });
    }

    public async Task<T> DeleteProductAsync<T>(int id)
    {
        return await SendAsync<T>(new ApiRequest
        {
            ApiType = Constants.ApiType.DELETE,
            Url = $"{Constants.ProductApiBase}/api/products/{id}",
            AccessToken = ""
        });
    }
}




