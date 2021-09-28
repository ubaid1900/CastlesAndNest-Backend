using Backend.Data;
using Backend.Models;
using Backend.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly MyAppDbContext _context;
        private readonly ILogger<AccountsController> _logger;
        private readonly JwtHandler _jwtHandler;
        private readonly UserManager<User> _userManager;

        public AccountsController(UserManager<User> userManager, JwtHandler jwtHandler, MyAppDbContext context, ILogger<AccountsController> logger)
        {
            _userManager = userManager;
            _jwtHandler = jwtHandler;
            _context = context;
            _logger = logger;
        }

        [HttpPost("ExternalLogin")]
        public async Task<IActionResult> ExternalLogin([FromBody] ExternalAuthDto externalAuth)
        {
            try
            {
                User payload;
                if (externalAuth.Provider.ToLower() == "facebook")
                {
                    //check token
                    var httpClient = new HttpClient { BaseAddress = new Uri("https://graph.facebook.com/v2.9/") };
                    var response = await httpClient.GetAsync($"me?access_token={externalAuth.AuthToken}&fields=id,name,email,first_name,last_name,locale,picture");
                    if (!response.IsSuccessStatusCode) return BadRequest();
                    var result = await response.Content.ReadAsStringAsync();

                    dynamic userObj = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(result);
                    
                    payload = JsonConvert.DeserializeObject<User>(result);
                    payload.PhotoUrl = userObj["picture"]["data"]["url"];
                    payload.Firstname = userObj["first_name"];
                    payload.Lastname = userObj["last_name"];
                }
                else if (externalAuth.Provider.ToLower() == "google")
                {
                    var gPayload = await _jwtHandler.VerifyGoogleToken(externalAuth);

                    if (gPayload == null)
                        return BadRequest("Invalid External Authentication.");

                    payload = new User() { Id = gPayload.Email, Email = gPayload.Email, UserName = gPayload.Email,
                    Firstname = gPayload.GivenName, Lastname = gPayload.FamilyName};
                }
                else
                {
                    throw new ApplicationException("Provider not configured yet!");
                }

                var info = new UserLoginInfo(externalAuth.Provider, payload.Email, externalAuth.Provider);
                //register if required
                var user = await _userManager.FindByLoginAsync(info.LoginProvider, info.ProviderKey);
                if (user == null)
                {
                    user = await _userManager.FindByEmailAsync(payload.Email);

                    if (user == null)
                    {
                        user = new User { Id = payload.Email, Email = payload.Email, UserName = payload.Email,
                        Firstname = payload.Firstname, Lastname = payload.Lastname};
                        await _userManager.CreateAsync(user);

                        //prepare and send an email for the email confirmation
                        await _userManager.AddToRoleAsync(user, "Customer");
                        await _userManager.AddLoginAsync(user, info);
                    }
                    else
                    {
                        user.SecurityStamp = Guid.NewGuid().ToString();
                        await _userManager.AddLoginAsync(user, info);
                    }
                }

                //send bearer token
                var token = await _jwtHandler.GenerateToken(user);
                return Ok(new AuthResponseDto { Token = token, IsAuthSuccessful = true });

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
