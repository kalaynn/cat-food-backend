using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebStore.Database.Migrations
{
    /// <inheritdoc />
    public partial class FixWetFoodProductSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4dd6fd9a-fb81-4acb-805a-548f96a84c25"), "medical", "Say \"no\" to painful teeth cleanings, and \"Yes!\" to Beigies™ feline dental treats! Pack of 24.", "Beigies™ Rodent-Shaped Dental Treats", 67.89m },
                    { new Guid("7d3773bf-9ec8-40a6-948e-2e4b192c7438"), "food", "Premium, delicious, kibble made from free range, grass-fed horses. 1 kilogram of kibble.", "Dry Food", 12.34m },
                    { new Guid("891558b7-3435-4cc8-8d31-fd1892fb679b"), "accessories", "Have your cat eat in style out of this 100% titanium Legacy™ branded food bowl!", "Legacy™ Cat Food Bowl", 45.67m },
                    { new Guid("8b3ab2d4-19bf-44db-af92-3c258050da97"), "food", "Hearty, chunky, pieces of 84% mercury-free tuna. 1 kilogram of wet food.", "Wet Food", 23.45m },
                    { new Guid("a0e28731-5f5c-4b14-b634-a626591ea564"), "food", "It's rainbows and unicorns with our most luxury wet food - literally! Made from 100% queer horse/narwhal hybrids. 1 kilogram of wet food.", "Superpremium Wet Food", 34.56m },
                    { new Guid("fed99aa7-5bea-412b-9148-b9253ac9c7f3"), "accessories", "Have your cat bother the robot instead of you in the morning! Connect the Legacy™ Automated Cat Feeder to your stupid home IoT network for extra functionality. Singularity kill-switch sold separately.", "Legacy™ Automated Cat Feeder", 56.78m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4dd6fd9a-fb81-4acb-805a-548f96a84c25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d3773bf-9ec8-40a6-948e-2e4b192c7438"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("891558b7-3435-4cc8-8d31-fd1892fb679b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b3ab2d4-19bf-44db-af92-3c258050da97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0e28731-5f5c-4b14-b634-a626591ea564"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fed99aa7-5bea-412b-9148-b9253ac9c7f3"));

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
    }
}
