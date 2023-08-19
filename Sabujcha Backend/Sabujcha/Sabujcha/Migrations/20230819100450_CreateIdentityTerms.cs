using Microsoft.EntityFrameworkCore.Migrations;

namespace Sabujcha.Migrations
{
    public partial class CreateIdentityTerms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TermsConfirmed",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TermsConfirmed",
                table: "AspNetUsers");
        }
    }
}
