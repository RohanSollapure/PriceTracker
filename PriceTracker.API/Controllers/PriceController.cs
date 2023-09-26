using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PriceTracker.API.Data;
using PriceTracker.API.Models.Domain;

namespace PriceTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {

        private readonly DatabaseDbContext dbContext;
     
        public PriceController(DatabaseDbContext dbContext)
        {
            this.dbContext = dbContext;
       
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var prices = dbContext.Prices.ToList();

            return Ok(prices);
        }

        [HttpGet("{Name}/{Date}")]

        // [Route("{VegetableName=String, Date=DateTime}")]

        public IActionResult GetByNameAndDate([FromRoute] string Name, [FromRoute] DateTime Date)
        {
            var prices = dbContext.Prices.FirstOrDefault(v => v.Name == Name && v.Date == Date);

            if (prices == null)
            {
                return NotFound();
            }

            return Ok(prices);
        }

        [HttpPost]
        public IActionResult CreatePrice([FromBody] Prices price)
        {
            if (price == null)
            {
                return BadRequest("Invalid price data.");
            }
            dbContext.Prices.Add(price);
            dbContext.SaveChanges();
            return CreatedAtAction(nameof(GetByNameAndDate), new { id = price.ID }, price);
        }


    }
}
