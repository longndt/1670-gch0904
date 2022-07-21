using Microsoft.EntityFrameworkCore.Migrations;

namespace web3.Data.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Mobile",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Mobile",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Mobile");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Mobile");
        }
    }
}
