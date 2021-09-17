using Backend.Data;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> logger;
        private readonly IEmailService emailService;
        private readonly IConfiguration configuration;
        private readonly BooksAppDbContext context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IEmailService emailService
            , IConfiguration configuration, BooksAppDbContext context)
        {
            this.logger = logger;
            this.emailService = emailService;
            this.configuration = configuration;
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return PrepareOrderAndSendEmail(id);
        }


        private string PrepareOrderAndSendEmail(int orderId)
        {
            var query = context.Orders
                   .Include(o => o.Payment)
                   .Include(o => o.BookItems).ThenInclude(bi => bi.Book)
                   .Include(o => o.OfferItems).ThenInclude(oi => oi.Offer).ThenInclude(offer => offer.OfferItems).ThenInclude(oi => oi.Book)
                   .AsNoTracking();

            var order = query.FirstOrDefault(o => o.Id == orderId);

            if (order == null)
            {
                return "Order not found";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append($"<h1 style='text-align:center; border-top:6px solid #03a452; padding-top:10px;'>Hello { order.Firstname } {order.Lastname},</h1>");
            sb.Append($"<h2 style='text-align:center; background:#03a452; padding:15px; color:#fff;'>Order Summary for Order # { order.Id} </h2>");
            sb.Append($"<div style='line-height:50px; background:#d3e5dc; margin:5px 0; text-align:center; list-style-type:none; font-size: 20px;'>{BuildBooks(order.BookItems)}</div>");
            sb.Append($"<div style='text-align:center; background:#03a452; padding:15px; color:#fff; font-size: 29px;'>{BuildItemList(order.OfferItems)}</div>");
            sb.Append($"<h3 style='text-align:center; color:red;'>Subtotal: {order.Subtotal:c2} " +
                $"Shipping & Handling: {order.ShippingCost:c2} " +
                $"Total: {order.Subtotal + order.ShippingCost:c2} billed to {order.BillingAddressStreetnumber} " +
                $"{order.BillingAddressStreetname} {order.BillingAddressCity} {order.BillingAddressState} " +
                $"{order.BillingAddressZip} </h3>");
            sb.Append($"<h3 style='text-align:center;color: #017b3d;'>Your order will be shipped to {order.ShippingAddressStreetnumber} " +
                $"{order.ShippingAddressStreetname} {order.ShippingAddressCity} {order.ShippingAddressState} " +
                $"{order.ShippingAddressZip} </h3>");
            var companyInfo = configuration.GetSection("CompanyInformation").Get<CompanyInformation>();
            sb.Append($"<div style='text-align:center; line-height:25px; padding-bottom:20px;'>For any questions or concerns, contact us at: {companyInfo.Email} {companyInfo.Phonenumber} </div>");

            return sb.ToString();
            //await emailService.SendAsync(order.UserId, companyInfo.Email,
            //    $"Your { companyInfo.Name } order of {order.Items.Count} item(s)", sb.ToString());
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
                    sbItems.Append($"<li style='line-height:50px; background:#d3e5dc; margin:5px 0; text-align:center; list-style-type:none; font-size: 20px;'><span>{item.Book.Description}</span> @ <span>{item.Book.Price:c2}</span></li>");
                }
                sb.Append($"<h3 style='text-align:center; background:#03a452; padding:15px; color:#fff; font-size: 29px;'>Offer # { offer.Offer.Description} </h3>");
                sb.Append($"<div style='text-align:center; font-size:29px; color:red;'>Price after {offer.DiscountPercentage}% discount: {(runningTotal - (runningTotal * offer.DiscountPercentage / 100)) * offer.Quantity:c2}</div>");
                sb.Append("<h3 style='text-align:center; font-size:23px;'>Books in offer: </h3>");
                sb.Append($"<ol style='text-align:center; list-style-type:none; font-size:20px;'>{sbItems}</ol>");
            }

            return $"<ul>{sb}</ul>";
        }

        private string BuildBooks(IEnumerable<OrderBookItem> books)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var book in books)
            {
                sb.Append($"<li style='line-height:50px; background:#d3e5dc; margin:5px 0; text-align:center; list-style-type:none; font-size: 20px;'><span>{book.Book.Description}</span> @ <span>{book.Price:c2} * {book.Quantity} = {book.Price * book.Quantity:c2}</span></li>");

            }
            return $"<ul>{sb}</ul>";
        }
    }
}
