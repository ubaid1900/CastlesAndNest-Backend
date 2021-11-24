using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class clearall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hashonecreations1@gmail.com");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "341c6216-3829-4bc5-8c6d-d5707c5ea754", "55e47332-0e9c-493f-aec6-bf244a599d1c", "Administrator", "ADMINISTRATOR" },
                    { "940b374d-e4c7-4646-8638-27d0ad542d08", "d105aa14-f851-40a5-be20-5aaa447ed1ec", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AuthToken", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "IdToken", "Lastname", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "Provider", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", 0, null, "671b053b-394a-499d-b371-478135379476", "hafeezomair@gmail.com", true, null, null, null, false, null, null, "hafeezomair@gmail.com", "hafeezomair", null, null, false, null, null, "83cb82a4-e675-4763-b672-18c7bb5e839e", false, "hafeezomair" },
                    { "ubaid1900@gmail.com", 0, null, "4e95474c-0008-4c0d-bb03-5060e014eb0e", "ubaid1900@gmail.com", true, null, null, null, false, null, null, "ubaid1900@gmail.com", "ubaid1900", null, null, false, null, null, "1b910df1-7454-4ea1-af3e-1b1de66eefcc", false, "ubaid1900" },
                    { "customerSome@gmail.com", 0, null, "1580f3a6-db81-49c5-b58c-8fb8ed0e1081", "customerSome@gmail.com", true, null, null, null, false, null, null, "customerSome@gmail.com", "customerSome", null, null, false, null, null, "fc58a3e9-a7f8-482d-a362-8e9b984235d7", false, "customerSome" },
                    { "hashonecreations1@gmail.com", 0, null, "d590881e-6b31-4808-9818-088b5730988d", "hashonecreations1@gmail.com", true, null, null, null, false, null, null, "hashonecreations1@gmail.com", "hashonecreations1", null, null, false, null, null, "d36bef1c-15f7-4f92-b426-0cddbb435fb9", false, "hashonecreations1" }
                });

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
    }
}
