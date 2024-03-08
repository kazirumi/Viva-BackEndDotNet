using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaSoftPractice.Migrations
{
    public partial class SalesSubAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "SalesSubs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalesMainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalSubPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesSubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesSubs_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesSubs_SalesMains_SalesMainId",
                        column: x => x.SalesMainId,
                        principalTable: "SalesMains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("17bb0329-aa0a-4feb-9295-a0c06e58ceb0"), "facewash", 327844.58000000002 },
                    { new Guid("55250d19-d2cb-4ba8-983e-851ead58a33a"), "mini TV", 6434.96 },
                    { new Guid("5b0a9674-816c-4d3a-8e1e-34a5f2e1a596"), "samsung", 6434.96 },
                    { new Guid("86485f06-09dc-483e-8022-879af36f6975"), "honda", 434.77999999999997 },
                    { new Guid("cab96629-2b21-42c0-809f-0800e3a44830"), "andoid", 327844.58000000002 },
                    { new Guid("df5fa708-ee28-419d-bfa1-63c2cce15801"), "Less", 434.77999999999997 }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6b0ae760-0fe1-41bf-a9ea-e569f5358c12"), "User" },
                    { new Guid("75d1dc9a-1399-4977-8776-bede05194056"), "Organizer" },
                    { new Guid("95845afb-4be3-497e-b425-aab396a2122d"), "Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesSubs_ItemId",
                table: "SalesSubs",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesSubs_SalesMainId",
                table: "SalesSubs",
                column: "SalesMainId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesSubs");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("17bb0329-aa0a-4feb-9295-a0c06e58ceb0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55250d19-d2cb-4ba8-983e-851ead58a33a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5b0a9674-816c-4d3a-8e1e-34a5f2e1a596"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("86485f06-09dc-483e-8022-879af36f6975"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cab96629-2b21-42c0-809f-0800e3a44830"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("df5fa708-ee28-419d-bfa1-63c2cce15801"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("6b0ae760-0fe1-41bf-a9ea-e569f5358c12"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("75d1dc9a-1399-4977-8776-bede05194056"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("95845afb-4be3-497e-b425-aab396a2122d"));

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
    }
}
