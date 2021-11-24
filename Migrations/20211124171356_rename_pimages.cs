using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class rename_pimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "48ab4d8b-1bcc-4696-b38b-d23fa0897d87" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "8b76911e-16f1-446b-a03c-f453433d1aaa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hashonecreations1@gmail.com", "8b76911e-16f1-446b-a03c-f453433d1aaa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "8b76911e-16f1-446b-a03c-f453433d1aaa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48ab4d8b-1bcc-4696-b38b-d23fa0897d87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b76911e-16f1-446b-a03c-f453433d1aaa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e7f97f6-f5ba-4829-9bba-ce168f1df927", "ec9db148-2090-4857-9aa0-2bf416e27c5e", "Administrator", "ADMINISTRATOR" },
                    { "81efcd81-3151-4db2-9b1c-80faf373d8e6", "2e30effe-9ba5-4fd9-8cdf-ade5f9a61474", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa6751d9-f04e-4f99-9f37-ea559ff4d035", "9d3b7c1f-a22b-4304-af21-9b87f8ad4389" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0541f9f7-d34d-42d3-82c9-af91ce0a30f4", "7d15b091-5af7-457b-bdca-bf43bb18b7ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hashonecreations1@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5747c0f-85d4-40fb-a11c-db9351fd3f93", "aa2dfd47-5bf8-4176-9cb4-7020d7997687" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25b4e88f-df11-4df8-b4c7-bdc1b93d1ee5", "31d09550-62ab-499d-9107-1ef6a0e0e2f6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "3e7f97f6-f5ba-4829-9bba-ce168f1df927" },
                    { "hashonecreations1@gmail.com", "3e7f97f6-f5ba-4829-9bba-ce168f1df927" },
                    { "ubaid1900@gmail.com", "3e7f97f6-f5ba-4829-9bba-ce168f1df927" },
                    { "customerSome@gmail.com", "81efcd81-3151-4db2-9b1c-80faf373d8e6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "81efcd81-3151-4db2-9b1c-80faf373d8e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "3e7f97f6-f5ba-4829-9bba-ce168f1df927" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hashonecreations1@gmail.com", "3e7f97f6-f5ba-4829-9bba-ce168f1df927" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "3e7f97f6-f5ba-4829-9bba-ce168f1df927" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7f97f6-f5ba-4829-9bba-ce168f1df927");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81efcd81-3151-4db2-9b1c-80faf373d8e6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b76911e-16f1-446b-a03c-f453433d1aaa", "e6ce22c2-f6dd-470f-ba2b-6a92cbf1dd70", "Administrator", "ADMINISTRATOR" },
                    { "48ab4d8b-1bcc-4696-b38b-d23fa0897d87", "4e2422cb-3dcf-42ac-ada5-31350a119652", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "33a82c1b-5396-4262-acc0-5edb3e6d462e", "78fc3544-dc49-4f40-a296-9cb04944be34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "05b68db1-5bb4-4500-abb2-8508b414c26d", "0f237d8e-8dd2-4822-9c30-a14ebf75fbe3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hashonecreations1@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fca36dfd-a1c0-4356-abf8-2b6e5171386d", "85c51970-04e4-4989-94bc-1ef954b34c32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "def537a3-8017-48c9-9625-c1d282fcbb4f", "bd25b3c5-3d70-4f48-a7f4-be4098deab8a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "8b76911e-16f1-446b-a03c-f453433d1aaa" },
                    { "hashonecreations1@gmail.com", "8b76911e-16f1-446b-a03c-f453433d1aaa" },
                    { "ubaid1900@gmail.com", "8b76911e-16f1-446b-a03c-f453433d1aaa" },
                    { "customerSome@gmail.com", "48ab4d8b-1bcc-4696-b38b-d23fa0897d87" }
                });
        }
    }
}
