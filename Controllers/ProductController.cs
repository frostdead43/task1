using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts() 
    {
        var products = new[]
        {
            new { Name = "Laptop", Price = 12000 },
            new { Name = "Table", Price = 550 },
            new { Name = "Phone", Price = 4400 }
        };
        Console.WriteLine(products);
        return Ok(products);
        
    }
}
