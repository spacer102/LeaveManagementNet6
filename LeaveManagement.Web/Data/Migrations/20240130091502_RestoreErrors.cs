using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class RestoreErrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dfc63980-bb2a-4281-aa45-6c14b0c9e47a", "6dd43043-2c51-4076-a4c9-1d4ca42e5749" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "klm63980-bb2a-5024-zz69-6c14b0c9e47b", "baf63980-aa8b-5678-aa36-6c14b0c3e49b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfc63980-bb2a-4281-aa45-6c14b0c9e47a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "klm63980-bb2a-5024-zz69-6c14b0c9e47b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dd43043-2c51-4076-a4c9-1d4ca42e5749");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "baf63980-aa8b-5678-aa36-6c14b0c3e49b");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dfc63980-bb2a-4281-aa45-6c14b0c9e47a", "741a7556-7e13-43f2-9eff-efe6e3a643a1", "administrator", "ADMINISTRATOR" },
                    { "klm63980-bb2a-5024-zz69-6c14b0c9e47b", "22575e57-3d35-44c9-866b-2a3ccf094b33", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6dd43043-2c51-4076-a4c9-1d4ca42e5749", 0, "9670f9bd-5f44-4d9f-8cac-04de83313f68", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENVTn1yh01rcvAh9nL3xQ4QaCqyf6kLRp5PMHEP9hb3XylFllHnZlEZuqGuoJ7rwow==", null, false, "81e4d5fe-4db7-40b5-8446-df3fcfa086a7", null, false, "admin@localhost.com" },
                    { "baf63980-aa8b-5678-aa36-6c14b0c3e49b", 0, "79584915-be82-42ba-a758-583d2a45e94e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "user@LOCALHOST.COM", "user@LOCALHOST.COM", "AQAAAAEAACcQAAAAEH9+ZKhmArq6RWYCAEbbThLi4s3ytgTU+2oEPS1YxkcY5ZaU4Q/5HlwNwDnXD1ik1Q==", null, false, "c0e02a14-a133-436e-b5b1-9b10d63db6e7", null, false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dfc63980-bb2a-4281-aa45-6c14b0c9e47a", "6dd43043-2c51-4076-a4c9-1d4ca42e5749" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "klm63980-bb2a-5024-zz69-6c14b0c9e47b", "baf63980-aa8b-5678-aa36-6c14b0c3e49b" });
        }
    }
}
