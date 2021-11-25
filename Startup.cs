using Backend.Data;
using Backend.Models;
using Backend.Services;
using Backend.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
                options.EnableForHttps = true;
            });

            var allowedOrigins = Configuration["AllowOrigins"];
            var arrAllowedOrigins = allowedOrigins.Split(",", StringSplitOptions.RemoveEmptyEntries);

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.WithOrigins(arrAllowedOrigins));
            });
            services.AddDbContext<CastlesAndNestAppDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 7;
                opt.Password.RequireDigit = false;

                opt.User.RequireUniqueEmail = true;

                opt.Lockout.AllowedForNewUsers = true;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2);
                opt.Lockout.MaxFailedAccessAttempts = 3;
            }).AddEntityFrameworkStores<CastlesAndNestAppDbContext>()

                .AddDefaultTokenProviders();

            services.Configure<DataProtectionTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromHours(2));

            var jwtSettings = Configuration.GetSection("JwtSettings");
            services.AddAuthentication(opt =>
            {
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.IncludeErrorDetails = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = jwtSettings.GetSection("validIssuer").Value,
                    ValidAudience = jwtSettings.GetSection("validAudience").Value,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.GetSection("securityKey").Value))
                };
            });

            services.AddScoped<JwtHandler>();
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            var companyInfo = Configuration
                .GetSection("CompanyInformation")
                .Get<CompanyInformation>();
            services.AddSingleton(companyInfo);
            var emailConfig = Configuration
                .GetSection("MailSettings")
                .Get<MailSettings>();
            services.AddSingleton(emailConfig);
            services.AddScoped<IEmailService, EmailService>();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, CastlesAndNestAppDbContext dataContext)
        {
            app.UseResponseCompression();
            /* Clear Users, Roles and UserRoles. MAKE SURE THERE IS AT LEAST ONE ADMIN IN THE SEEDING
            dataContext.UserRoles.RemoveRange(dataContext.UserRoles.ToArray());
            dataContext.Users.RemoveRange(dataContext.Users.ToArray());
            dataContext.Roles.RemoveRange(dataContext.Roles.ToArray());
            dataContext.SaveChanges();
            */

            /* add users without needing a add-migration
            var adminRole = new IdentityRole
            {
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            };
            var customerRole = new IdentityRole
            {
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            };
            var adminRoleDB = dataContext.Roles.Add(adminRole);
            var custoRoleDB = dataContext.Roles.Add(customerRole);
            dataContext.SaveChanges();
            var adminOmair = dataContext.Users.Add(new User { Id = "hafeezomair@gmail.com", Email = "hafeezomair@gmail.com", NormalizedEmail = "hafeezomair@gmail.com", UserName = "hafeezomair", NormalizedUserName = "hafeezomair", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString() });
            var adminHashone = dataContext.Users.Add(new User { Id = "hashonecreations1@gmail.com", Email = "hashonecreations1@gmail.com", NormalizedEmail = "hashonecreations1@gmail.com", UserName = "hashonecreations1", NormalizedUserName = "hashonecreations1", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString() });
            var adminUbaid = dataContext.Users.Add(new User { Id = "ubaid1900@gmail.com", Email = "ubaid1900@gmail.com", NormalizedEmail = "ubaid1900@gmail.com", UserName = "ubaid1900", NormalizedUserName = "ubaid1900", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString() });
            var customerSome = dataContext.Users.Add(new User { Id = "customerSome@gmail.com", Email = "customerSome@gmail.com", NormalizedEmail = "customerSome@gmail.com", UserName = "customerSome", NormalizedUserName = "customerSome", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString() });
            dataContext.SaveChanges();

            dataContext.UserRoles.Add(new IdentityUserRole<string>() { RoleId = adminRoleDB.Entity.Id, UserId = adminOmair.Entity.Id });
            dataContext.UserRoles.Add(new IdentityUserRole<string>() { RoleId = adminRoleDB.Entity.Id, UserId = adminHashone.Entity.Id });
            dataContext.UserRoles.Add(new IdentityUserRole<string>() { RoleId = adminRoleDB.Entity.Id, UserId = adminUbaid.Entity.Id });
            dataContext.UserRoles.Add(new IdentityUserRole<string>() { RoleId = custoRoleDB.Entity.Id, UserId = customerSome.Entity.Id });
            dataContext.SaveChanges();
            */


            //dataContext.Database.EnsureDeleted();
            dataContext.Database.Migrate();
            var allowedOrigins = Configuration["AllowOrigins"];
            var arrAllowedOrigins = allowedOrigins.Split(",", StringSplitOptions.RemoveEmptyEntries);
            app.UseCors(options => options.WithOrigins(arrAllowedOrigins).AllowAnyHeader().AllowAnyMethod());

            // 1 year
            string cacheMaxAge = (31536000).ToString();
            app.UseStaticFiles(new StaticFileOptions
            {
                // NOTE: When this is done, the first image was loading fine in product detail,
                // all other images were blank, even the alt was not showing. Probable reason is 
                // that the first image might be successfully cached due to it being shown on the home page.

                //OnPrepareResponse = ctx =>
                //{
                //    // using Microsoft.AspNetCore.Http;
                //    ctx.Context.Response.Headers.Append(
                //         "Cache-Control", $"public, max-age={cacheMaxAge}");
                //},
                RequestPath = new PathString("/api")
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
