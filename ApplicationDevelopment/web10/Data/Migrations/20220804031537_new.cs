using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web10.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Salary = table.Column<float>(nullable: false),
                    Mobile = table.Column<string>(maxLength: 10, nullable: true),
                    Image = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg", "HR" },
                    { 2, "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg", "IT" },
                    { 3, "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg", "Accounting" },
                    { 4, "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg", "Security" },
                    { 5, "https://elt.rti.org.tw/wp-content/uploads/2018/01/960x540_learning-english-qa-firm-company-enterprise-imagegetty.jpg", "Medical" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Address", "DepartmentId", "Dob", "Gender", "Image", "Mobile", "Name", "Salary" },
                values: new object[,]
                {
                    { 16, "Ha Noi - Viet Nam", 1, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f },
                    { 11, "Ha Noi - Viet Nam", 2, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f },
                    { 15, "Ha Noi - Viet Nam", 2, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f },
                    { 17, "Ha Noi - Viet Nam", 2, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f },
                    { 18, "Ha Noi - Viet Nam", 2, new DateTime(1996, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f },
                    { 20, "Ha Noi - Viet Nam", 2, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "F", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f },
                    { 10, "Ha Noi - Viet Nam", 3, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f },
                    { 14, "Ha Noi - Viet Nam", 3, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f },
                    { 19, "Ha Noi - Viet Nam", 3, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f },
                    { 12, "Ha Noi - Viet Nam", 4, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f },
                    { 13, "Ha Noi - Viet Nam", 5, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", "https://cdn1.vectorstock.com/i/1000x1000/13/05/office-staff-vector-17721305.jpg", "0912345678", "Minh", 1000f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_DepartmentId",
                table: "Staffs",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
