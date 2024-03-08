using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VivaSoftPractice.Migrations
{
    public partial class SalesSubquantityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "SalesSubs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1b9eebd4-2480-43d5-b744-2e50060a274b"), "facewash", 327844.58000000002 },
                    { new Guid("56ac9b36-2237-4cdd-9689-385372aed46a"), "honda", 434.77999999999997 },
                    { new Guid("5aabda5d-1800-4742-a13b-e7863f71296e"), "samsung", 6434.96 },
                    { new Guid("71ebd70e-4c4d-4efe-be1e-060033e0cdae"), "mini TV", 6434.96 },
                    { new Guid("938c596e-8db3-4715-a3ed-36fc59c50214"), "Less", 434.77999999999997 },
                    { new Guid("a285aaca-500c-434d-b45a-340dca34678a"), "andoid", 327844.58000000002 }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("61ca20f6-4515-498a-b4e5-cb3d6fc8d863"), "User" },
                    { new Guid("7377658b-ec00-4adb-a0a6-0ebfe87e1fa1"), "Admin" },
                    { new Guid("96fe0d24-a301-4e0d-82c6-b6ac99b6c896"), "Organizer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1b9eebd4-2480-43d5-b744-2e50060a274b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("56ac9b36-2237-4cdd-9689-385372aed46a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5aabda5d-1800-4742-a13b-e7863f71296e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("71ebd70e-4c4d-4efe-be1e-060033e0cdae"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("938c596e-8db3-4715-a3ed-36fc59c50214"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a285aaca-500c-434d-b45a-340dca34678a"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("61ca20f6-4515-498a-b4e5-cb3d6fc8d863"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("7377658b-ec00-4adb-a0a6-0ebfe87e1fa1"));

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: new Guid("96fe0d24-a301-4e0d-82c6-b6ac99b6c896"));

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "SalesSubs");

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
        }
    }
}
