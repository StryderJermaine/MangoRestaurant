﻿using System.ComponentModel.DataAnnotations;

namespace Mango.Services.Product.Models;

/// <summary>
/// Model class for products table
/// </summary>
public class Product
{
    /// <summary>
    /// Product Id
    /// </summary>
    [Key]
    public int ProductId { get; set; }

    /// <summary>
    /// Product name
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// Price of product
    /// </summary>
    [Range(1, 1000)]
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