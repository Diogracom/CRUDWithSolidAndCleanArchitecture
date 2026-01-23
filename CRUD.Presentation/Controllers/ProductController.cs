using CRUD.Application.ProductDTOs;
using CRUD.Application.UseCaseInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var product = await productService.GetAllProductAsync();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductDto productDto)
        {
            await productService.AddProductAsync(productDto);
            return CreatedAtAction(nameof(GetById), new { id = productDto.Name }, productDto);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductDto productDto)
        {
            await productService.UpdateProductAsync(productDto);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await productService.DeleteProductByIdAsync(id);
            return NoContent();

        }
    }
}

