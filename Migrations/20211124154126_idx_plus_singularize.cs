using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class idx_plus_singularize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_DateAvailable",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "c6682250-f4f6-4385-a7af-3a525fe5437e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "42010c77-e832-44d5-81d4-7c2a76e17cd9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "42010c77-e832-44d5-81d4-7c2a76e17cd9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "42010c77-e832-44d5-81d4-7c2a76e17cd9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42010c77-e832-44d5-81d4-7c2a76e17cd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6682250-f4f6-4385-a7af-3a525fe5437e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b817f77d-521a-44df-b296-14034216e6a7", "927fe1ca-0417-4f12-b6a5-4f07f7142e5b", "Administrator", "ADMINISTRATOR" },
                    { "cd3452a2-f3b8-4dcc-b269-111b42552788", "f42cf73b-6707-4c2b-aab6-38eb64c2276a", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9dc7d678-df81-4397-81f6-9745cd1e4a7c", "f489eaad-f8b4-4a26-a871-f7a8e5b965ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d53567a2-e550-4d80-b8e2-5ca5c1f3c02e", "bddbd9a5-82cf-4693-a3ae-5fb9e9f623ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b67f800d-d3bb-453e-b972-eaeaa3862f58", "02043723-89c6-4ba0-84bc-b31103af4d8c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "b817f77d-521a-44df-b296-14034216e6a7" },
                    { "ubaid1900@gmail.com", "b817f77d-521a-44df-b296-14034216e6a7" },
                    { "hashonecreations1@gmail.com", "b817f77d-521a-44df-b296-14034216e6a7" },
                    { "customerSome@gmail.com", "cd3452a2-f3b8-4dcc-b269-111b42552788" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Featured_DateAvailable",
                table: "Products",
                columns: new[] { "Featured", "DateAvailable" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_Featured_DateAvailable",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "cd3452a2-f3b8-4dcc-b269-111b42552788" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "b817f77d-521a-44df-b296-14034216e6a7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hashonecreations1@gmail.com", "b817f77d-521a-44df-b296-14034216e6a7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "b817f77d-521a-44df-b296-14034216e6a7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b817f77d-521a-44df-b296-14034216e6a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd3452a2-f3b8-4dcc-b269-111b42552788");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42010c77-e832-44d5-81d4-7c2a76e17cd9", "a59b35dd-2b8f-48bf-9307-96c6018beab9", "Administrator", "ADMINISTRATOR" },
                    { "c6682250-f4f6-4385-a7af-3a525fe5437e", "0e7a64e2-bf3d-4dea-ba1d-4f2397f1b519", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83f746e4-37bd-4fe7-9a51-281fce2c4950", "fe62835d-06e7-423a-952d-9752a142e420" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f402f028-3921-452e-9e4f-0f7b0aa88e33", "813710e0-8402-4cab-9e73-25e4e7aa25fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40336f78-da4d-48d1-97ea-16617b2dba23", "f6f004b8-6a45-414b-bfbc-14c784a75c14" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AuthToken", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "IdToken", "Lastname", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "Provider", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "mujahidkhan17@gmail.com", 0, null, "64322cac-4348-4b06-b819-d67d810507b0", "mujahidkhan17@gmail.com", true, null, null, null, false, null, null, "mujahidkhan17@gmail.com", "mujahidkhan17", null, null, false, null, null, "4eab4d27-ca29-425e-9b23-939031663990", false, "mujahidkhan17" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "42010c77-e832-44d5-81d4-7c2a76e17cd9" },
                    { "mujahidkhan17@gmail.com", "42010c77-e832-44d5-81d4-7c2a76e17cd9" },
                    { "ubaid1900@gmail.com", "42010c77-e832-44d5-81d4-7c2a76e17cd9" },
                    { "customerSome@gmail.com", "c6682250-f4f6-4385-a7af-3a525fe5437e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_DateAvailable",
                table: "Products",
                column: "DateAvailable");
        }
    }
}
