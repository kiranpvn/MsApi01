using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreApp01.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblDepartments",
                columns: table => new
                {
                    DId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDepartments", x => x.DId);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EName = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    DId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEmployees_tblDepartments_DId1",
                        column: x => x.DId1,
                        principalTable: "tblDepartments",
                        principalColumn: "DId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "tblDepartments",
                columns: new[] { "DId", "DName", "Location" },
                values: new object[,]
                {
                    { 10, "Software", "USA" },
                    { 20, "Hardware", "UK" }
                });

            migrationBuilder.InsertData(
                table: "tblEmployees",
                columns: new[] { "Id", "DId1", "EName", "Job", "Salary" },
                values: new object[,]
                {
                    { 1001, null, "Kiran", "Trainer", 5000 },
                    { 1002, null, "Raju", "Developer", 6000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployees_DId1",
                table: "tblEmployees",
                column: "DId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmployees");

            migrationBuilder.DropTable(
                name: "tblDepartments");
        }
    }
}
