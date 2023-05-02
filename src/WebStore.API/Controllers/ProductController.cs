using Microsoft.AspNetCore.Mvc;
using WebStore.API.Requests;
using WebStore.Core.Models;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    private readonly ILogger<ProductController> _logger;
    private readonly IRepository<Product> _productRepository;

    public ProductController(IRepository<Product> productRepository, ILogger<ProductController> logger)
    {
        _productRepository = productRepository;
        _logger = logger;
    }
    
    [HttpGet]
    public async Task<IActionResult> List()
    {
        return Ok(_productRepository.List());
    }
    
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Get(GetProductRequest productRequest)
    {
        var product = _productRepository.GetById(productRequest.Id);

        if (product is null) {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductRequest createProductRequest)
    {

        var success = _productRepository.Add(createProductRequest.toProduct());

        if (! success) {
            return BadRequest();
        };

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateProductRequest updateProductRequest)
    {
        var success = _productRepository.Update(updateProductRequest.toProduct());

        if (! success) {
            return BadRequest();
        };

        return Ok();

    }

    [HttpDelete]
    public async Task<IActionResult> Delete(DeleteProductRequest deleteProductRequest)
    {
        var success = _productRepository.Delete(deleteProductRequest.Id);

        if (! success) {
            return BadRequest();
        };

        return Ok();
    }
}
