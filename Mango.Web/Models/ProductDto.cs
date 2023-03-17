namespace Mango.Web.Models;

/// <summary>
/// Dto class for Product/>
/// </summary>
public class ProductDto
{
    /// <summary>
    /// Product Id
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Product name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Price of product
    /// </summary>
    public double Price { get; set; }

    /// <summary>
    /// Product description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Category of product
    /// </summary>
    public string CategoryName { get; set; }

    /// <summary>
    /// Image URL
    /// </summary>
    public string ImageUrl { get; set; }
}