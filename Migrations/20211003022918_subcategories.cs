using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class subcategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64e77316-2055-49de-b5df-e692c7e90f0b", "48187855-1616-4e86-8f9c-abc2df078d80", "Administrator", "ADMINISTRATOR" },
                    { "a2eb44b7-486a-4514-92b1-aeb2ba5f1ffe", "d54f5b27-3a50-4fe7-9c2c-50a5472ce8cb", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b3207bd5-afce-46ed-88eb-dffb2c7c8704", "8b937427-d32b-4117-9ec8-3068f53cc24f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57e0554a-f64c-44ff-a0ad-edcfa1452086", "09f491c6-c2d2-44fb-b0f5-fa66689aa44c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84eebfbb-1811-49c9-91f2-5919b45f5971", "3d5b1286-6e52-4256-8115-e8373c84d223" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c2763b5-37a3-4d32-989d-ed99d68f95aa", "edebfe74-1acc-40ed-857b-2802b0f2aeeb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "64e77316-2055-49de-b5df-e692c7e90f0b" },
                    { "mujahidkhan17@gmail.com", "64e77316-2055-49de-b5df-e692c7e90f0b" },
                    { "ubaid1900@gmail.com", "64e77316-2055-49de-b5df-e692c7e90f0b" },
                    { "customerSome@gmail.com", "a2eb44b7-486a-4514-92b1-aeb2ba5f1ffe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "a2eb44b7-486a-4514-92b1-aeb2ba5f1ffe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "64e77316-2055-49de-b5df-e692c7e90f0b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "64e77316-2055-49de-b5df-e692c7e90f0b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "64e77316-2055-49de-b5df-e692c7e90f0b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64e77316-2055-49de-b5df-e692c7e90f0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2eb44b7-486a-4514-92b1-aeb2ba5f1ffe");

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
    }
}
