using Mango.Services.Product.Models.Dto;

namespace Mango.Services.Product.Repositories;

/// <summary>
/// Repository class for <see cref="Models.Product"/>
/// </summary>
public interface IProductRepository
{
    /// <summary>
    /// Method to get a list of <see cref="Models.Product"/>s
    /// </summary>
    /// <returns>List of <see cref="ProductDto"/>s</returns>
    Task<IEnumerable<ProductDto>> GetProducts();

    /// <summary>
    /// Method to get a <see cref="Models.Product"/> by Id
    /// </summary>
    /// <param name="productId">Id of the product</param>
    /// <returns>A <see cref="ProductDto"/></returns>
    Task<ProductDto> GetProductById(int productId);

    /// <summary>
    /// Method to save a <see cref="Models.Product"/>
    /// </summary>
    /// <param name="productDto"></param>
    /// <returns>The saved <see cref="Models.Product"/></returns>
    Task<ProductDto> SaveProduct(ProductDto productDto);

    /// <summary>
    /// Method to delete a product
    /// </summary>
    /// <param name="productId">Id of the product to be deleted</param>
    /// <returns>A <see cref="bool"/> to indicate success or failure</returns>
    Task<bool> DeleteProduct(int productId);
}