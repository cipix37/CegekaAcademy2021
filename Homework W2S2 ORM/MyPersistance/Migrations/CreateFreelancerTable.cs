using Microsoft.EntityFrameworkCore.Migrations;

namespace TemaS2MiercuriV2
{
    public partial class CreateFreelancerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Freelancer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<float>(nullable: false),
                    Name = table.Column<string>(maxLength: 25, nullable: false),
                    Adress = table.Column<string>(maxLength: 100, nullable: false),
                    ZipcodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Freelancer_Zipcode",
                        column: x => x.ZipcodeId,
                        principalTable: "Zipcode",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Freelancer");
        }
    }
}
