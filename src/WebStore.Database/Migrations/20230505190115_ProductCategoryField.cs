using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Database.Migrations
{
    /// <inheritdoc />
    public partial class ProductCategoryField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15698fdb-b9e8-4492-a9c6-bbd2061130e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31672b5c-0cc2-472f-ad48-7dbe0e45d4ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52dd8d7b-761c-4dd6-ae30-870255d13c8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("718ebdc0-47c6-40e5-90ce-58c824194d5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be5ac3ae-7462-409d-aed4-9850b65ff9f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5d1c1af-5665-48eb-96d1-b6e9de9b2d8d"));

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("56fbbf63-72a6-4b90-9e20-a4ded12023ca"), "accessories", "Have your cat bother the robot instead of you in the morning! Connect the Legacy™ Automated Cat Feeder to your stupid home IoT network for extra functionality. Singularity kill-switch sold separately.", "Legacy™ Automated Cat Feeder", 56.78m },
                    { new Guid("675a1baf-627f-41a1-944f-bd79f1a17a45"), "food", "Premium, delicious, kibble made from free range, grass-fed horses. 1 kilogram of kibble.", "Dry Food", 12.34m },
                    { new Guid("7f7dbbbe-c233-4883-a2d8-4dc1b79f97dd"), "food", "It's rainbows and unicorns with our most luxury wet food - literally! Made from 100% queer horse/narwhal hybrids. 1 kilogram of wet food.", "Superpremium Wet Food", 34.56m },
                    { new Guid("93cff757-4e73-4cdc-9b82-301487279973"), "accessories", "Have your cat eat in style out of this 100% titanium Legacy™ branded food bowl!", "Legacy™ Cat Food Bowl", 45.67m },
                    { new Guid("b441d184-dad8-4dd2-a51c-87237626d5a2"), "food", "Wet Food", "Hearty, chunky, pieces of 84% mercury-free tuna. 1 kilogram of wet food.", 23.45m },
                    { new Guid("d030401f-a23d-4dfb-b9ed-e4dbb5592229"), "medical", "Say \"no\" to painful teeth cleanings, and \"Yes!\" to Beigies™ feline dental treats! Pack of 24.", "Beigies™ Rodent-Shaped Dental Treats", 67.89m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("56fbbf63-72a6-4b90-9e20-a4ded12023ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("675a1baf-627f-41a1-944f-bd79f1a17a45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f7dbbbe-c233-4883-a2d8-4dc1b79f97dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93cff757-4e73-4cdc-9b82-301487279973"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b441d184-dad8-4dd2-a51c-87237626d5a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d030401f-a23d-4dfb-b9ed-e4dbb5592229"));

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("15698fdb-b9e8-4492-a9c6-bbd2061130e7"), "Have your cat bother the robot instead of you in the morning! Connect the Legacy™ Automated Cat Feeder to your stupid home IoT network for extra functionality. Singularity kill-switch sold separately.", "Legacy™ Automated Cat Feeder", 56.78m },
                    { new Guid("31672b5c-0cc2-472f-ad48-7dbe0e45d4ec"), "It's rainbows and unicorns with our most luxury wet food - literally! Made from 100% queer horse/narwhal hybrids. 1 kilogram of wet food.", "Superpremium Wet Food", 34.56m },
                    { new Guid("52dd8d7b-761c-4dd6-ae30-870255d13c8b"), "Wet Food", "Hearty, chunky, pieces of 84% mercury-free tuna. 1 kilogram of wet food.", 23.45m },
                    { new Guid("718ebdc0-47c6-40e5-90ce-58c824194d5f"), "Premium, delicious, kibble made from free range, grass-fed horses. 1 kilogram of kibble.", "Dry Food", 12.34m },
                    { new Guid("be5ac3ae-7462-409d-aed4-9850b65ff9f0"), "Have your cat eat in style out of this 100% titanium Legacy™ branded food bowl!", "Legacy™ Cat Food Bowl", 45.67m },
                    { new Guid("f5d1c1af-5665-48eb-96d1-b6e9de9b2d8d"), "Say \"no\" to painful teeth cleanings, and \"Yes!\" to Beigies™ feline dental treats! Pack of 24.", "Beigies™ Rodent-Shaped Dental Treats", 67.89m }
                });
        }
    }
}
