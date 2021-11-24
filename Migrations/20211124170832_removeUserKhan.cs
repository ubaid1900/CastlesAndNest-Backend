using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class removeUserKhan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cdd9f4c9-12db-4a80-ad06-f8689892af54", "78ada36a-2338-4e23-8982-5d1070cdc3f5", "Administrator", "ADMINISTRATOR" },
                    { "afa7d76f-874b-44c6-ad46-d1d0ece771ed", "a19005af-7775-49ed-8af7-864e27cfbdf9", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c94df8f8-5e53-415c-959e-feab1138e48f", "9aca8196-3cb6-418d-ad16-e789463af307" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63a945da-8063-4812-bd90-51207f38da69", "d87139ae-65e4-4981-9e28-4a64f692ac65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a04f65ca-7032-4fab-9252-849734655353", "74493884-05f7-474b-b832-4b114234b09a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "hafeezomair@gmail.com", "cdd9f4c9-12db-4a80-ad06-f8689892af54" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ubaid1900@gmail.com", "cdd9f4c9-12db-4a80-ad06-f8689892af54" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "customerSome@gmail.com", "afa7d76f-874b-44c6-ad46-d1d0ece771ed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "afa7d76f-874b-44c6-ad46-d1d0ece771ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "cdd9f4c9-12db-4a80-ad06-f8689892af54" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "cdd9f4c9-12db-4a80-ad06-f8689892af54" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afa7d76f-874b-44c6-ad46-d1d0ece771ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdd9f4c9-12db-4a80-ad06-f8689892af54");

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
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4610d7c-0dfd-499d-afeb-292e610a7bc4", "221d5447-3a18-4be9-a5b1-f3ccb31801c4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AuthToken", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "IdToken", "Lastname", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "Provider", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "mujahidkhan17@gmail.com", 0, null, "1cb6e2b9-439a-4a48-92bb-3b5a69cf8990", "mujahidkhan17@gmail.com", true, null, null, null, false, null, null, "mujahidkhan17@gmail.com", "mujahidkhan17", null, null, false, null, null, "943d8310-c4db-45be-9603-b9669c3bb5a5", false, "mujahidkhan17" });

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
    }
}
