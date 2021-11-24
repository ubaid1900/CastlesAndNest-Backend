using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class readd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ac508727-888c-4150-9039-9c1419743a5e", "2109a47a-1d9e-4f81-984a-9444641a862f", "Administrator", "ADMINISTRATOR" },
                    { "764fd50f-7e1e-4794-b977-a92bc731906c", "59fb8580-62ee-4d05-a886-6e8016d85da8", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AuthToken", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "IdToken", "Lastname", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "Provider", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", 0, null, "b5e887b5-91f6-4092-861e-ff19bcda3df4", "hafeezomair@gmail.com", true, null, null, null, false, null, null, "hafeezomair@gmail.com", "hafeezomair", null, null, false, null, null, "f8213d82-a746-4cac-989a-67550f286305", false, "hafeezomair" },
                    { "ubaid1900@gmail.com", 0, null, "1f95c349-726f-4719-b422-d2ca42dc1a64", "ubaid1900@gmail.com", true, null, null, null, false, null, null, "ubaid1900@gmail.com", "ubaid1900", null, null, false, null, null, "c7a85dee-b9bb-41d2-a8b3-86a2abeb5884", false, "ubaid1900" },
                    { "customerSome@gmail.com", 0, null, "b7a2be20-44b3-4b39-af82-8b95d1f754c9", "customerSome@gmail.com", true, null, null, null, false, null, null, "customerSome@gmail.com", "customerSome", null, null, false, null, null, "53a2f77a-21c2-47fe-90b0-4e0f13be9be4", false, "customerSome" },
                    { "hashonecreations1@gmail.com", 0, null, "17b59af3-45ee-474d-b76a-46e6ba17d84b", "hashonecreations1@gmail.com", true, null, null, null, false, null, null, "hashonecreations1@gmail.com", "hashonecreations1", null, null, false, null, null, "3227384f-b8ec-4fd4-8487-cd470fe425be", false, "hashonecreations1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "ac508727-888c-4150-9039-9c1419743a5e" },
                    { "ubaid1900@gmail.com", "ac508727-888c-4150-9039-9c1419743a5e" },
                    { "hashonecreations1@gmail.com", "ac508727-888c-4150-9039-9c1419743a5e" },
                    { "customerSome@gmail.com", "764fd50f-7e1e-4794-b977-a92bc731906c" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "764fd50f-7e1e-4794-b977-a92bc731906c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "ac508727-888c-4150-9039-9c1419743a5e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hashonecreations1@gmail.com", "ac508727-888c-4150-9039-9c1419743a5e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "ac508727-888c-4150-9039-9c1419743a5e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "764fd50f-7e1e-4794-b977-a92bc731906c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac508727-888c-4150-9039-9c1419743a5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hashonecreations1@gmail.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com");
        }
    }
}
