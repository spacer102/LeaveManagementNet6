using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfc63980-bb2a-4281-aa45-6c14b0c9e47a",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "11bc99c8-28ff-4436-aeb6-797974823f4e", "Administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "klm63980-bb2a-5024-zz69-6c14b0c9e47b",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "6c84f3ee-2f57-4a5a-bc22-23511db5cad2", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dd43043-2c51-4076-a4c9-1d4ca42e5749",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99c86a75-cf7e-4d9a-8265-33db263fb3c0", "AQAAAAEAACcQAAAAEANSV6DuYQpmFfPhBCzLJH1ePC46oPAW/tVaEouQZZJ0EuWwk/RUBR27lRPNtWX+iQ==", "dcbff734-dd6c-4e01-a475-d8397abfa27b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "baf63980-aa8b-5678-aa36-6c14b0c3e49b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faa3cdf2-cad4-4331-bc94-f621ca981827", "AQAAAAEAACcQAAAAEKU7vv0BekC3/1Mk+r1kqlLrWHaCuIOjZ+pN+/pfDnIz1LVADcbsMWGZHwBR+vL+Tg==", "31b47173-e7bc-405b-995f-998786344fae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfc63980-bb2a-4281-aa45-6c14b0c9e47a",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "bf828c8d-0f72-4910-90cd-6435154b2e37", "administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "klm63980-bb2a-5024-zz69-6c14b0c9e47b",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "07120b6f-5c0e-4d6b-8075-2eba560e187d", "user" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dd43043-2c51-4076-a4c9-1d4ca42e5749",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c854774-fb0d-4e8d-9cb2-681f5ac32aa9", "AQAAAAEAACcQAAAAEPQvAFDKvcaVXbwiqeRa6FlMfbM0kisHA2C4vCJjwIVAsw6shFIp+FG24qozDruudg==", "6043c3ab-7d1f-4e82-b408-e61e01bc862b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "baf63980-aa8b-5678-aa36-6c14b0c3e49b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "494379cc-23a3-4418-bb96-25324d8bf0da", "AQAAAAEAACcQAAAAEFL65ZImhT0MKpq/VDlKoIZLodwu2lPkP98dG43q3pBGeDD7JoNL5F9MLzKKYnWv+w==", "b5f5b14d-d3bb-4677-b407-8f97ca3328b4" });
        }
    }
}
