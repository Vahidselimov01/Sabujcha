using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabujcha.Migrations
{
    public partial class CreateTableLayout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeaderCatagorys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderCatagorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeaderNavs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BasketIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderNavs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatagoryNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    HeaderCatagorysId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatagoryNames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatagoryNames_HeaderCatagorys_HeaderCatagorysId",
                        column: x => x.HeaderCatagorysId,
                        principalTable: "HeaderCatagorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NavDropNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    HeaderNavId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavDropNames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NavDropNames_HeaderNavs_HeaderNavId",
                        column: x => x.HeaderNavId,
                        principalTable: "HeaderNavs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatagoryNames_HeaderCatagorysId",
                table: "CatagoryNames",
                column: "HeaderCatagorysId");

            migrationBuilder.CreateIndex(
                name: "IX_NavDropNames_HeaderNavId",
                table: "NavDropNames",
                column: "HeaderNavId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatagoryNames");

            migrationBuilder.DropTable(
                name: "NavDropNames");

            migrationBuilder.DropTable(
                name: "HeaderCatagorys");

            migrationBuilder.DropTable(
                name: "HeaderNavs");
        }
    }
}
