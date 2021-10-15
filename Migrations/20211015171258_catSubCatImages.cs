using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class catSubCatImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "aa0ae2e6-e030-4afd-afae-2274661412af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "fdaae118-f5ad-4a57-9d04-d8b8b99ff71e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "fdaae118-f5ad-4a57-9d04-d8b8b99ff71e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "fdaae118-f5ad-4a57-9d04-d8b8b99ff71e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa0ae2e6-e030-4afd-afae-2274661412af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdaae118-f5ad-4a57-9d04-d8b8b99ff71e");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7fc305b1-93e1-4205-814e-9f917d310f09", "7362159c-71cf-4a4a-81a9-d4642c7a5592", "Administrator", "ADMINISTRATOR" },
                    { "de286ce9-3a9e-407a-b57e-e5ee3b00498e", "f8967838-2fc5-4346-871b-8bd72bd35745", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d85e006-61c6-4fcf-890a-c315f565866a", "3bbce8af-3c2a-433b-ba43-15541ab0e814" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07910626-a7be-436c-b30d-20970f653eb1", "0404faec-b399-4a0b-aafe-63bbc1265626" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "871f17f3-41a5-4a4b-8fd6-98405231211d", "78c5c001-7bcb-4a93-aef0-a712941a48ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e20be8d7-a1da-4457-b052-edf927a1279b", "1ada48e0-fbb7-478b-acda-634a19cc5de7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "7fc305b1-93e1-4205-814e-9f917d310f09" },
                    { "mujahidkhan17@gmail.com", "7fc305b1-93e1-4205-814e-9f917d310f09" },
                    { "ubaid1900@gmail.com", "7fc305b1-93e1-4205-814e-9f917d310f09" },
                    { "customerSome@gmail.com", "de286ce9-3a9e-407a-b57e-e5ee3b00498e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "de286ce9-3a9e-407a-b57e-e5ee3b00498e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "7fc305b1-93e1-4205-814e-9f917d310f09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "7fc305b1-93e1-4205-814e-9f917d310f09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "7fc305b1-93e1-4205-814e-9f917d310f09" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fc305b1-93e1-4205-814e-9f917d310f09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de286ce9-3a9e-407a-b57e-e5ee3b00498e");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fdaae118-f5ad-4a57-9d04-d8b8b99ff71e", "e2e47807-1150-4f7b-8376-5cada78137a2", "Administrator", "ADMINISTRATOR" },
                    { "aa0ae2e6-e030-4afd-afae-2274661412af", "e0d96bad-2314-4712-ac2f-48f70e0c1d36", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36ac2115-14f1-4a12-8d28-a0f1a4654bb7", "55246504-c2f7-4526-8f76-27db809a82df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e65054ba-f9cd-496a-966b-8a8bfb0e8b3b", "918e1a03-6dda-479d-8678-f690230a8373" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47fc8f4b-39fc-4507-8d9a-caf01639e94b", "23731427-585a-4f07-ae50-15b26265dc81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cec603b8-ce9e-4d5f-b3f0-ba61a4fc765f", "691a0dbe-38a2-4a1f-8a90-c21bfd9e11b7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "fdaae118-f5ad-4a57-9d04-d8b8b99ff71e" },
                    { "mujahidkhan17@gmail.com", "fdaae118-f5ad-4a57-9d04-d8b8b99ff71e" },
                    { "ubaid1900@gmail.com", "fdaae118-f5ad-4a57-9d04-d8b8b99ff71e" },
                    { "customerSome@gmail.com", "aa0ae2e6-e030-4afd-afae-2274661412af" }
                });
        }
    }
}
