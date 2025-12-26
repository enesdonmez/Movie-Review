using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieReview.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Serieses",
                columns: table => new
                {
                    SeriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstAirDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedYear = table.Column<int>(type: "int", nullable: false),
                    AverageEpisodeDuration = table.Column<int>(type: "int", nullable: true),
                    SeasonCount = table.Column<int>(type: "int", nullable: false),
                    EpisodeCount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serieses", x => x.SeriesId);
                    table.ForeignKey(
                        name: "FK_Serieses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Serieses_CategoryId",
                table: "Serieses",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Serieses");
        }
    }
}
