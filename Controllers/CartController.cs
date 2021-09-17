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

        private readonly BooksAppDbContext _context;
        private readonly ILogger<CartController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CartController(BooksAppDbContext context, ILogger<CartController> logger, IWebHostEnvironment webHostEnvironment)
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
        public ActionResult<Cart> Post([FromBody] ICollection<CartItemBase> items)
        {
            var bookItemIds = items.Where(item => item.ItemType == CartItemType.Book).Select(item => item.ItemId);
            var offerItemIds = items.Where(item => item.ItemType == CartItemType.Offer).Select(item => item.ItemId);
            var books = _context.Books.Include(book => book.Images)
                .Where(book => bookItemIds.Contains(book.Id))
                .ToList();
            var offers = _context.Offers.Include(offer => offer.OfferItems).ThenInclude(oi => oi.Book)
                .Where(offer => offerItemIds.Contains(offer.Id)).ToList();
            var cart = new Cart
            {
                Items = new List<CartItem>()
            };
            decimal runningTotal = decimal.Zero;
            decimal runningSavings = decimal.Zero;
            foreach (var item in items)
            {
                CartItem cartItem = new CartItem(item);
                if (item.ItemType == CartItemType.Book)
                {
                    var bookEntry = books.First(book => book.Id == item.ItemId);
                    cartItem.Description = bookEntry.Description;
                    cartItem.ImageUrl = bookEntry.Images.Count > 0 ? bookEntry.Images.First().ImageUrl : string.Empty;
                    cartItem.BookPrice = bookEntry.Price;
                    runningTotal += bookEntry.Price * item.Quantity;
                    cartItem.AvailableQuantity = bookEntry.AvailableQuantity;
                }
                if (item.ItemType == CartItemType.Offer)
                {
                    var offerEntry = offers.First(offer => offer.Id == item.ItemId);
                    cartItem.Description = offerEntry.Description;
                    cartItem.ImageUrl = offerEntry.ImageUrl;
                    cartItem.OfferPricingDetails = CalculateOfferPricingDetails(offerEntry);
                    runningTotal += cartItem.OfferPricingDetails.PriceAfterDiscount * item.Quantity;
                    runningSavings += cartItem.OfferPricingDetails.SavingsAmount * item.Quantity;
                    cartItem.AvailableQuantity = offerEntry.OfferItems.Min(oi => oi.Book.AvailableQuantity);
                }
                cart.Items.Add(cartItem);
            }
            cart.Total = runningTotal;
            cart.Savings = runningSavings;
            return Ok(cart);
        }

        private OfferPricingDetails CalculateOfferPricingDetails(Offer offer)
        {
            OfferPricingDetails opd = new OfferPricingDetails();

            opd.PriceBeforeDiscount = offer.OfferItems.Sum(oi => oi.Book.Price);
            opd.PriceAfterDiscount = opd.PriceBeforeDiscount - opd.PriceBeforeDiscount * offer.DiscountPercentage / 100;
            opd.SavingsAmount = opd.PriceBeforeDiscount - opd.PriceAfterDiscount;
            return opd;
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
