using Backend.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly CastlesAndNestAppDbContext context;
        private readonly ILogger<NotificationsController> logger;

        public NotificationsController(CastlesAndNestAppDbContext context, ILogger<NotificationsController> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        // GET: api/<V>
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<bool> Get()
        {
            return false;
        }
    }
}
