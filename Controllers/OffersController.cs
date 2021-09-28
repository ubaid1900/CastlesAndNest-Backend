using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Models;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private readonly MyAppDbContext _context;
        private readonly ILogger<OffersController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public OffersController(MyAppDbContext context, ILogger<OffersController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: api/Offers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Offer>>> GetOffers()
        {
            return await _context.Offers.ToListAsync();
        }

        // GET: api/Offers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Offer>> GetOffer(int id)
        {
            var step = _context.Offers.Include(o => o.OfferItems).ThenInclude(oi => oi.Book);
            step.ThenInclude(book => book.Grade);
            var offer = await _context.Offers
                .Include(o => o.OfferItems).ThenInclude(oi => oi.Book).ThenInclude(book => book.Grade)
                .Include(o => o.OfferItems).ThenInclude(oi => oi.Book).ThenInclude(book => book.Subject)
                .SingleOrDefaultAsync(o => o.Id == id);

            if (offer == null)
            {
                return NotFound();
            }

            return offer;
        }

        // PUT: api/Offers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOffer(int id, Offer offer)
        {
            if (id != offer.Id)
            {
                return BadRequest();
            }

            try
            {
                var offerItems = _context.OfferItems.Where(oi => oi.OfferId == id);
                var existingBookIds = offerItems.Select(oi => oi.BookId).ToList();
                var incomingBookIds = offer.OfferItems.Select(oi => oi.BookId).ToList();
                var newBookIds = incomingBookIds.Except(existingBookIds);
                var toDeleteBookIds = existingBookIds.Except(incomingBookIds);


                foreach (OfferItem child in offerItems)
                {
                    if (toDeleteBookIds.Contains(child.BookId))
                    {
                        _context.Entry(child).State = EntityState.Deleted;
                    }
                }
                foreach (OfferItem child in offer.OfferItems)
                {
                    if (newBookIds.Contains(child.BookId))
                    {
                        _context.Entry(child).State = EntityState.Added;
                    }
                }
                _context.Entry(offer).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfferExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {

            }

            return NoContent();
        }

        // POST: api/Offers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Offer>> PostOffer(Offer offer)
        {
            _context.Offers.Add(offer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOffer", new { id = offer.Id }, offer);
        }

        // DELETE: api/Offers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Offer>> DeleteOffer(int id)
        {
            var offer = await _context.Offers.FindAsync(id);
            if (offer == null)
            {
                return NotFound();
            }

            _context.Offers.Remove(offer);
            await _context.SaveChangesAsync();

            return offer;
        }

        private bool OfferExists(int id)
        {
            return _context.Offers.Any(e => e.Id == id);
        }
    }
}
