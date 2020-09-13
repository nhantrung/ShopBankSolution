using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBankSolution.Data.Migrations
{
    public partial class HomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b958536f-d146-4b77-9cd5-32e39fe3819b"),
                column: "ConcurrencyStamp",
                value: "46136ee3-4276-422e-8d7e-2e4852904fe2");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d3decde-c828-4e4a-b338-9b5dad31255f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d976a47-4b1a-4301-a99e-feb7ffcebce0", "AQAAAAEAACcQAAAAEKM3YxvB54TimWTfrp2JMH+VppsAQ3vF+3WG2LgsC1A8oDl2fNSgH+RdLObw/q4Wvw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 13, 16, 3, 2, 337, DateTimeKind.Local).AddTicks(3099));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b958536f-d146-4b77-9cd5-32e39fe3819b"),
                column: "ConcurrencyStamp",
                value: "8856212f-946c-49e1-ab97-30a2705b79b8");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d3decde-c828-4e4a-b338-9b5dad31255f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd3b5b00-7c7b-40d8-80fb-4ea0ca91105f", "AQAAAAEAACcQAAAAEMvzETMaOkZ2eo5nXKVdGvJ5jcNv9q3bIDzOO+d7Mdz/qdN1sEZQ2hrOQLmZCpcUsg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 11, 16, 54, 46, 434, DateTimeKind.Local).AddTicks(9389));
        }
    }
}
