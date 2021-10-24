using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class indexOnDateAvailable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ba416a8-0616-4bbe-9010-17f8058a655e", "be9b4d41-fb44-4cb3-8063-cd0a129d8599", "Administrator", "ADMINISTRATOR" },
                    { "24c0d966-23d3-4cfb-8c1e-c8ec41e548ee", "55401f68-0473-4c87-a32e-7b62152110eb", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5bbb0e8-d201-4416-9d18-0c4d3971f967", "41c9e5fc-3da0-40ee-9a00-937075e0211c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e86ef68b-b68c-4cf6-9f47-8897479aa856", "2b4da97c-d6cf-4c87-aed1-cafec4b47e6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "mujahidkhan17@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "96fe557c-d694-4810-8ff7-7ec1af4d1d4c", "cdf0f4e5-ae2d-4ee1-9eed-762a54af652a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94fbe12d-bff9-468e-ba0a-dff147ee5962", "c55b2c75-6ae2-49ae-91cb-73956f5d0540" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" },
                    { "mujahidkhan17@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" },
                    { "ubaid1900@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" },
                    { "customerSome@gmail.com", "24c0d966-23d3-4cfb-8c1e-c8ec41e548ee" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_DateAvailable",
                table: "Products",
                column: "DateAvailable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_DateAvailable",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "24c0d966-23d3-4cfb-8c1e-c8ec41e548ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "mujahidkhan17@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "2ba416a8-0616-4bbe-9010-17f8058a655e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24c0d966-23d3-4cfb-8c1e-c8ec41e548ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ba416a8-0616-4bbe-9010-17f8058a655e");

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
    }
}
