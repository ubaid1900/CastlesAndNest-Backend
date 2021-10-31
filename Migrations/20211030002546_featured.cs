using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class featured : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "24c0d966-23d3-4cfb-8c1e-c8ec41e548ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24c0d966-23d3-4cfb-8c1e-c8ec41e548ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ba416a8-0616-4bbe-9010-17f8058a655e");

            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Products",
                nullable: false,
                defaultValue: false);

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
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64322cac-4348-4b06-b819-d67d810507b0", "4eab4d27-ca29-425e-9b23-939031663990" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40336f78-da4d-48d1-97ea-16617b2dba23", "f6f004b8-6a45-414b-bfbc-14c784a75c14" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ba416a8-0616-4bbe-9010-17f8058a655e", "be9b4d41-fb44-4cb3-8063-cd0a129d8599", "Administrator", "ADMINISTRATOR" },
                    { "24c0d966-23d3-4cfb-8c1e-c8ec41e548ee", "55401f68-0473-4c87-a32e-7b62152110eb", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5bbb0e8-d201-4416-9d18-0c4d3971f967", "41c9e5fc-3da0-40ee-9a00-937075e0211c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e86ef68b-b68c-4cf6-9f47-8897479aa856", "2b4da97c-d6cf-4c87-aed1-cafec4b47e6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "96fe557c-d694-4810-8ff7-7ec1af4d1d4c", "cdf0f4e5-ae2d-4ee1-9eed-762a54af652a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94fbe12d-bff9-468e-ba0a-dff147ee5962", "c55b2c75-6ae2-49ae-91cb-73956f5d0540" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" },
                    { "mujahidkhan17@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" },
                    { "ubaid1900@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" },
                    { "customerSome@gmail.com", "24c0d966-23d3-4cfb-8c1e-c8ec41e548ee" }
                });
        }
    }
}
