using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaSoftPractice.Migrations
{
    public partial class seedrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6951914f-f99c-4f8c-ac96-52f7d5a8ede1"), "Organizer" });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9e2a6312-9e23-43af-9576-57063ea973c6"), "Admin" });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b5f8026f-1eaf-43e7-8060-a83af2ece4d4"), "User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("6951914f-f99c-4f8c-ac96-52f7d5a8ede1"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("9e2a6312-9e23-43af-9576-57063ea973c6"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("b5f8026f-1eaf-43e7-8060-a83af2ece4d4"));
        }
    }
}
