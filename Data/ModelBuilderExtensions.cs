using Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Backend.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
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
            modelBuilder.Entity<IdentityRole>().HasData(                
                adminRole, customerRole
            );
            var adminOmair = new User { Id = "hafeezomair@gmail.com", Email = "hafeezomair@gmail.com", NormalizedEmail = "hafeezomair@gmail.com", UserName = "hafeezomair", NormalizedUserName = "hafeezomair", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString() };
            var adminKhan = new User { Id = "mujahidkhan17@gmail.com", Email = "mujahidkhan17@gmail.com", NormalizedEmail = "mujahidkhan17@gmail.com", UserName = "mujahidkhan17", NormalizedUserName = "mujahidkhan17", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString() };
            var adminUbaid = new User { Id = "ubaid1900@gmail.com", Email = "ubaid1900@gmail.com", NormalizedEmail = "ubaid1900@gmail.com", UserName = "ubaid1900", NormalizedUserName = "ubaid1900", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString() };
            var customerSome = new User { Id = "customerSome@gmail.com", Email = "customerSome@gmail.com", NormalizedEmail = "customerSome@gmail.com", UserName = "customerSome", NormalizedUserName = "customerSome", EmailConfirmed = true, SecurityStamp = Guid.NewGuid().ToString() };
            modelBuilder.Entity<User>().HasData(
                adminOmair, adminKhan, adminUbaid, customerSome
            );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = adminRole.Id, UserId = adminOmair.Id },
                new IdentityUserRole<string> { RoleId = adminRole.Id, UserId = adminKhan.Id },
                new IdentityUserRole<string> { RoleId = adminRole.Id, UserId = adminUbaid.Id },
                new IdentityUserRole<string> { RoleId = customerRole.Id, UserId = customerSome.Id }
            );
        }
    }
}