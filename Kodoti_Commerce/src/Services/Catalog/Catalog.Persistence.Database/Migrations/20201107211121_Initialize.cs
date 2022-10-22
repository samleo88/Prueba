using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 324m },
                    { 72, "Description for product 72", "Product 72", 595m },
                    { 71, "Description for product 71", "Product 71", 249m },
                    { 70, "Description for product 70", "Product 70", 708m },
                    { 69, "Description for product 69", "Product 69", 577m },
                    { 68, "Description for product 68", "Product 68", 268m },
                    { 67, "Description for product 67", "Product 67", 646m },
                    { 66, "Description for product 66", "Product 66", 834m },
                    { 65, "Description for product 65", "Product 65", 646m },
                    { 64, "Description for product 64", "Product 64", 279m },
                    { 63, "Description for product 63", "Product 63", 762m },
                    { 62, "Description for product 62", "Product 62", 298m },
                    { 61, "Description for product 61", "Product 61", 698m },
                    { 60, "Description for product 60", "Product 60", 933m },
                    { 59, "Description for product 59", "Product 59", 669m },
                    { 58, "Description for product 58", "Product 58", 753m },
                    { 57, "Description for product 57", "Product 57", 118m },
                    { 56, "Description for product 56", "Product 56", 184m },
                    { 55, "Description for product 55", "Product 55", 839m },
                    { 54, "Description for product 54", "Product 54", 866m },
                    { 53, "Description for product 53", "Product 53", 574m },
                    { 52, "Description for product 52", "Product 52", 389m },
                    { 73, "Description for product 73", "Product 73", 492m },
                    { 51, "Description for product 51", "Product 51", 790m },
                    { 74, "Description for product 74", "Product 74", 286m },
                    { 76, "Description for product 76", "Product 76", 856m },
                    { 97, "Description for product 97", "Product 97", 240m },
                    { 96, "Description for product 96", "Product 96", 364m },
                    { 95, "Description for product 95", "Product 95", 197m },
                    { 94, "Description for product 94", "Product 94", 336m },
                    { 93, "Description for product 93", "Product 93", 279m },
                    { 92, "Description for product 92", "Product 92", 254m },
                    { 91, "Description for product 91", "Product 91", 513m },
                    { 90, "Description for product 90", "Product 90", 107m },
                    { 89, "Description for product 89", "Product 89", 808m },
                    { 88, "Description for product 88", "Product 88", 213m },
                    { 87, "Description for product 87", "Product 87", 903m },
                    { 86, "Description for product 86", "Product 86", 422m },
                    { 85, "Description for product 85", "Product 85", 662m },
                    { 84, "Description for product 84", "Product 84", 994m },
                    { 83, "Description for product 83", "Product 83", 185m },
                    { 82, "Description for product 82", "Product 82", 504m },
                    { 81, "Description for product 81", "Product 81", 191m },
                    { 80, "Description for product 80", "Product 80", 579m },
                    { 79, "Description for product 79", "Product 79", 371m },
                    { 78, "Description for product 78", "Product 78", 572m },
                    { 77, "Description for product 77", "Product 77", 747m },
                    { 75, "Description for product 75", "Product 75", 134m },
                    { 98, "Description for product 98", "Product 98", 313m },
                    { 50, "Description for product 50", "Product 50", 244m },
                    { 48, "Description for product 48", "Product 48", 125m },
                    { 22, "Description for product 22", "Product 22", 239m },
                    { 21, "Description for product 21", "Product 21", 759m },
                    { 20, "Description for product 20", "Product 20", 597m },
                    { 19, "Description for product 19", "Product 19", 982m },
                    { 18, "Description for product 18", "Product 18", 662m },
                    { 17, "Description for product 17", "Product 17", 444m },
                    { 16, "Description for product 16", "Product 16", 157m },
                    { 15, "Description for product 15", "Product 15", 240m },
                    { 14, "Description for product 14", "Product 14", 669m },
                    { 13, "Description for product 13", "Product 13", 815m },
                    { 12, "Description for product 12", "Product 12", 626m },
                    { 11, "Description for product 11", "Product 11", 313m },
                    { 10, "Description for product 10", "Product 10", 358m },
                    { 9, "Description for product 9", "Product 9", 632m },
                    { 8, "Description for product 8", "Product 8", 901m },
                    { 7, "Description for product 7", "Product 7", 919m },
                    { 6, "Description for product 6", "Product 6", 228m },
                    { 5, "Description for product 5", "Product 5", 498m },
                    { 4, "Description for product 4", "Product 4", 358m },
                    { 3, "Description for product 3", "Product 3", 116m },
                    { 2, "Description for product 2", "Product 2", 628m },
                    { 23, "Description for product 23", "Product 23", 609m },
                    { 49, "Description for product 49", "Product 49", 635m },
                    { 24, "Description for product 24", "Product 24", 362m },
                    { 26, "Description for product 26", "Product 26", 564m },
                    { 47, "Description for product 47", "Product 47", 473m },
                    { 46, "Description for product 46", "Product 46", 210m },
                    { 45, "Description for product 45", "Product 45", 990m },
                    { 44, "Description for product 44", "Product 44", 136m },
                    { 43, "Description for product 43", "Product 43", 492m },
                    { 42, "Description for product 42", "Product 42", 903m },
                    { 41, "Description for product 41", "Product 41", 563m },
                    { 40, "Description for product 40", "Product 40", 795m },
                    { 39, "Description for product 39", "Product 39", 270m },
                    { 38, "Description for product 38", "Product 38", 848m },
                    { 37, "Description for product 37", "Product 37", 907m },
                    { 36, "Description for product 36", "Product 36", 531m },
                    { 35, "Description for product 35", "Product 35", 191m },
                    { 34, "Description for product 34", "Product 34", 647m },
                    { 33, "Description for product 33", "Product 33", 979m },
                    { 32, "Description for product 32", "Product 32", 478m },
                    { 31, "Description for product 31", "Product 31", 711m },
                    { 30, "Description for product 30", "Product 30", 452m },
                    { 29, "Description for product 29", "Product 29", 238m },
                    { 28, "Description for product 28", "Product 28", 720m },
                    { 27, "Description for product 27", "Product 27", 529m },
                    { 25, "Description for product 25", "Product 25", 689m },
                    { 99, "Description for product 99", "Product 99", 489m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 10 },
                    { 72, 72, 3 },
                    { 71, 71, 17 },
                    { 70, 70, 0 },
                    { 69, 69, 16 },
                    { 68, 68, 16 },
                    { 67, 67, 10 },
                    { 66, 66, 17 },
                    { 65, 65, 0 },
                    { 64, 64, 0 },
                    { 63, 63, 15 },
                    { 62, 62, 9 },
                    { 61, 61, 3 },
                    { 60, 60, 1 },
                    { 59, 59, 10 },
                    { 58, 58, 18 },
                    { 57, 57, 12 },
                    { 56, 56, 16 },
                    { 55, 55, 14 },
                    { 54, 54, 11 },
                    { 53, 53, 17 },
                    { 52, 52, 13 },
                    { 73, 73, 4 },
                    { 51, 51, 8 },
                    { 74, 74, 12 },
                    { 76, 76, 14 },
                    { 97, 97, 1 },
                    { 96, 96, 18 },
                    { 95, 95, 17 },
                    { 94, 94, 11 },
                    { 93, 93, 15 },
                    { 92, 92, 18 },
                    { 91, 91, 2 },
                    { 90, 90, 6 },
                    { 89, 89, 13 },
                    { 88, 88, 6 },
                    { 87, 87, 18 },
                    { 86, 86, 14 },
                    { 85, 85, 18 },
                    { 84, 84, 2 },
                    { 83, 83, 5 },
                    { 82, 82, 6 },
                    { 81, 81, 4 },
                    { 80, 80, 18 },
                    { 79, 79, 17 },
                    { 78, 78, 19 },
                    { 77, 77, 3 },
                    { 75, 75, 5 },
                    { 98, 98, 9 },
                    { 50, 50, 9 },
                    { 48, 48, 7 },
                    { 22, 22, 14 },
                    { 21, 21, 10 },
                    { 20, 20, 12 },
                    { 19, 19, 13 },
                    { 18, 18, 17 },
                    { 17, 17, 9 },
                    { 16, 16, 14 },
                    { 15, 15, 15 },
                    { 14, 14, 0 },
                    { 13, 13, 5 },
                    { 12, 12, 8 },
                    { 11, 11, 13 },
                    { 10, 10, 8 },
                    { 9, 9, 8 },
                    { 8, 8, 7 },
                    { 7, 7, 6 },
                    { 6, 6, 17 },
                    { 5, 5, 19 },
                    { 4, 4, 7 },
                    { 3, 3, 15 },
                    { 2, 2, 10 },
                    { 23, 23, 18 },
                    { 49, 49, 11 },
                    { 24, 24, 17 },
                    { 26, 26, 18 },
                    { 47, 47, 14 },
                    { 46, 46, 17 },
                    { 45, 45, 19 },
                    { 44, 44, 19 },
                    { 43, 43, 10 },
                    { 42, 42, 16 },
                    { 41, 41, 7 },
                    { 40, 40, 1 },
                    { 39, 39, 13 },
                    { 38, 38, 6 },
                    { 37, 37, 16 },
                    { 36, 36, 14 },
                    { 35, 35, 3 },
                    { 34, 34, 8 },
                    { 33, 33, 17 },
                    { 32, 32, 15 },
                    { 31, 31, 8 },
                    { 30, 30, 7 },
                    { 29, 29, 12 },
                    { 28, 28, 17 },
                    { 27, 27, 13 },
                    { 25, 25, 16 },
                    { 99, 99, 19 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
