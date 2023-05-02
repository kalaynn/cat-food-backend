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
    public async Task GetById_ReturnsOkAndObject_WhenUserExists()
    {
        // Arrange
        var product = new Product(
            "Dry Food",
            "Premium, delicious, kibble made from free range, grass-fed horses",
            1234
        );

        _productRepository.GetById(product.Id).Returns(product);

        // Act
        var result = (OkObjectResult)await _sut.Get(new GetProductRequest(product.Id));

        // Assert
        result.StatusCode.Should().Be(200);
        result.Value.Should().BeEquivalentTo(product);
    }
    
    [Fact]
    public async Task GetById_ReturnsNotFound_WhenUserDoesntExist()
    {
        // Arrange
        _productRepository.GetById(Arg.Any<Guid>()).ReturnsNull();

        // Act
        var result = (NotFoundResult)await _sut.Get(new GetProductRequest(Guid.NewGuid()));

        // Assert
        result.StatusCode.Should().Be(404);
    }
}