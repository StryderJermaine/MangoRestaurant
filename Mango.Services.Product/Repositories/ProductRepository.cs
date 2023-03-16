using AutoMapper;
using Mango.Services.Product.DbContexts;
using Mango.Services.Product.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Product.Repositories;

/// <summary>
/// Repository class for <see cref="Models.Product"/>.
/// Implements <see cref="IProductRepository"/>
/// </summary>
public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public ProductRepository(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductDto>> GetProducts()
    {
        return _mapper.Map<List<ProductDto>>(await _dbContext.Products.ToListAsync());
    }

    public async Task<ProductDto> GetProductById(int productId)
    {
        return _mapper.Map<ProductDto>(await _dbContext.Products.FirstOrDefaultAsync(x => x.ProductId == productId));
    }

    public async Task<ProductDto> SaveProduct(ProductDto productDto)
    {
        var product = _mapper.Map<ProductDto, Models.Product>(productDto);

        if (product.ProductId > 0)
        {
            _dbContext.Products.Update(product);
        }
        else
        {
            _dbContext.Products.Add(product);
        }

        await _dbContext.SaveChangesAsync();

        return _mapper.Map<ProductDto>(product);
    }

    public async Task<bool> DeleteProduct(int productId)
    {
        try
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.ProductId == productId);

            if (product == null) return false;
            
            _dbContext.Products.Remove(product);
            
            return await _dbContext.SaveChangesAsync() > 0;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}