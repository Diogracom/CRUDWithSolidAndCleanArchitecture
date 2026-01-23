using CRUD.Domain.ProductEntity;
using CRUD.Domain.RepositoryInterface;
using CRUD.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Infrastructure.RepositoryImplemetation
{
    public class ProductRepository(AppDbContext context) : IProductRepository
    {
       
        public async Task AddAsync(Product product)
        {
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await context.Products.FindAsync(id);

            if (product != null)
            {
                context.Products.Remove(product);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var products = await context.Products.ToListAsync();
            return products;
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            var product = await context.Products.FindAsync(id);

            if (product != null)
            {
               context.Products.Remove(product);
                await context.SaveChangesAsync();
            }

            return product!;

        }

        public async Task UpdateAsync(Product product)
        {
            var entity =  context.Products.Update(product);
            await context.SaveChangesAsync();

        }
    }
}
