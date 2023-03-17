using Mango.Web.Models;

namespace Mango.Web.Services.Interfaces;

/// <summary>
/// Interface class for Products
/// </summary>
public interface IProductService : IBaseService
{
    /// <summary>
    /// Method to get all products
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    Task<T> GetAllProductsAsync<T>();

    /// <summary>
    /// Method to get a product by id
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="id">Id of the product</param>
    /// <returns></returns>
    Task<T> GetProductByIdAsync<T>(int id);

    /// <summary>
    /// Method to create a product
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="productDto">New product to be created</param>
    /// <returns></returns>
    Task<T> CreateProductAsync<T>(ProductDto productDto);

    /// <summary>
    /// Method to update a product
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="productDto">Product to be updated</param>
    /// <returns></returns>
    Task<T> UpdateProductAsync<T>(ProductDto productDto);

    /// <summary>
    /// Method to delete a product
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="id">Id of the product to be deleted</param>
    /// <returns></returns>
    Task<T> DeleteProductAsync<T>(int id);
}