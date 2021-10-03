using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "ecd9906b-866a-4373-8764-a59d8f58c1a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "a67df26c-eb21-448b-81a3-cf9cad80154d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "a67df26c-eb21-448b-81a3-cf9cad80154d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "a67df26c-eb21-448b-81a3-cf9cad80154d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a67df26c-eb21-448b-81a3-cf9cad80154d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecd9906b-866a-4373-8764-a59d8f58c1a0");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6caabc38-8069-41c2-9406-094a5fc81103", "baf56c3b-8db2-4327-b183-f43e7d1598da", "Administrator", "ADMINISTRATOR" },
                    { "ec80146e-ff2d-45fd-8c15-4437117148e5", "d4f56f4c-af89-468b-ab6d-3dcb38a416af", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d47742d-7318-46bb-b971-a4488623be10", "d9ae3b82-40f7-426d-898a-76473e14debd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86b8fe2f-0f9a-47f4-8a2a-749aedc5dc4d", "6ca64501-075d-4467-9bfc-9ec43e11cabd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "953f3cb6-fa8b-45b2-add0-3a2a8fb4a6aa", "6be02c29-5000-44e1-858d-86cd9a8d3d47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "845a66da-7355-4c53-954d-a33e9e95e6a8", "e4afb101-2d44-47ec-87a4-1e618de91bd0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "6caabc38-8069-41c2-9406-094a5fc81103" },
                    { "mujahidkhan17@gmail.com", "6caabc38-8069-41c2-9406-094a5fc81103" },
                    { "ubaid1900@gmail.com", "6caabc38-8069-41c2-9406-094a5fc81103" },
                    { "customerSome@gmail.com", "ec80146e-ff2d-45fd-8c15-4437117148e5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "ec80146e-ff2d-45fd-8c15-4437117148e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "6caabc38-8069-41c2-9406-094a5fc81103" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "6caabc38-8069-41c2-9406-094a5fc81103" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "6caabc38-8069-41c2-9406-094a5fc81103" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6caabc38-8069-41c2-9406-094a5fc81103");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec80146e-ff2d-45fd-8c15-4437117148e5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a67df26c-eb21-448b-81a3-cf9cad80154d", "41041b5e-b20c-45d1-960e-ec4742af3aea", "Administrator", "ADMINISTRATOR" },
                    { "ecd9906b-866a-4373-8764-a59d8f58c1a0", "54257505-c37d-4e15-a663-34a09286bd59", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92f5d2b1-6b38-4b19-9259-d5a1cdc3a57e", "0b0c8f77-379b-4fbf-b76b-5c43b00cd66c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7153de5e-2292-4f9e-8446-ec63c69c88a1", "7e93b5a0-47ac-45a4-a52f-0f6db66da292" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "558a8add-cb9f-46ba-a420-227214f2ad6e", "140b5683-a2d7-4310-9aa6-4daf2c346970" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8a63749-1b58-4b38-96a1-b908d4b78840", "d8690f90-dcb4-45da-af42-308806b4edea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "a67df26c-eb21-448b-81a3-cf9cad80154d" },
                    { "mujahidkhan17@gmail.com", "a67df26c-eb21-448b-81a3-cf9cad80154d" },
                    { "ubaid1900@gmail.com", "a67df26c-eb21-448b-81a3-cf9cad80154d" },
                    { "customerSome@gmail.com", "ecd9906b-866a-4373-8764-a59d8f58c1a0" }
                });
        }
    }
}
