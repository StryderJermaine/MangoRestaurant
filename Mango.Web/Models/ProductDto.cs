using System.Text.Json.Serialization;

namespace Mango.Web.Models;

/// <summary>
/// Dto class for Product/>
/// </summary>
public class ProductDto
{
    /// <summary>
    /// Product Id
    /// </summary>
    [JsonPropertyName("productId")]
    public int ProductId { get; set; }

    /// <summary>
    /// Product name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Price of product
    /// </summary>
    [JsonPropertyName("price")]
    public double Price { get; set; }

    /// <summary>
    /// Product description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Category of product
    /// </summary>
    [JsonPropertyName("categoryName")]
    public string CategoryName { get; set; }

    /// <summary>
    /// Image URL
    /// </summary>
    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; set; }
}