using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class idx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_DateAvailable",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "a8bfd558-4632-4464-9633-e7d40dd103e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hashonecreations1@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "281c9dbc-f159-46d7-9c61-8caf3efa68d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8bfd558-4632-4464-9633-e7d40dd103e1");

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
                    { "281c9dbc-f159-46d7-9c61-8caf3efa68d6", "9cfc2172-3b77-4d68-b77a-ce65487224ef", "Administrator", "ADMINISTRATOR" },
                    { "a8bfd558-4632-4464-9633-e7d40dd103e1", "8518b4e1-ede2-48b0-b339-e5132c453200", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01ebc4ab-d55b-402c-a8e3-e31bf7314315", "4822be81-c2c5-4902-9035-1dfcb4a8871f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b358b955-42bc-43cd-a4c9-a55bd8d70a00", "9523be2c-b924-422b-8fd8-5320fd319a79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hashonecreations1@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d2f5475e-8428-4dd1-ac8a-85e69101dbe3", "ce4bfbe5-98f1-4737-a968-2e163e3eb15e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7471810d-0b2a-4143-8d4c-9150e0a297d8", "805a262f-0021-478d-ae98-731f0de0babe" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" },
                    { "hashonecreations1@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" },
                    { "ubaid1900@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" },
                    { "customerSome@gmail.com", "a8bfd558-4632-4464-9633-e7d40dd103e1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_DateAvailable",
                table: "Products",
                column: "DateAvailable");
        }
    }
}
