using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class bookIdToProductId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "cda2f522-ba48-419c-82f0-1dff431398c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "a7575496-0e58-48d9-8fca-810d8bebc37c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "a7575496-0e58-48d9-8fca-810d8bebc37c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "a7575496-0e58-48d9-8fca-810d8bebc37c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7575496-0e58-48d9-8fca-810d8bebc37c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cda2f522-ba48-419c-82f0-1dff431398c0");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "ProductImages");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

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

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7575496-0e58-48d9-8fca-810d8bebc37c", "74cd31fc-e32d-4e84-9c34-19095629bca0", "Administrator", "ADMINISTRATOR" },
                    { "cda2f522-ba48-419c-82f0-1dff431398c0", "788a17fe-9c25-4cee-aa3b-6b585776af4f", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "604bdf09-a8d4-4d31-8cd4-a5f7fc9b7ef7", "fa16aa49-e39b-4e8f-bfba-313feffc7135" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12b56217-0d4c-4a1b-9a58-d00a77f27c00", "8bd74b03-6194-47df-8e54-4465af93d838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee02f828-4dc4-4f2d-95ea-2b416413b7d9", "3a19f3af-4381-4817-a959-ca550234629a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b96b880-887d-4d6e-9641-3525f1a33848", "daf186bf-6277-46c5-bd51-fde68dfec1b9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "a7575496-0e58-48d9-8fca-810d8bebc37c" },
                    { "mujahidkhan17@gmail.com", "a7575496-0e58-48d9-8fca-810d8bebc37c" },
                    { "ubaid1900@gmail.com", "a7575496-0e58-48d9-8fca-810d8bebc37c" },
                    { "customerSome@gmail.com", "cda2f522-ba48-419c-82f0-1dff431398c0" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
