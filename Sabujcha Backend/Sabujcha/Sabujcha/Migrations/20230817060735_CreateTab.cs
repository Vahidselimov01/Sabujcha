using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabujcha.Migrations
{
    public partial class CreateTab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Actions",
                table: "NavDropNames",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Areas",
                table: "NavDropNames",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Controllers",
                table: "NavDropNames",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Actions",
                table: "NavDropNames");

            migrationBuilder.DropColumn(
                name: "Areas",
                table: "NavDropNames");

            migrationBuilder.DropColumn(
                name: "Controllers",
                table: "NavDropNames");
        }
    }
}
