using Backend.Data;
using Backend.Models;
using Backend.Services;
using Backend.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly BooksAppDbContext context;
        private readonly ILogger<OrdersController> logger;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IEmailService emailService;
        private readonly IConfiguration configuration;

        public OrdersController(BooksAppDbContext context, ILogger<OrdersController> logger, IWebHostEnvironment webHostEnvironment
            , IEmailService emailService, IConfiguration configuration)
        {
            this.context = context;
            this.logger = logger;
            this.webHostEnvironment = webHostEnvironment;
            this.emailService = emailService;
            this.configuration = configuration;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders(string filter)
        {
            var query = context.Orders;

            var orderFilter = JsonConvert.DeserializeObject<OrderFilter>(filter);
            var filterQuery = query.Where(o => 1 == 1);

            if (orderFilter != null)
            {
                if (orderFilter.DateRange != null)
                {
                    if (orderFilter.DateRange.Start != null)
                    {
                        filterQuery = filterQuery = query.Where(o => o.Date >= orderFilter.DateRange.Start);
                    }
                    if (orderFilter.DateRange.End != null)
                    {
                        filterQuery = filterQuery = filterQuery.Where(o => o.Date <= orderFilter.DateRange.End);
                    }
                }
                if (!string.IsNullOrWhiteSpace(orderFilter.UserId) && orderFilter.UserId.ToLower() != "all")
                {
                    filterQuery = filterQuery.Where(o => o.UserId == orderFilter.UserId);
                }
            }

            if (HttpContext.User.IsInRole("Administrator"))
            {
                return await filterQuery
                    .OrderByDescending(o => o.Date)
                    .Include(o => o.BookItems).ThenInclude(bi => bi.Book)
                    .Include(o => o.OfferItems).ThenInclude(oi => oi.Offer).ThenInclude(offer => offer.OfferItems).ThenInclude(oi => oi.Book)
                    .ToListAsync();
            }
            else
            {
                filterQuery = filterQuery.Where(o => o.UserId == User.Identity.Name);
                return await filterQuery
                    .OrderByDescending(o => o.Date)
                    .Include(o => o.BookItems).ThenInclude(bi => bi.Book)
                    .Include(o => o.OfferItems).ThenInclude(oi => oi.Offer).ThenInclude(offer => offer.OfferItems).ThenInclude(oi => oi.Book)
                    .ToListAsync();
            }
        }
        public class OrderFilter
        {
            public string UserId { get; set; }
            public DateRange DateRange { get; set; }
        }
        public class DateRange
        {
            public DateTime? Start { get; set; }
            public DateTime? End { get; set; }
        }
        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var query = context.Orders
                .Include(o => o.Payment)
                .Include(o => o.BookItems).ThenInclude(bi => bi.Book)
                .Include(o => o.OfferItems).ThenInclude(oi => oi.Offer).ThenInclude(offer => offer.OfferItems).ThenInclude(oi => oi.Book)
                .AsNoTracking();

            var order = await query.FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            if (!HttpContext.User.IsInRole("Administrator"))
            {
                if (User.Identity.Name != order.UserId)
                {
                    return Unauthorized("You do not have access to this order.");
                }
                // mask card number
                order.Payment.CardNumber = $"XXXXXXXXXXXX {order.Payment.CardNumber.Substring(order.Payment.CardNumber.Length - 4, 4)}";
                // do not send cvv number
                order.Payment.CVV = string.Empty;
            }
            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            context.Entry(order).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            #region Validations
            var user = await context.Users.Include(u => u.Addresses).FirstOrDefaultAsync(u => u.Id == HttpContext.User.Identity.Name);
            if (user == null)
            {
                return BadRequest("Invalid user");
            }

            if (!user.Addresses.Any(address => address.Id == order.BillingAddressId))
            {
                return BadRequest("Billing Address does not exist");
            }
            if (!user.Addresses.Any(address => address.Id == order.ShippingAddressId))
            {
                return BadRequest("Shipping Address does not exist");
            }
            #endregion
            
            #region Fill Addresses
            var billingAddress = await context.Addresses.FindAsync(order.BillingAddressId);
            order.BillingAddressStreetnumber = billingAddress.Streetnumber;
            order.BillingAddressStreetname = billingAddress.Streetname;
            order.BillingAddressCity = billingAddress.City;
            order.BillingAddressState = billingAddress.State;
            order.BillingAddressZip = billingAddress.Zip;
            if (order.BillingAddressId == order.ShippingAddressId)
            {
                order.ShippingAddressStreetnumber = billingAddress.Streetnumber;
                order.ShippingAddressStreetname = billingAddress.Streetname;
                order.ShippingAddressCity = billingAddress.City;
                order.ShippingAddressState = billingAddress.State;
                order.ShippingAddressZip = billingAddress.Zip;
            }
            else
            {
                var shippingAddress = await context.Addresses.FindAsync(order.ShippingAddressId);
                order.ShippingAddressStreetnumber = shippingAddress.Streetnumber;
                order.ShippingAddressStreetname = shippingAddress.Streetname;
                order.ShippingAddressCity = shippingAddress.City;
                order.ShippingAddressState = shippingAddress.State;
                order.ShippingAddressZip = shippingAddress.Zip;
            }
            #endregion
            order.BookItems = new List<OrderBookItem>();
            order.OfferItems = new List<OrderOfferItem>();
            Dictionary<int, int> booksQuantitiesOrdered = new Dictionary<int, int>();
            foreach (var item in order.Items)
            {
                if (item.ItemType == CartItemType.Book)
                {
                    var book = await context.Books.FindAsync(item.ItemId);
                    order.BookItems.Add(new OrderBookItem()
                    {
                        BookId = item.ItemId,
                        Price = book.Price,
                        Quantity = item.Quantity
                    });
                    booksQuantitiesOrdered[book.Id] = book.AvailableQuantity - item.Quantity;
                    book.AvailableQuantity = booksQuantitiesOrdered[book.Id];
                }
                if (item.ItemType == CartItemType.Offer)
                {
                    var offer = await context.Offers.Include(o => o.OfferItems).ThenInclude(oi => oi.Book)
                        .FirstAsync(o => o.Id == item.ItemId);
                    order.OfferItems.Add(new OrderOfferItem()
                    {
                        OfferId = item.ItemId,
                        DiscountPercentage = offer.DiscountPercentage,
                        Quantity = item.Quantity,
                        OfferDetails = JsonConvert.SerializeObject(offer.OfferItems.Select(oi => new { oi.Book.Id, oi.Book.Price }))
                    });
                    foreach (var oItem in offer.OfferItems)
                    {
                        var book = oItem.Book;
                        booksQuantitiesOrdered[book.Id] = book.AvailableQuantity - item.Quantity;
                        book.AvailableQuantity = booksQuantitiesOrdered[book.Id];
                    }
                }
            }
            context.Orders.Add(order);
            await context.SaveChangesAsync();

            PrepareOrderAndSendEmail(order);

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        private async void PrepareOrderAndSendEmail(Order order)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<h1>Hello { order.Firstname } {order.Lastname},</h1>");
            sb.Append($"<h2>Order Summary for Order # { order.Id} </h2>");
            sb.Append($"<div>{BuildBooks(order.BookItems)}</div>");
            sb.Append($"<div>{BuildItemList(order.OfferItems)}</div>");
            sb.Append($"<h3>Subtotal: {order.Subtotal:c2} " +
                $"Shipping & Handling: {order.ShippingCost:c2} " +
                $"Total: {order.Subtotal + order.ShippingCost:c2} billed to {order.BillingAddressStreetnumber} " +
                $"{order.BillingAddressStreetname} {order.BillingAddressCity} {order.BillingAddressState} " +
                $"{order.BillingAddressZip} </h3>");
            sb.Append($"<h3>Your order will be shipped to {order.ShippingAddressStreetnumber} " +
                $"{order.ShippingAddressStreetname} {order.ShippingAddressCity} {order.ShippingAddressState} " +
                $"{order.ShippingAddressZip} </h3>");
            var companyInfo = configuration.GetSection("CompanyInformation").Get<CompanyInformation>();
            sb.Append($"<div>For any questions or concerns, contact us at: {companyInfo.Email} {companyInfo.Phonenumber} </div>");
            await emailService.SendAsync(order.UserId, companyInfo.Email,
                $"Your { companyInfo.Name } order of {order.Items.Count} item(s)", sb.ToString());
        }

        private string BuildItemList(List<OrderOfferItem> offers)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var offer in offers)
            {
                StringBuilder sbItems = new StringBuilder();
                decimal runningTotal = 0;
                foreach (var item in offer.Offer.OfferItems)
                {
                    runningTotal += item.Book.Price;
                    sbItems.Append($"<li><span>{item.Book.Description}</span> @ <span>{item.Book.Price:c2}</span></li>");
                }
                sb.Append($"<h3>Offer # { offer.Offer.Description} </h3>");
                sb.Append($"<div>Price after {offer.DiscountPercentage}% discount: {(runningTotal - (runningTotal * offer.DiscountPercentage / 100)) * offer.Quantity:c2}</div>");
                sb.Append("<h3>Books in offer: </h3>");
                sb.Append($"<ol>{sbItems}</ol>");
            }

            return $"<ul>{sb}</ul>";
        }

        private string BuildBooks(IEnumerable<OrderBookItem> books)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var book in books)
            {
                sb.Append($"<li><span>{book.Book.Description}</span> @ <span>{book.Price:c2} * {book.Quantity} = {book.Price * book.Quantity:c2}</span></li>");
            }
            return $"<ul>{sb}</ul>";
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            var order = await context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            context.Orders.Remove(order);
            await context.SaveChangesAsync();

            return order;
        }

        private bool OrderExists(int id)
        {
            return context.Orders.Any(e => e.Id == id);
        }

    }
}
