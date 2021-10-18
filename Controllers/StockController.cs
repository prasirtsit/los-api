using los_api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace los_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IosDbContext _context;

        public StockController(IosDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStocks()
        {
            var result = _context.Stocks.ToList();

            return Ok(result);
        }

        [HttpGet("{productId}")]
        public IActionResult GetStockByProductId(string productId)
        {
            var result = _context.Stocks.SingleOrDefault(s => s.ProductId == productId);

            if (result == null)
            {
                return NotFound("Data does not exist");
            }
            return Ok(result);
        }
    }
}
