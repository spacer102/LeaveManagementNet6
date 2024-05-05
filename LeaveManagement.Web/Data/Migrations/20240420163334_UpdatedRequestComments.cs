using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfc63980-bb2a-4281-aa45-6c14b0c9e47a",
                column: "ConcurrencyStamp",
                value: "38fc1b2a-815b-46fa-9a25-77809a2c0e13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "klm63980-bb2a-5024-zz69-6c14b0c9e47b",
                column: "ConcurrencyStamp",
                value: "b3b670d0-b70b-49be-8bc8-ea5f0794007b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dd43043-2c51-4076-a4c9-1d4ca42e5749",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7cc023e-80df-4db0-be62-c3f9da5f47e7", "AQAAAAEAACcQAAAAENa7bCzl4vHt66ZtTurk8tFS/AJ0Zi7y5Kaku6gaH9lQyND6BXU5ZOOZctWOR7xJ8g==", "6d25dbe6-3fb5-48b6-acf9-f9ac612562f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "baf63980-aa8b-5678-aa36-6c14b0c3e49b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8010b55d-7d19-4135-8015-121993a6abe7", "AQAAAAEAACcQAAAAELcln8oC2NcGEoTeiuBqu0SvXpd0GFymbFKZs76vw3gva4/0O9pHQzSH8TpklrlegA==", "fddf3516-a745-4993-9893-6a1bd8a540c0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
