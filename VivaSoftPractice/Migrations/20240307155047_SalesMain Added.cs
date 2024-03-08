using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaSoftPractice.Migrations
{
    public partial class SalesMainAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("241fb4eb-4038-4999-a4d0-9586e93027c0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3d8fe8ff-ea99-4cfb-a1ec-a538cd7d3815"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3ee54b58-7beb-4603-a716-df643bdbfe39"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("445cbfbf-b91b-4faa-a30d-a553ef37ff38"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5200c877-2f50-4832-b76b-96045bf827f2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("842c3155-4455-45f5-badf-939b8c75e7b8"));

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

            migrationBuilder.CreateTable(
                name: "SalesMains",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesMains", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("3de2eb97-f342-4d99-97b7-7425b77b6217"), "facewash", 327844.58000000002 },
                    { new Guid("6146472e-9854-4153-9551-4646da615193"), "Less", 434.77999999999997 },
                    { new Guid("836127e0-313e-40e3-abe9-ca80736e975e"), "andoid", 327844.58000000002 },
                    { new Guid("9d2ef2ec-fc25-43ad-9cd8-d8c5e422618b"), "samsung", 6434.96 },
                    { new Guid("d0d41311-6930-406d-9241-642d78dc7881"), "mini TV", 6434.96 },
                    { new Guid("f26c8380-dc1e-4441-9281-b770b49be07d"), "honda", 434.77999999999997 }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3467e66d-6d23-42e8-b7a7-69d4c758cc0a"), "Organizer" },
                    { new Guid("38638f23-a48f-418a-99c0-1dd27d61cf10"), "User" },
                    { new Guid("e981141b-d2cd-4ad0-9584-0c522831ce97"), "Admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesMains");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3de2eb97-f342-4d99-97b7-7425b77b6217"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6146472e-9854-4153-9551-4646da615193"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("836127e0-313e-40e3-abe9-ca80736e975e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9d2ef2ec-fc25-43ad-9cd8-d8c5e422618b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d0d41311-6930-406d-9241-642d78dc7881"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f26c8380-dc1e-4441-9281-b770b49be07d"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("3467e66d-6d23-42e8-b7a7-69d4c758cc0a"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("38638f23-a48f-418a-99c0-1dd27d61cf10"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("e981141b-d2cd-4ad0-9584-0c522831ce97"));

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
    }
}
