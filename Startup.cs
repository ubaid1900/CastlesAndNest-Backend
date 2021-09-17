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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
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
            var allowedOrigins = Configuration["AllowOrigins"];
            var arrAllowedOrigins = allowedOrigins.Split(",", StringSplitOptions.RemoveEmptyEntries);

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.WithOrigins(arrAllowedOrigins));
            });
            services.AddDbContext<BooksAppDbContext>(options =>
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
            }).AddEntityFrameworkStores<BooksAppDbContext>()

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
            services.AddControllers().AddNewtonsoftJson();
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
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, BooksAppDbContext dataContext)
        {
            //foreach (var item in dataContext.Orders)
            //{
            //    dataContext.Entry(item).State = EntityState.Deleted;
            //}
            //dataContext.SaveChanges();
            //dataContext.Database.EnsureDeleted();
            dataContext.Database.Migrate();
            var allowedOrigins = Configuration["AllowOrigins"];
            var arrAllowedOrigins = allowedOrigins.Split(",", StringSplitOptions.RemoveEmptyEntries);
            app.UseCors(options => options.WithOrigins(arrAllowedOrigins).AllowAnyHeader().AllowAnyMethod());

            app.UseStaticFiles(new StaticFileOptions()
            {
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
