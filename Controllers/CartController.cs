using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {

        private readonly CastlesAndNestAppDbContext _context;
        private readonly ILogger<CartController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CartController(CastlesAndNestAppDbContext context, ILogger<CartController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
        // GET: api/<CartController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CartController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CartController>
        [HttpPost]
        // TODO: make it async
        public ActionResult<Cart> Post([FromBody] ICollection<CartItem> items)
        {
            var itemIds = items.Select(item => item.ItemId);
            var books = _context.Products.Include(book => book.Images)
                .Where(book => itemIds.Contains(book.Id))
                .ToList();
            var cart = new Cart
            {
                Items = new List<CartItem>()
            };
            decimal runningTotal = decimal.Zero;
            decimal runningSavings = decimal.Zero;
            foreach (var item in items)
            {
                CartItem cartItem = new CartItem() { ItemId = item.ItemId, OrderQuantity = item.OrderQuantity  } ;

                var bookEntry = books.First(book => book.Id == item.ItemId);
                cartItem.Description = bookEntry.Description;
                cartItem.ImageUrl = bookEntry.Images.Count > 0 ? bookEntry.Images.First().ImageUrl : string.Empty;
                cartItem.Price = bookEntry.Price;
                runningTotal += bookEntry.Price * item.OrderQuantity;

                cart.Items.Add(cartItem);
            }
            cart.Total = runningTotal;
            cart.Savings = runningSavings;
            return Ok(cart);
        }

        // PUT api/<CartController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CartController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
