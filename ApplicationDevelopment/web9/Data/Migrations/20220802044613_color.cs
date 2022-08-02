using Microsoft.EntityFrameworkCore.Migrations;

namespace web9.Data.Migrations
{
    public partial class color : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Mobile",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Color",
                table: "Mobile",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
