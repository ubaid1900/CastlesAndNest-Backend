using Backend.Models;
using Backend.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
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
        private readonly IConfiguration configuration;

        public MiscController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // GET: api/<MiscController>
        [HttpGet]
        [Route("companyinfo")]
        [ResponseCache(Duration = 86400)]
        public CompanyInformation GetCompanyInfo()
        {
            var companyInfo = configuration.GetSection("CompanyInformation").Get<CompanyInformation>();
            return companyInfo;            
        }
    }
}
