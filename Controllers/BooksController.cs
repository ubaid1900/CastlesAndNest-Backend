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

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly MyAppDbContext _context;

        public BooksController(MyAppDbContext context, ILogger<BooksController> logger)
        {
            _logger = logger;
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            #region TOOD: Cleaup
            //var books = _context.Books
            //    .Join(_context.Subjects, b => b.SubjectId, (s) => s.Id, (b, s) => new { Book = b, Subject = s })
            //    .Join(_context.Grades, bs => bs.Book.GradeId, (g) => g.Id, (bs, g) => new { bs.Book, bs.Subject, Grade = g }); 
            #endregion
            return await _context.Books.Include(b => b.Grade).Include(b => b.Subject).Include(b => b.Images).ToListAsync();
        }
        // GET: api/Books
        [HttpGet]
        [Route("quicksearch/{query}")]
        public async Task<ActionResult<IEnumerable<Book>>> SearchBooks(string query)
        {
            return await _context.Books.Include(book => book.Grade).Where(book => book.Description.ToLower().Contains(query.ToLower()))
                .ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _context.Books.Include(b => b.Grade).Include(b => b.Subject).Include(b => b.Author).Include(b => b.Images).SingleOrDefaultAsync(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            try
            {
                if (id != book.Id)
                {
                    return BadRequest();
                }
                var bookImages = _context.BookImages.Where(oi => oi.BookId == id);
                var existingBookIds = bookImages.Select(oi => oi.Id).ToList();
                var incomingBookIds = book.Images?.Select(oi => oi.Id).ToList();
                var newBookIds = incomingBookIds?.Except(existingBookIds);
                var toDeleteBookIds = incomingBookIds == null ? existingBookIds : existingBookIds.Except(incomingBookIds);

                foreach (BookImages child in bookImages)
                {
                    if (toDeleteBookIds.Contains(child.Id))
                    {
                        _context.Entry(child).State = EntityState.Deleted;
                    }
                }
                if (book.Images != null)
                {
                    foreach (var child in book.Images)
                    {
                        if (newBookIds.Contains(child.Id))
                        {
                            _context.Entry(child).State = EntityState.Added;
                        }
                    }
                }
                _context.Entry(book).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(id))
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
            catch (Exception ex)
            {

                throw;
            }
        }

        // POST: api/Books
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            try
            {
                _context.Books.Add(book);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetBook", new { id = book.Id }, book);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return book;
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
        private async Task<bool> BookExistsAsync(int id)
        {
            return await _context.Books.AnyAsync(e => e.Id == id);
        }
    }
}
