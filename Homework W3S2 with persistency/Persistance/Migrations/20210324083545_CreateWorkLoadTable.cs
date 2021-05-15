using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class CreateWorkLoadTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkLoad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoOfHours = table.Column<int>(nullable: false),
                    FreelancerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLoad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkLoad_Freelancer_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "Freelancer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkLoad_FreelancerId",
                table: "WorkLoad",
                column: "FreelancerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkLoad");
        }
    }
}
