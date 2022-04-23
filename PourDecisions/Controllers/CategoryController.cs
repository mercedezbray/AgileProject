using Microsoft.AspNetCore.Mvc;
using PourDecisions.Data;
using PourDecisions.Models;
using Microsoft.EntityFrameworkCore;

namespace PourDecisions.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private PourDecisionDbContext _db;
        public CategoryController(PourDecisionDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromForm] CategoryEdit newCategory)
        {
            Category category = new Category()
            {
                AlcType = newCategory.AlcType,
            };

            _db.Categories.Add(category);
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