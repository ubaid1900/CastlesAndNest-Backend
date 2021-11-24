using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class reorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "341c6216-3829-4bc5-8c6d-d5707c5ea754", "55e47332-0e9c-493f-aec6-bf244a599d1c", "Administrator", "ADMINISTRATOR" },
                    { "940b374d-e4c7-4646-8638-27d0ad542d08", "d105aa14-f851-40a5-be20-5aaa447ed1ec", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1580f3a6-db81-49c5-b58c-8fb8ed0e1081", "fc58a3e9-a7f8-482d-a362-8e9b984235d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "671b053b-394a-499d-b371-478135379476", "83cb82a4-e675-4763-b672-18c7bb5e839e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hashonecreations1@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d590881e-6b31-4808-9818-088b5730988d", "d36bef1c-15f7-4f92-b426-0cddbb435fb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e95474c-0008-4c0d-bb03-5060e014eb0e", "1b910df1-7454-4ea1-af3e-1b1de66eefcc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "341c6216-3829-4bc5-8c6d-d5707c5ea754" },
                    { "ubaid1900@gmail.com", "341c6216-3829-4bc5-8c6d-d5707c5ea754" },
                    { "hashonecreations1@gmail.com", "341c6216-3829-4bc5-8c6d-d5707c5ea754" },
                    { "customerSome@gmail.com", "940b374d-e4c7-4646-8638-27d0ad542d08" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "940b374d-e4c7-4646-8638-27d0ad542d08" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "341c6216-3829-4bc5-8c6d-d5707c5ea754" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hashonecreations1@gmail.com", "341c6216-3829-4bc5-8c6d-d5707c5ea754" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "341c6216-3829-4bc5-8c6d-d5707c5ea754" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "341c6216-3829-4bc5-8c6d-d5707c5ea754");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "940b374d-e4c7-4646-8638-27d0ad542d08");

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ae07637-b861-4fe3-8860-d5870485a543", "85951e64-eb41-41ee-8c8c-aa37dc1dbe67" });

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
    }
}
