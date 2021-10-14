using los_api.Models;
using los_api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace los_api.Controllers
{
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly StockService stockService;

        public StockController()
        {
            stockService = new StockService();
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public ActionResult<Stock> GetById(string id)
        {
            var result = stockService.GetById(id);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
