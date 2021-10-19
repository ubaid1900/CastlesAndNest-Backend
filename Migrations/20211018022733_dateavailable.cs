using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class dateavailable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAvailable",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "39ca9459-69a1-447e-b4eb-98567ec6c503", "7b0783a9-166c-4fca-8f6f-147066c3c5d2", "Administrator", "ADMINISTRATOR" },
                    { "a0282bcd-ab7d-48c8-943b-03fe107c6b76", "875f90fe-0da3-4a40-af82-ef3d0dffac12", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8fbe4f4-6f72-4747-9821-6f87b2e52985", "339c88b0-9025-43f5-9ef9-b0917a47844d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80c9e91f-7ec9-46ec-83e9-c388dfbbee46", "bbe11969-56f3-414f-89c9-255bbd674f21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c9bff1b-2821-401a-9b14-0e803ddec41b", "c152d909-56f3-4903-b9a1-b580e0348e8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf1be3dd-8aec-466e-8e73-8fb170d77a1d", "699a7279-54ed-4bb7-88bc-9f606b424b09" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "39ca9459-69a1-447e-b4eb-98567ec6c503" },
                    { "mujahidkhan17@gmail.com", "39ca9459-69a1-447e-b4eb-98567ec6c503" },
                    { "ubaid1900@gmail.com", "39ca9459-69a1-447e-b4eb-98567ec6c503" },
                    { "customerSome@gmail.com", "a0282bcd-ab7d-48c8-943b-03fe107c6b76" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "a0282bcd-ab7d-48c8-943b-03fe107c6b76" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "39ca9459-69a1-447e-b4eb-98567ec6c503" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "39ca9459-69a1-447e-b4eb-98567ec6c503" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "39ca9459-69a1-447e-b4eb-98567ec6c503" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39ca9459-69a1-447e-b4eb-98567ec6c503");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0282bcd-ab7d-48c8-943b-03fe107c6b76");

            migrationBuilder.DropColumn(
                name: "DateAvailable",
                table: "Products");

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
    }
}
