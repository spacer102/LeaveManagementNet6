using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddeddLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfc63980-bb2a-4281-aa45-6c14b0c9e47a",
                column: "ConcurrencyStamp",
                value: "cdbe5663-9dd7-4d90-9bdd-3836e65a74c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "klm63980-bb2a-5024-zz69-6c14b0c9e47b",
                column: "ConcurrencyStamp",
                value: "2d9aa2d3-26d1-4711-a6ae-4e1bfa850463");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dd43043-2c51-4076-a4c9-1d4ca42e5749",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1bdca18-dcaf-47bc-b2fa-f77841614f08", "AQAAAAEAACcQAAAAECwNNSL+Sc2XIvEQskCfmzRUH6EFDCqTieHuz3GgqZX79KHvpId7/S6sj57kTu5eLQ==", "82483ffb-93e9-46d4-80d0-cf792e810289" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "baf63980-aa8b-5678-aa36-6c14b0c3e49b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a489cb0f-fc94-4cc5-827f-e152e27c36a5", "AQAAAAEAACcQAAAAENDz1aBUusjtaCACXYczTGfgTxtVAJGxSk2i4yOEvFT617fj9x/ZqlGU7P02knkmtw==", "d0242c41-38da-49d4-b89f-3407d80cab03" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfc63980-bb2a-4281-aa45-6c14b0c9e47a",
                column: "ConcurrencyStamp",
                value: "11bc99c8-28ff-4436-aeb6-797974823f4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "klm63980-bb2a-5024-zz69-6c14b0c9e47b",
                column: "ConcurrencyStamp",
                value: "6c84f3ee-2f57-4a5a-bc22-23511db5cad2");

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
    }
}
