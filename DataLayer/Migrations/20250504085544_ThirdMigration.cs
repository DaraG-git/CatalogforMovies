using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Rankings_RankingID",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Rankings");

            migrationBuilder.DropIndex(
                name: "IX_Movies_RankingID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "RankingID",
                table: "Movies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RankingID",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rankings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ViewersID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rankings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rankings_Viewers_ViewersID",
                        column: x => x.ViewersID,
                        principalTable: "Viewers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_RankingID",
                table: "Movies",
                column: "RankingID");

            migrationBuilder.CreateIndex(
                name: "IX_Rankings_ViewersID",
                table: "Rankings",
                column: "ViewersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Rankings_RankingID",
                table: "Movies",
                column: "RankingID",
                principalTable: "Rankings",
                principalColumn: "ID");
        }
    }
}
