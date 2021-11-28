using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Authorization;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly CastlesAndNestAppDbContext _context;

        public ProductsController(CastlesAndNestAppDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(
            [FromQuery] int relatedId, [FromQuery] int catId, [FromQuery] int subCatId, [FromQuery] int limit, [FromQuery] string query)
        {
            if (relatedId > 0)
            {
                return await GetRelatedProducts(relatedId, limit);
            }
            var prds = _context.Products
                .Where(prd => prd.Id == prd.Id);

            if (catId != 0)
            {
                prds = prds.Where(prd => prd.CategoryId == catId);
            }
            if (subCatId != 0)
            {
                prds = prds.Where(prd => prd.SubCategoryId == subCatId);
            }
            if (limit != 0)
            {
                prds = prds
                    .OrderByDescending(p => p.Featured).ThenByDescending(prd => prd.DateAvailable)
                    .Take(limit);
            }
            if (!string.IsNullOrWhiteSpace(query))
            {
                prds = prds.Where(book => book.Name.ToLower().Contains(query.ToLower()));
            }

            return await prds.OrderByDescending(p => p.Featured).ThenByDescending(prd => prd.DateAvailable)
                .AsNoTracking()
                .Select(prd => new Product()
                {
                    Images = new ProductImage[] { prd.Images.OrderBy(pi => pi.Id).FirstOrDefault() },
                    Id = prd.Id,
                    Price = prd.Price,
                    Name = prd.Name,
                    DateAvailable = prd.DateAvailable,
                    Featured = prd.Featured,
                    Exclude = prd.Exclude
                }).ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products
                .Include(p => p.Images)
                .Include(p => p.Category)
                .Include(p => p.SubCategory)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        private async Task<ActionResult<IEnumerable<Product>>> GetRelatedProducts(int id, int limit)
        {
            var products = await _context.Products
                .Where(p => p.Id == id)
                .Select(p => new { p.Id, p.CategoryId, p.SubCategoryId }).ToListAsync();
            var product = products.FirstOrDefault();

            if (product == null)
            {
                return Ok();
            }
            var relatedProducts = _context.Products
                .Where(p => p.Id != id && p.SubCategoryId == product.SubCategoryId)
                .OrderByDescending(p => p.Featured).ThenByDescending(p => p.DateAvailable)
                .Take(limit);
            if (relatedProducts.Count() < limit)
            {
                var relPids = relatedProducts.Select(p => p.Id);
                var catRelatedProducts = _context.Products
                    .Where(p => p.Id != id && !relPids.Contains(p.Id) && p.CategoryId == product.CategoryId)
                    .OrderByDescending(p => p.Featured).ThenByDescending(p => p.DateAvailable)
                    .Take(limit - relatedProducts.Count());
                relatedProducts = relatedProducts.Union(catRelatedProducts);
            }
            if (relatedProducts.Count() < limit)
            {
                var relPids = relatedProducts.Select(p => p.Id);
                var catRelatedProducts = _context.Products
                    .Where(p => p.Id != id && !relPids.Contains(p.Id))
                    .OrderByDescending(p => p.Featured).ThenByDescending(p => p.DateAvailable)
                    .Take(limit - relatedProducts.Count());
                relatedProducts = relatedProducts.Union(catRelatedProducts);
            }

            return await relatedProducts.AsNoTracking().Select(prd => new Product()
            {
                Images = new ProductImage[] { prd.Images.OrderBy(pi => pi.Id).FirstOrDefault() },
                Id = prd.Id,
                Price = prd.Price,
                Name = prd.Name,
                DateAvailable = prd.DateAvailable,
                Featured = prd.Featured,
                Exclude = prd.Exclude
            }).ToListAsync();
        }

        [HttpGet]
        [Route("quicksearch/{query}")]
        public async Task<ActionResult<IEnumerable<Product>>> Search(string query)
        {
            return await _context.Products.Where(book => book.Name.ToLower().Contains(query.ToLower()))
                .OrderByDescending(p => p.Featured).ThenByDescending(p => p.DateAvailable).AsNoTracking().ToListAsync();
        }
        // PUT: api/Products/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            var images = _context.ProductImages.Where(oi => oi.ProductId == id);
            var existingProductIds = images.Select(oi => oi.Id).ToList();
            var incomingProductIds = product.Images?.Select(oi => oi.Id).ToList();
            var newProductIds = incomingProductIds?.Except(existingProductIds);
            var toDeleteProductIds = incomingProductIds == null ? existingProductIds : existingProductIds.Except(incomingProductIds);

            foreach (ProductImage child in images)
            {
                if (toDeleteProductIds.Contains(child.Id))
                {
                    _context.Entry(child).State = EntityState.Deleted;
                }
            }
            if (product.Images != null)
            {
                foreach (var child in product.Images)
                {
                    if (newProductIds.Contains(child.Id))
                    {
                        _context.Entry(child).State = EntityState.Added;
                    }
                }
            }
            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
