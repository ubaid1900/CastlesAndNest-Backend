using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class tempr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5781fa53-19e2-4f1f-983f-0b86b9f5af7a", "e6b12feb-6b8b-4b52-ba2c-633ffb615ad0", "Administrator", "ADMINISTRATOR" },
                    { "f7e3c595-a372-4c61-a8dd-e4c4e900dd1e", "b5422319-7f1a-4fb2-a38e-5e120e15cb64", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "583a7b12-7b74-4b8a-82fb-7719490a8554", "074c0c1f-b207-467a-b044-e0ac4e1245f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0cce118-bd7d-467f-be1d-33e524f3c2b2", "936fb755-704b-4f2a-9e7a-8af6cb37abdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1cb6e2b9-439a-4a48-92bb-3b5a69cf8990", "943d8310-c4db-45be-9603-b9669c3bb5a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4610d7c-0dfd-499d-afeb-292e610a7bc4", "221d5447-3a18-4be9-a5b1-f3ccb31801c4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "5781fa53-19e2-4f1f-983f-0b86b9f5af7a" },
                    { "mujahidkhan17@gmail.com", "5781fa53-19e2-4f1f-983f-0b86b9f5af7a" },
                    { "ubaid1900@gmail.com", "5781fa53-19e2-4f1f-983f-0b86b9f5af7a" },
                    { "customerSome@gmail.com", "f7e3c595-a372-4c61-a8dd-e4c4e900dd1e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "f7e3c595-a372-4c61-a8dd-e4c4e900dd1e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "5781fa53-19e2-4f1f-983f-0b86b9f5af7a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "5781fa53-19e2-4f1f-983f-0b86b9f5af7a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "5781fa53-19e2-4f1f-983f-0b86b9f5af7a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5781fa53-19e2-4f1f-983f-0b86b9f5af7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7e3c595-a372-4c61-a8dd-e4c4e900dd1e");

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
    }
}
