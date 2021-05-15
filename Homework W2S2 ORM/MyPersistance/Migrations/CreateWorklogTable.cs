using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TemaS2MiercuriV2
{
    public partial class CreateWorklogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Worklog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreelancerId = table.Column<int>(nullable: false),
                    Day = table.Column<DateTime>(nullable: false),
                    Hours = table.Column<int>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worklog", x => x.Id);
                    table.UniqueConstraint("Daylog", x => new { x.FreelancerId, x.Day });
                    table.CheckConstraint("MaxHours", "Hours<=8");
                    table.CheckConstraint("MaxHours", "Hours>0");
                    table.ForeignKey(
                        name: "FK_Worklog_Freelancer", 
                        column: x => x.FreelancerId, 
                        principalTable: "Freelancer",
                        principalColumn:"Id");
                    table.ForeignKey(
                        name: "FK_Worklog_Project",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Worklog");
        }
    }
}
