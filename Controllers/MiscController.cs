using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MiscController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly CastlesAndNestAppDbContext _context;

        public MiscController(IConfiguration configuration, CastlesAndNestAppDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        // GET: api/<MiscController>
        [HttpGet]
        [Route("companyinfo")]
        [ResponseCache(Duration = 86400)]
        public CompanyInformation GetCompanyInfo()
        {
            var companyInfo = _configuration.GetSection("CompanyInformation").Get<CompanyInformation>();
            return companyInfo;
        }
        [HttpGet]
        [Route("allimages")]
        public async Task<ActionResult<IEnumerable<string>>> GetAllImagesAsync()
        {
            var temp = _context.ProductImages.Select(pi => pi.ImageUrl)
                .Union(_context.Categories.Select(t => t.ImageUrl))
                .Union(_context.SubCategories.Select(t => t.ImageUrl));

            return await temp.ToListAsync();
        }
    }
}
