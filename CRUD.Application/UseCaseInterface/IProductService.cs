using CRUD.Application.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.UseCaseInterface
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductAsync();
        Task<ProductDto?>  GetProductByIdAsync(int id);    
        Task AddProductAsync(CreateProductDto productDto);
        Task UpdateProductAsync(UpdateProductDto productDto);
        Task DeleteProductByIdAsync(int id);
    }
}
