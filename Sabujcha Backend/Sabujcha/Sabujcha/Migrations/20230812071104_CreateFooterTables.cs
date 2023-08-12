using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabujcha.Migrations
{
    public partial class CreateFooterTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FooterTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FooterContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    TitlesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FooterContents_FooterTitles_TitlesId",
                        column: x => x.TitlesId,
                        principalTable: "FooterTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FooterContents_TitlesId",
                table: "FooterContents",
                column: "TitlesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FooterContents");

            migrationBuilder.DropTable(
                name: "FooterTitles");
        }
    }
}
