using Microsoft.AspNetCore.Mvc;
using PourDecisions.Data;
using Microsoft.EntityFrameworkCore;
using PourDecisions.Models;

namespace PourDecisions.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private PourDecisionDbContext _db;
        public OrderController(PourDecisionDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromForm] OrderEdit newOrder)
        {
            Order order = new Order()
            {
                ProductId = newOrder.ProductId.Id
            };

            _db.Orders.Add(order);
            await _db.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _db.Orders.ToListAsync();
            return Ok(orders);
        }
    }
}