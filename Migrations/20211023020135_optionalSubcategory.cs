using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class optionalSubcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "SubCategoryId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f1be8689-c3bc-4e91-ae1a-21dc45b6cca6", "bfab68f1-6be2-470b-985f-0fd6f22a394d", "Administrator", "ADMINISTRATOR" },
                    { "82bf1244-294c-4a42-82d9-efb9099c766e", "663803fc-b6ff-4206-8eb5-c13271804785", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "afecfc77-adf3-4691-80ad-89ec8f7306b4", "850c8c08-bbf6-4b23-8aca-f0abb3acb0c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f391fac2-5ac8-495a-98c0-63f4336e4105", "8d0ed5b4-04f3-438b-a2ab-baa0e96ba734" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "887d2473-f540-4ae0-a03f-ad689408b750", "acb26a93-efca-4e40-97d1-40c8494bc81d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c43cfc27-293d-4925-a704-0291b3882437", "cee37365-52eb-435e-932a-0add82cb92a3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "f1be8689-c3bc-4e91-ae1a-21dc45b6cca6" },
                    { "mujahidkhan17@gmail.com", "f1be8689-c3bc-4e91-ae1a-21dc45b6cca6" },
                    { "ubaid1900@gmail.com", "f1be8689-c3bc-4e91-ae1a-21dc45b6cca6" },
                    { "customerSome@gmail.com", "82bf1244-294c-4a42-82d9-efb9099c766e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "82bf1244-294c-4a42-82d9-efb9099c766e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "f1be8689-c3bc-4e91-ae1a-21dc45b6cca6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "f1be8689-c3bc-4e91-ae1a-21dc45b6cca6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "f1be8689-c3bc-4e91-ae1a-21dc45b6cca6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82bf1244-294c-4a42-82d9-efb9099c766e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1be8689-c3bc-4e91-ae1a-21dc45b6cca6");

            migrationBuilder.AlterColumn<int>(
                name: "SubCategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
    }
}
