using los_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace los_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IosDbContext _context;

        public ProductController(IosDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            var result = _context.Products.ToList();

            return Ok(result);
        }
    }
}
