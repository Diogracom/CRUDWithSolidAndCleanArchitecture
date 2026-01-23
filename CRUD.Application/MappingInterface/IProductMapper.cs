using CRUD.Application.ProductDTOs;
using CRUD.Domain.ProductEntity;


namespace CRUD.Application.MappingInterface
{
    public interface IProductMapper
    {
        ProductDto MapToDTO(Product product);
        Product MapToEntity(CreateProductDto createDto);
        Product MapToEntity(UpdateProductDto updateDto);


    }
}
