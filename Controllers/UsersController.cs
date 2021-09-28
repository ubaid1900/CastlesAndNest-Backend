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
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Backend.Utilities;
using Microsoft.AspNetCore.Identity;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly MyAppDbContext _context;
        private readonly ILogger<UsersController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<User> _userManager;

        public UsersController(MyAppDbContext context, ILogger<UsersController> logger, IWebHostEnvironment webHostEnvironment, UserManager<User> userManager)
        {
            _context = context;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _userManager = userManager;
        }
        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.OrderBy(u => u.Email).ToListAsync();
        }
        // GET: api/adminusers
        [Authorize(Roles = "Administrator")]
        [Route("adminusers")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAdminUsers()
        {
            var v = await _userManager.GetUsersInRoleAsync("ADMINISTRATOR");
            //var l = v.AsEnumerable();
            //var t = Task.FromResult(l);
            return Ok(v);
        }
        [HttpPut("adminusers/{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UpdateAdminRole(string id, object val)
        {
            if (!UserExists(id))
            {
                return NotFound();
            }
            var bVal = (bool)val;
            var dbEntry = await _context.Users.FindAsync(id);
            if (bVal)
            {
                await _userManager.AddToRoleAsync(dbEntry, "ADMINISTRATOR");
            }
            else
            {
                await _userManager.RemoveFromRoleAsync(dbEntry, "ADMINISTRATOR");
            }
            return NoContent();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(string id)
        {
            var user = await _context.Users.Include(user => user.Addresses).SingleOrDefaultAsync(user => user.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(string id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }
            if (!UserExists(id))
            {
                return NotFound();
            }
            var dbEntry = await _context.Users.Include(user => user.Addresses).SingleAsync(user => user.Id == id);
            dbEntry.Firstname = user.Firstname;
            dbEntry.Lastname = user.Lastname;
            dbEntry.PhoneNumber = user.PhoneNumber;

            try
            {
                foreach (var item in user.Addresses)
                {
                    if (item.Id == 0)
                    {
                        dbEntry.Addresses.Add(item);
                    }
                    else
                    {
                        var addEntry = dbEntry.Addresses.Find(ad => ad.Id == item.Id);
                        addEntry.Streetnumber = item.Streetnumber;
                        addEntry.Streetname = item.Streetname;
                        addEntry.City = item.City;
                        addEntry.State = item.State;
                        addEntry.Zip = item.Zip;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException dex)
            {
                if (!UserExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserExists(user.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
