
using Microsoft.AspNetCore.Mvc;

namespace OneReview.Controllers;

[ApiController]
[Route("[controller]")]
public class Products : ControllerBase
{



    [HttpPost]

    public IActionResult Create(CreateProductRequest request)
    {
        return CreatedAtAction(
            //method, paramaters, resource  
            nameof(Get),
            new { ProductId = Guid.NewGuid() },
            value: request
        );
    }

    [HttpGet("{ProductId:guid}")]

    public IActionResult Get(Guid ProductId)
    {
        return Ok();
    }

    public record CreateProductRequest(string Name, string Category, string Subcategory)
    {

    }

}
