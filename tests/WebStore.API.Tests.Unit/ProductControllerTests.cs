using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using WebStore.API.Controllers;
using WebStore.API.Requests;
using WebStore.Core.Models;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.API.Tests.Unit;

public class ProductControllerTests
{
    private readonly ProductController _sut;
    private readonly IRepository<Product> _productRepository = Substitute.For<IRepository<Product>>();
    private readonly ILogger<ProductController> _logger = Substitute.For<ILogger<ProductController>>();
    public ProductControllerTests()
    {
        _sut = new ProductController(_productRepository, _logger);
    }
    
    [Fact]
    public async Task List_ReturnsOkAndListOfProducts_WhenProductsExist()
    {
        // Arrange
        Product[] products = {
            new Product {
                Name = "Dry Food",
                Description = "Premium, delicious, kibble made from free range, grass-fed horses",
                Price = 12.34m,
                Category = "food"
            },
            new Product {
                Description = "Wet Food",
                Name = "Hearty, chunky, pieces of 84% mercury-free tuna",
                Price = 23.45m,
                Category = "food"
            }
        };
        _productRepository.List().Returns(products);

        // Act
        var result = (OkObjectResult)await _sut.List();

        // Assert
        result.StatusCode.Should().Be(200);
        result.Value.Should().BeEquivalentTo(products);
    }
    
    [Fact]
    public async Task List_ReturnsOk_WhenNoProductsExist()
    {
        // Arrange
        _productRepository.List().ReturnsNull();

        // Act
        var result = (OkObjectResult)await _sut.List();

        // Assert
        result.StatusCode.Should().Be(200);
        result.Value.Should().BeNull();
    }
    
    [Fact]
    public async Task Get_ReturnsOkAndObject_WhenProductExists()
    {
        // Arrange
        var product = new Product {
            Name = "Dry Food",
            Description = "Premium, delicious, kibble made from free range, grass-fed horses",
            Price = 12.34m,
            Category = "food"
        };

        _productRepository.GetById(product.Id).Returns(product);

        // Act
        var result = (OkObjectResult)await _sut.Get(product.Id);

        // Assert
        result.StatusCode.Should().Be(200);
        result.Value.Should().BeEquivalentTo(product);
    }
    
    [Fact]
    public async Task Get_ReturnsNotFound_WhenProductDoesntExist()
    {
        // Arrange
        _productRepository.GetById(Arg.Any<Guid>()).ReturnsNull();

        // Act
        var result = (NotFoundResult)await _sut.Get(Guid.NewGuid());

        // Assert
        result.StatusCode.Should().Be(404);
    }
    
    [Fact]
    public async Task Create_ReturnsOk_WhenProductCreated()
    {
        // Arrange
        var product = new Product {
            Name = "Dry Food",
            Description = "Premium, delicious, kibble made from free range, grass-fed horses",
            Price = 12.34m,
            Category = "food"
        };

        _productRepository.Add(Arg.Any<Product>()).Returns(true);

        // Act
        var result = (OkResult)await _sut.Create(new CreateProductRequest(product.Name, product.Description, product.Price, product.Category));

        // Assert
        result.StatusCode.Should().Be(200);
    }
    
    [Fact]
    public async Task Create_ReturnsBadRequest_WhenProductNotCreated()
    {
        // Arrange
        var product = new Product {
            Name = "Dry Food",
            Description = "Premium, delicious, kibble made from free range, grass-fed horses",
            Price = 12.34m,
            Category = "food"
        };

        _productRepository.Add(Arg.Any<Product>()).Returns(false);

        // Act
        var result = (BadRequestResult)await _sut.Create(new CreateProductRequest(product.Name, product.Description, product.Price, product.Category));

        // Assert
        result.StatusCode.Should().Be(400);
    }
    
    [Fact]
    public async Task Update_ReturnsOk_WhenProductUpdated()
    {
        // Arrange
        var product = new Product {
            Name = "Dry Food",
            Description = "Premium, delicious, kibble made from free range, grass-fed horses",
            Price = 12.34m,
            Category = "food"
        };

        _productRepository.Update(Arg.Any<Product>()).Returns(true);

        // Act
        var result = (OkResult)await _sut.Update(new UpdateProductRequest(product.Id, product.Name, product.Description, product.Price, product.Category));

        // Assert
        result.StatusCode.Should().Be(200);
    }
    
    [Fact]
    public async Task Update_ReturnsBadRequest_WhenProductNotUpdated()
    {
        // Arrange
        var product = new Product {
            Name = "Dry Food",
            Description = "Premium, delicious, kibble made from free range, grass-fed horses",
            Price = 12.34m,
            Category = "food"
        };

        _productRepository.Update(Arg.Any<Product>()).Returns(false);

        // Act
        var result = (BadRequestResult)await _sut.Update(new UpdateProductRequest(product.Id, product.Name, product.Description, product.Price, product.Category));

        // Assert
        result.StatusCode.Should().Be(400);
    }
    
    [Fact]
    public async Task Delete_ReturnsOk_WhenProductDeleted()
    {
        // Arrange
        _productRepository.Delete(Arg.Any<Guid>()).Returns(true);

        // Act
        var result = (OkResult)await _sut.Delete(new DeleteProductRequest(Guid.NewGuid()));

        // Assert
        result.StatusCode.Should().Be(200);
    }
    
    [Fact]
    public async Task Delete_ReturnsBadRequest_WhenProductNotDeleted()
    {
        // Arrange
        _productRepository.Delete(Arg.Any<Guid>()).Returns(false);

        // Act
        var result = (BadRequestResult)await _sut.Delete(new DeleteProductRequest(Guid.NewGuid()));

        // Assert
        result.StatusCode.Should().Be(400);
    }
}