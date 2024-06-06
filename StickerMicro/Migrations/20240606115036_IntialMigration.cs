using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StickerMicro.Migrations
{
    /// <inheritdoc />
    public partial class IntialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaTypes",
                columns: table => new
                {
                    MediaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MediaCode = table.Column<string>(type: "TEXT", nullable: false),
                    MediaName = table.Column<string>(type: "TEXT", nullable: false),
                    ShelfLife = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaTypes", x => x.MediaId);
                });

            migrationBuilder.CreateTable(
                name: "PrintLabels",
                columns: table => new
                {
                    LabelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MediaId = table.Column<int>(type: "INTEGER", nullable: false),
                    SerialNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrintLabels", x => x.LabelId);
                    table.ForeignKey(
                        name: "FK_PrintLabels_MediaTypes_MediaId",
                        column: x => x.MediaId,
                        principalTable: "MediaTypes",
                        principalColumn: "MediaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaId", "MediaCode", "MediaName", "ShelfLife" },
                values: new object[,]
                {
                    { 1, "TSB", "Tryptic soy broth", 3 },
                    { 2, "CET", "Cetrimide agar", 3 },
                    { 3, "PBS", "Phosphate buffer solution (pH 7,0)", 3 },
                    { 4, "GLB", "glutamate broth", 3 },
                    { 5, "CCA", "Chromogenic Coliform Agar", 3 },
                    { 6, "VRB", "violet red bile glucose agar", 3 },
                    { 7, "McB", "MacConkey broth", 3 },
                    { 8, "McA", "MacConkey agar", 3 },
                    { 9, "PCA", "Plate count agar", 3 },
                    { 10, "TSA", "Tryptic soy agar", 3 },
                    { 11, "SDA", "Sabouraud-dextrose agar", 3 },
                    { 12, "BGA", "Brilliant green agar", 3 },
                    { 13, "XLD", "Xylose Lysine Deoxycholate agar", 3 },
                    { 14, "MKB", "Müller-Kauffman tetrathionate-novobiocin broth", 3 },
                    { 15, "RVS", "Rappaport-Vassiliadis Salmonella", 3 },
                    { 16, "BPW", "Buffered peptone water", 3 },
                    { 17, "MYA", "Meat yeast agar", 3 },
                    { 18, "LSB", "Lactose Sulfiet broth", 3 },
                    { 19, "NCP", "Natrium chloride-peptone buffer", 3 },
                    { 20, "ABM", "Antibiotic medium", 3 },
                    { 21, "EEB", "Enterobacteriaceae enrichment broth", 3 },
                    { 22, "SAB", "Sabouraud dextrose agar", 3 },
                    { 23, "BTW", "Buffer + tween", 3 },
                    { 24, "LAB", "Lactose broth", 3 },
                    { 25, "HER", "Herellea agar", 3 },
                    { 26, "MSA", "Mannitol salt agar", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrintLabels_MediaId",
                table: "PrintLabels",
                column: "MediaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrintLabels");

            migrationBuilder.DropTable(
                name: "MediaTypes");
        }
    }
}
