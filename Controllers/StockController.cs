using los_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> GetStocks()
        {
            var result = await _context.Stocks.ToListAsync();

            return Ok(result);
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetStockByProductId(string productId)
        {
            var result = await _context.Stocks.SingleOrDefaultAsync(s => s.ProductId == productId);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
