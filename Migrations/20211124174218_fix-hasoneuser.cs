using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class fixhasoneuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "de9bf631-7f4d-4afa-aa34-4d2318f8a00a", "9d0f384e-45f9-4ed2-a221-7626fc141c05", "Administrator", "ADMINISTRATOR" },
                    { "b68514cc-8e74-4b1e-976d-0e5d8297f4ce", "d31d9279-8471-4c1e-96b3-3bf700099115", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d16658e1-f145-4867-9528-f9a7186e8125", "c98a131f-653b-48f1-8d09-abae5c8d711e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8db2e2b9-7157-4d68-ace8-40f9c689a6f5", "d3504a13-3496-422b-b826-dcd166f9358b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hashonecreations1@gmail.com",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "5ae07637-b861-4fe3-8860-d5870485a543", "hashonecreations1", "85951e64-eb41-41ee-8c8c-aa37dc1dbe67", "hashonecreations1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fdd8f32b-3c6a-4d33-8db7-bac0f2d009fd", "bd3346a1-8a0c-47f8-bde0-ebdd8065296c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "de9bf631-7f4d-4afa-aa34-4d2318f8a00a" },
                    { "hashonecreations1@gmail.com", "de9bf631-7f4d-4afa-aa34-4d2318f8a00a" },
                    { "ubaid1900@gmail.com", "de9bf631-7f4d-4afa-aa34-4d2318f8a00a" },
                    { "customerSome@gmail.com", "b68514cc-8e74-4b1e-976d-0e5d8297f4ce" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "b68514cc-8e74-4b1e-976d-0e5d8297f4ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "de9bf631-7f4d-4afa-aa34-4d2318f8a00a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hashonecreations1@gmail.com", "de9bf631-7f4d-4afa-aa34-4d2318f8a00a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "de9bf631-7f4d-4afa-aa34-4d2318f8a00a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b68514cc-8e74-4b1e-976d-0e5d8297f4ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de9bf631-7f4d-4afa-aa34-4d2318f8a00a");

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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "f5747c0f-85d4-40fb-a11c-db9351fd3f93", "mujahidkhan17", "aa2dfd47-5bf8-4176-9cb4-7020d7997687", "mujahidkhan17" });

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
    }
}
