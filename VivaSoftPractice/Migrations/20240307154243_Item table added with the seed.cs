using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaSoftPractice.Migrations
{
    public partial class Itemtableaddedwiththeseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("241fb4eb-4038-4999-a4d0-9586e93027c0"), "honda", 434.77999999999997 },
                    { new Guid("3d8fe8ff-ea99-4cfb-a1ec-a538cd7d3815"), "samsung", 6434.96 },
                    { new Guid("3ee54b58-7beb-4603-a716-df643bdbfe39"), "facewash", 327844.58000000002 },
                    { new Guid("445cbfbf-b91b-4faa-a30d-a553ef37ff38"), "Less", 434.77999999999997 },
                    { new Guid("5200c877-2f50-4832-b76b-96045bf827f2"), "mini TV", 6434.96 },
                    { new Guid("842c3155-4455-45f5-badf-939b8c75e7b8"), "andoid", 327844.58000000002 }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("39c4e74f-ec71-4b27-b58b-94f40165ea52"), "Organizer" },
                    { new Guid("7a6f1d29-dca3-4a1c-a9a5-673d78690412"), "Admin" },
                    { new Guid("e65413e4-5d90-478f-b79c-eb104b1c1a4f"), "User" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("39c4e74f-ec71-4b27-b58b-94f40165ea52"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("7a6f1d29-dca3-4a1c-a9a5-673d78690412"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("e65413e4-5d90-478f-b79c-eb104b1c1a4f"));

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
    }
}
