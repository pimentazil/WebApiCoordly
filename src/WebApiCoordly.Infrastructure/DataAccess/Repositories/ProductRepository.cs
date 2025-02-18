using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using WebApiCoordly.Domain.Entities;
using WebApiCoordly.Domain.Repositories.Product;

namespace WebApiCoordly.Infrastructure.DataAccess.Repositories
{
    public class ProductRepository : IProductWriteOnlyRepository
    {
        private readonly CoordlyDbContext _dbContext;

        public ProductRepository(CoordlyDbContext dbContext) => _dbContext = dbContext;

        public async Task Add(Product product)
        {
            await _dbContext.Product.AddAsync(product);
        }

        public async Task Delete(int id)
        {
            var productToRemove = await _dbContext.Product.FindAsync(id);
            _dbContext.Product.Remove(productToRemove!);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _dbContext.Product.AsNoTracking().ToListAsync();
        }
        public void Update(Product product)
        {
            _dbContext.Product.Update(product);
        }
        public async Task<Product> GetById(int ProductID)
        {
            return await _dbContext.Product
                .FirstOrDefaultAsync(product => product.ProductID == ProductID);
        }
    }
}
