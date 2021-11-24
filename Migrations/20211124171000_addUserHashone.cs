using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class addUserHashone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "afa7d76f-874b-44c6-ad46-d1d0ece771ed" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "cdd9f4c9-12db-4a80-ad06-f8689892af54" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "cdd9f4c9-12db-4a80-ad06-f8689892af54" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afa7d76f-874b-44c6-ad46-d1d0ece771ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdd9f4c9-12db-4a80-ad06-f8689892af54");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "281c9dbc-f159-46d7-9c61-8caf3efa68d6", "9cfc2172-3b77-4d68-b77a-ce65487224ef", "Administrator", "ADMINISTRATOR" },
                    { "a8bfd558-4632-4464-9633-e7d40dd103e1", "8518b4e1-ede2-48b0-b339-e5132c453200", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01ebc4ab-d55b-402c-a8e3-e31bf7314315", "4822be81-c2c5-4902-9035-1dfcb4a8871f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b358b955-42bc-43cd-a4c9-a55bd8d70a00", "9523be2c-b924-422b-8fd8-5320fd319a79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7471810d-0b2a-4143-8d4c-9150e0a297d8", "805a262f-0021-478d-ae98-731f0de0babe" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AuthToken", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "IdToken", "Lastname", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PhotoUrl", "Provider", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "hashonecreations1@gmail.com", 0, null, "d2f5475e-8428-4dd1-ac8a-85e69101dbe3", "hashonecreations1@gmail.com", true, null, null, null, false, null, null, "hashonecreations1@gmail.com", "mujahidkhan17", null, null, false, null, null, "ce4bfbe5-98f1-4737-a968-2e163e3eb15e", false, "mujahidkhan17" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "hafeezomair@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" },
                    { "hashonecreations1@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" },
                    { "ubaid1900@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" },
                    { "customerSome@gmail.com", "a8bfd558-4632-4464-9633-e7d40dd103e1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "customerSome@gmail.com", "a8bfd558-4632-4464-9633-e7d40dd103e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hafeezomair@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "hashonecreations1@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ubaid1900@gmail.com", "281c9dbc-f159-46d7-9c61-8caf3efa68d6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "281c9dbc-f159-46d7-9c61-8caf3efa68d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8bfd558-4632-4464-9633-e7d40dd103e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hashonecreations1@gmail.com");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cdd9f4c9-12db-4a80-ad06-f8689892af54", "78ada36a-2338-4e23-8982-5d1070cdc3f5", "Administrator", "ADMINISTRATOR" },
                    { "afa7d76f-874b-44c6-ad46-d1d0ece771ed", "a19005af-7775-49ed-8af7-864e27cfbdf9", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "customerSome@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c94df8f8-5e53-415c-959e-feab1138e48f", "9aca8196-3cb6-418d-ad16-e789463af307" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "hafeezomair@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63a945da-8063-4812-bd90-51207f38da69", "d87139ae-65e4-4981-9e28-4a64f692ac65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ubaid1900@gmail.com",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a04f65ca-7032-4fab-9252-849734655353", "74493884-05f7-474b-b832-4b114234b09a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "hafeezomair@gmail.com", "cdd9f4c9-12db-4a80-ad06-f8689892af54" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ubaid1900@gmail.com", "cdd9f4c9-12db-4a80-ad06-f8689892af54" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "customerSome@gmail.com", "afa7d76f-874b-44c6-ad46-d1d0ece771ed" });
        }
    }
}
