using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PourDecisions.Data;
using PourDecisions.Models;

namespace PourDecisions.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private PourDecisionDbContext _db;
        public ProductController(PourDecisionDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromForm] ProductEdit newProduct)
        {
            Product product = new Product()
            {
                Name = newProduct.Name,
                Price = newProduct.Price,
            };

            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _db.Products.ToListAsync();
            return Ok(products);
        }
    }
}