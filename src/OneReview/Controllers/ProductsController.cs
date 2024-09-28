
using Microsoft.AspNetCore.Mvc;

using OneReview.Domain;
using OneReview.Services;

namespace OneReview.Controllers;

[ApiController]
[Route("[controller]")]
public class Products(ProductService productService) : ControllerBase
{

    private readonly ProductService _productService = productService;

    [HttpPost]

    public IActionResult Create(CreateProductRequest request)
    {

        var product = request.ToDomain();
        _productService.Create(product);

        return CreatedAtAction(
            //method, paramaters, resource  
            nameof(Get),
            new { ProductId = Guid.NewGuid() },
            value: ProductResponse.FromDomain(product)
        );
    }


    [HttpGet("{ProductId:guid}")]

    public IActionResult Get(Guid productId)
    {
        var product = _productService.Get(productId);

        return product is null ? NotFound("Product not found") : Ok(ProductResponse.FromDomain(product));
    }

    public record CreateProductRequest(string Name, string Category, string Subcategory)
    {
        public Product ToDomain()
        {
            return new Product
            {
                Name = Name,
                Category = Category,
                Subcategory = Subcategory
            };
        }
    };

    public record ProductResponse(Guid Id, string Name, string Category, string Subcategory)
    {
        public static ProductResponse FromDomain(Product product)
        {
            return new ProductResponse(
                product.Id,
                product.Name,
                product.Category,
                product.Subcategory
           );
        }
    };


}
