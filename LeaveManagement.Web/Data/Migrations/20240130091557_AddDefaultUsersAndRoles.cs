using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dfc63980-bb2a-4281-aa45-6c14b0c9e47a", "bf828c8d-0f72-4910-90cd-6435154b2e37", "administrator", "ADMINISTRATOR" },
                    { "klm63980-bb2a-5024-zz69-6c14b0c9e47b", "07120b6f-5c0e-4d6b-8075-2eba560e187d", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6dd43043-2c51-4076-a4c9-1d4ca42e5749", 0, "7c854774-fb0d-4e8d-9cb2-681f5ac32aa9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPQvAFDKvcaVXbwiqeRa6FlMfbM0kisHA2C4vCJjwIVAsw6shFIp+FG24qozDruudg==", null, false, "6043c3ab-7d1f-4e82-b408-e61e01bc862b", null, false, "admin@localhost.com" },
                    { "baf63980-aa8b-5678-aa36-6c14b0c3e49b", 0, "494379cc-23a3-4418-bb96-25324d8bf0da", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "user@LOCALHOST.COM", "user@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFL65ZImhT0MKpq/VDlKoIZLodwu2lPkP98dG43q3pBGeDD7JoNL5F9MLzKKYnWv+w==", null, false, "b5f5b14d-d3bb-4677-b407-8f97ca3328b4", null, false, "user@localhost.com" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
