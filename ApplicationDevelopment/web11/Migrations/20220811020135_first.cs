using Microsoft.EntityFrameworkCore.Migrations;

namespace web11.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Population = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    BankId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branch_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Capital",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Area = table.Column<float>(nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capital", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Capital_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bank",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Vietcombank", "National" },
                    { 2, "Vietcombank", "National" },
                    { 3, "Vietcombank", "National" },
                    { 4, "Vietcombank", "National" },
                    { 5, "Vietcombank", "National" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name", "Population" },
                values: new object[,]
                {
                    { 4, "Viet Nam", 100000000 },
                    { 3, "Viet Nam", 100000000 },
                    { 5, "Viet Nam", 100000000 },
                    { 1, "Viet Nam", 100000000 },
                    { 2, "Viet Nam", 100000000 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "C# course", "C#" },
                    { 2, "C# course", "C#" },
                    { 3, "C# course", "C#" },
                    { 4, "C# course", "C#" },
                    { 5, "C# course", "C#" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 4, "tuan@fpt.edu.vn", "Minh Tuan" },
                    { 1, "tuan@fpt.edu.vn", "Minh Tuan" },
                    { 2, "tuan@fpt.edu.vn", "Minh Tuan" },
                    { 3, "tuan@fpt.edu.vn", "Minh Tuan" },
                    { 5, "tuan@fpt.edu.vn", "Minh Tuan" }
                });

            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "Address", "BankId", "Name" },
                values: new object[,]
                {
                    { 1, "2 Pham Van Bach", 1, "Cau Giay" },
                    { 5, "2 Pham Van Bach", 1, "Cau Giay" },
                    { 2, "2 Pham Van Bach", 2, "Cau Giay" },
                    { 4, "2 Pham Van Bach", 2, "Cau Giay" },
                    { 3, "2 Pham Van Bach", 3, "Cau Giay" }
                });

            migrationBuilder.InsertData(
                table: "Capital",
                columns: new[] { "Id", "Area", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 0f, 1, "Hà Nội" },
                    { 2, 0f, 2, "Hà Nội" },
                    { 4, 0f, 3, "Hà Nội" },
                    { 5, 0f, 4, "Hà Nội" },
                    { 3, 0f, 5, "Hà Nội" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourse",
                columns: new[] { "StudentId", "CourseId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_BankId",
                table: "Branch",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Capital_CountryId",
                table: "Capital",
                column: "CountryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Capital");

            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
