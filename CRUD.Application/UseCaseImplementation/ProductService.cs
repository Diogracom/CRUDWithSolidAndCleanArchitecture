using CRUD.Application.MappingInterface;
using CRUD.Application.ProductDTOs;
using CRUD.Application.UseCaseInterface;
using CRUD.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.UseCaseImplementation
{
    internal class ProductService(IProductRepository productRepository, IProductMapper productMapper) : IProductService 
    {
        public async Task AddProductAsync(CreateProductDto productDto)
        {
            var product = productMapper.MapToEntity(productDto);
             await productRepository.AddAsync(product);
        }

        public async Task DeleteProductByIdAsync(int id)
        {
           await  productRepository.DeleteAsync(id);
             
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductAsync()
        {
            var products = await productRepository.GetAllAsync();
            return products.Select(product => productMapper.MapToDTO(product)).ToList();
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var product = await productRepository.GetByIdAsync(id);
            return product == null ? null : productMapper.MapToDTO(product);
        }

        public Task UpdateProductAsync(UpdateProductDto productDto)
        {
            var product = productMapper.MapToEntity(productDto);
            return productRepository.UpdateAsync(product);
        }
    }
}
