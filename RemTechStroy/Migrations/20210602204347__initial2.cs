using Microsoft.EntityFrameworkCore.Migrations;

namespace RemTechStroy.Migrations
{
    public partial class _initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "f1110586-2121-45f8-a755-3c1049fe28ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98113983-9589-4683-8f44-a04deaf8a8ae", "AQAAAAEAACcQAAAAENKfTa0UP2nKQLdFzh+8ecxsdhzxRTGxIIzJ9JokCYSwx8QQsPfV/hDHieCNLzaTSw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c915a83d-9a09-4d85-8f22-d131c70dff42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6711d3b-5e88-4127-b992-07f34e527c9f", "AQAAAAEAACcQAAAAECkTi7kcxjDZJsknXZYEtrENwNATrKpFt5fClAghPeWhI4A8QoUEEOnRsdEmMsj9Ew==" });
        }
    }
}
